using Bayad_Center_Project.Entities;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Bayad_Center_Project.Services
{
    public class ServiceService
    {
        private readonly ServiceContext _dbContext;

        public ServiceService(ServiceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool DeleteServiceById(int serviceID)
        {
            var service = _dbContext.Services.FirstOrDefault(u => u.Id == serviceID);
            if (service == null)
                throw new Exception($"Service with ID: {serviceID} does not exist.");

            _dbContext.Services.Remove(service);
            _dbContext.SaveChanges();

            return true;
        }

        public bool EditServiceById(int serviceID, Service service)
        {
            var u = _dbContext.Services.FirstOrDefault(u => u.Id == serviceID);
            if (u == null)
                throw new Exception($"Service with the id: {serviceID} does not exist.");

            var invalidFields = service.GetType().GetProperties()
            .Where(p => p.PropertyType == typeof(string))
            .Where(p => p.GetValue(service) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
            .Cast<MaxLengthAttribute>()
            .FirstOrDefault()?.Length)
            .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");

            if (service.Icon == null)
                throw new ValidationException($"Set an icon first before creating.");

            u.Name = service.Name;
            u.Description = service.Description;
            u.Icon = service.Icon;

            _dbContext.SaveChanges();

            return true;
        }

        public bool RegisterService(Service service)
        {
            if (_dbContext.Services.Any(u => u.Name == service.Name))
                throw new Exception("This service already exist.");

            var invalidFields = service.GetType().GetProperties()
            .Where(p => p.PropertyType == typeof(string))
            .Where(p => p.GetValue(service) is string value && value.Length > p.GetCustomAttributes(typeof(MaxLengthAttribute), false)
            .Cast<MaxLengthAttribute>()
            .FirstOrDefault()?.Length)
            .Select(p => p.Name);

            if (invalidFields.Any())
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");

            if (service.Icon == null)
                throw new ValidationException($"Set an icon first before creating.");

            _dbContext.Services.Add(service);
            _dbContext.SaveChanges();
            return true;
        }

        public Service GetServiceById(int serviceId)
        {
            var service = _dbContext.Services.FirstOrDefault(u => u.Id == serviceId);
            if (service == null)
                throw new Exception("Service with ID " + serviceId + " not found.");

            return service;
        }

        public void PopulateTable(DataGridView dataGridView)
        {
            try
            {
                List<Service> services = _dbContext.Services.ToList();

                dataGridView.Rows.Clear();

                if (dataGridView.Columns.Count == 0)
                {
                    foreach (var propertyInfo in typeof(Service).GetProperties())
                        dataGridView.Columns.Add(propertyInfo.Name, propertyInfo.Name);
                }

                foreach (var service in services)
                {
                    int rowIndex = dataGridView.Rows.Add();

                    foreach (var propertyInfo in typeof(Service).GetProperties())
                        dataGridView.Rows[rowIndex].Cells[propertyInfo.Name].Value = propertyInfo.GetValue(service);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

    }
}