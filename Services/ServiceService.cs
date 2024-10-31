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
            {
                throw new ValidationException($"The following fields are too long: {string.Join(", ", invalidFields)}");
            }

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