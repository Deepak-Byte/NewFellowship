//----------------------------------------------------------------------------
// <copyright file="EmployeeBusiness.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------------
namespace EmployeeBusinessLayer.ServiceBusinessLayer
{
    using EmployeeBusinessLayer.InterfaceBusinessLayer;
    using EmployeeCommanLayer.EmployeeModel;
    using EmployeeRepositoryLayer.RepositoryInterface;
    using EmployeeRepositoryLayer.RepositoryService;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// This is Employee Business Layer class which contains all logical part of program.
    /// </summary>
    /// <seealso cref="EmployeeBusinessLayer.InterfaceBusinessLayer.IEmployeeBusinessLayer" />
    public class EmployeeBusiness : IEmployeeBusinessLayer
    {
        /// <summary>
        /// The employee repository
        /// </summary>
        private IEmployeeRepositoryLayer employeeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBusiness"/> class here cunstructor.
        /// In EmployeeBusiness Layer constructor initialization of IEmployeeRepositoryLayer.
        /// Also known as constructor injection.
        /// </summary>
        /// <param name="iemployeeRepository">The iemployee repository.</param>
        public EmployeeBusiness(IEmployeeRepositoryLayer iemployeeRepository)
        {
            this.employeeRepository = iemployeeRepository;
        }
        /// <summary>
        /// This is Add Employee method of IEmployeeBusinessLayer.
        /// </summary>
        /// <param name="employeeModels"></param>
        /// <returns></returns>
        public bool AddEmployee(EmployeeModel employeeModels)
        {
            if (employeeModels != null)
            {
                bool addresult =  this.employeeRepository.AddEmployee(employeeModels);
                return addresult;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// This is Empoyee Delete method  of IEmployeeBusinessLayer.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int ID)
        {
            if (ID != 0)
            {
                bool deleteresult = this.employeeRepository.DeleteEmployee(ID);
                return deleteresult;
            }
            return false;
        }
        /// <summary>
        /// This is Display all Employee  method of IEmployeeBusinessLayer.
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeModel> DisplayEmployee()
        {
            return this.employeeRepository.DisplayEmployee();
        }
        /// <summary>
        /// This is Update Employee method of IEmployeeBusinessLayer.
        /// </summary>
        /// <param name="employeeModels"></param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeModel employeeModels)
        {
            if (employeeModels != null)
            {
                bool updateresult = employeeRepository.UpdateEmployee(employeeModels);
                return updateresult;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// This is Display Employee by ID method of IEmployeeBusinessLayer.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public EmployeeModel DisplayEmployeebyID(int ID)
        {
            if (ID != 0)
            {
                EmployeeModel displaydata = employeeRepository.DisplayEmployeebyID(ID);
                return displaydata;
            }
            return null;
        }
    }
}
