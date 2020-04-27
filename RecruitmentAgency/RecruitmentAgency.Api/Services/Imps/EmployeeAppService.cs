using AutoMapper;
using System.Collections.Generic;

using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Managers;


namespace RecruitmentAgency.Api.Services.Imps
{
    /// <summary>
    /// Серфис для работы с работодателями
    /// </summary>
    public class EmployeeAppService : IEmployeeAppService
    {
        private readonly IEmployeeManager employeeManager;

        private readonly IUserManager userManager;

        private readonly IMapper mapper;

        public EmployeeAppService(IEmployeeManager employeeManager, IUserManager userManager, IMapper mapper)
        {
            this.employeeManager = employeeManager;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        /// <inheritdoc/>
        public EmployeeDTO Create(CreateEmployeeDTO createEmployeeDTO)
        {
            var employee = mapper.Map<Employee>(createEmployeeDTO);
            employee.User = userManager.Get(createEmployeeDTO.UserName);
            var entity = employeeManager.Create(employee);
            return mapper.Map<EmployeeDTO>(entity);
        }

        /// <inheritdoc/>
        public EmployeeDTO Update(UpdateEmployeeDTO updateEmployeeDTO)
        {
            var employee = mapper.Map<Employee>(updateEmployeeDTO);
            var entity = employeeManager.Update(employee);
            return mapper.Map<EmployeeDTO>(entity);
        }

        /// <inheritdoc/>
        public EmployeeDTO Get(int id)
        {            
            var entity = employeeManager.Get(id);
            return mapper.Map<EmployeeDTO>(entity);
        }

        /// <inheritdoc/>
        public ICollection<EmployeeDTO> GetAll()
        {
            return mapper.Map<ICollection<EmployeeDTO>>(employeeManager.GetAll());
        }

        /// <inheritdoc/>
        public EmployeeDTO GetByUser(string login)
        {
            var entity = employeeManager.GetByUser(login);
            return mapper.Map<EmployeeDTO>(entity);
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            employeeManager.Delete(id);
        }
    }
}
