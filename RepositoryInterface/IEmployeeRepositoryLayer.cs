//----------------------------------------------------------------------------
// <copyright file="IEmployeeRepositoryLayer.inteface" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------------
namespace EmployeeRepositoryLayer.RepositoryInterface
{
    using EmployeeCommanLayer.EmployeeModel;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// this is IEmployeeRepositoryLayer interface under which number of method are defined. 
    /// </summary>
    public interface IEmployeeRepositoryLayer
    {
        /// <summary>
        /// Adds the employee id method which take employee employee model .
        /// </summary>
        /// <param name="employeeModels">The employee models.</param>
        /// <returns></returns>
        bool AddEmployee(EmployeeModel employeeModels);
        /// <summary>
        /// Displays the employee is method which display a list of employee.
        /// </summary>
        /// <returns></returns>
        IList<EmployeeModel> DisplayEmployee();
        /// <summary>
        /// Displays the employeeby identifier which display a employee by it's ID.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        EmployeeModel DisplayEmployeebyID(int ID);
        /// <summary>
        /// Updates the employee method which take ID as input and data from user to update employee Employee.
        /// </summary>
        /// <param name="employeeModels">The employee models.</param>
        /// <returns></returns>
        bool UpdateEmployee(EmployeeModel employeeModels);
        /// <summary>
        /// Deletes the employee method which take ID from uaer to delete that employee data  from data base.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(int ID);
    }
}
