using Bayad_Center_Project.Contexts;
using Bayad_Center_Project.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bayad_Center_Project.Services
{
    public class ServiceService
    {
        private readonly DatabaseContext _dbContext;

        public ServiceService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddService(Service service)
        {
            ValidateServiceFields(service);

            _dbContext.Set<Service>().Add(service);
            _dbContext.SaveChanges();
            return true;
        }

        public Service GetServiceById(int serviceId)
        {
            var service = _dbContext.Set<Service>().FirstOrDefault(s => s.ServiceID == serviceId);
            if (service == null)
                throw new Exception($"Service with ID: {serviceId} not found.");

            return service;
        }

        public bool UpdateService(int serviceId, Service updatedService)
        {
            var service = _dbContext.Set<Service>().FirstOrDefault(s => s.ServiceID == serviceId);
            if (service == null)
                throw new Exception($"Service with ID: {serviceId} not found.");

            ValidateServiceFields(updatedService);

            service.Name = updatedService.Name;
            service.Description = updatedService.Description;
            service.Icon = updatedService.Icon;

            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteService(int serviceId)
        {
            using var context = new DatabaseContext();
            var service = context.Set<Service>().Find(serviceId);
            if (service == null)
                throw new Exception($"Given service does not exist.");

            if (context.Set<Transaction>().Any(t => t.ServiceId == serviceId))
                throw new Exception($"This Service is included in one or more record in Transactions.");

            context.Set<Service>().Remove(service);
            return context.SaveChanges() > 0;
        }

        public List<Service> GetAllServices()
        {
            return _dbContext.Set<Service>().ToList();
        }

        private void ValidateServiceFields(Service service)
        {
            var invalidFields = service.GetType().GetProperties()
                .Where(p => p.PropertyType == typeof(string))
                .Where(p => p.GetValue(service) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
                .Cast<MaxLengthAttribute>()
                .FirstOrDefault()?.Length)
                .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");
        }
    }
}