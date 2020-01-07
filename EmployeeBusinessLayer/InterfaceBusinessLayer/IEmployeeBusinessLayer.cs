//----------------------------------------------------------------------------
// <copyright file="IEmployeeBusinessLayer.interface" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------------
namespace EmployeeBusinessLayer.InterfaceBusinessLayer
{
    using EmployeeCommanLayer.EmployeeModel;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is Interface of EmployeeBusiness Layer.
    /// </summary>
    public interface IEmployeeBusinessLayer
    {
        /// <summary>
        /// This is Add Employee method.
        /// </summary>
        /// <param name="employeeModels"></param>
        /// <returns></returns>
        bool AddEmployee(EmployeeModel employeeModels);
        /// <summary>
        /// This is Display all Employee  method.
        /// </summary>
        /// <returns></returns>
        IList<EmployeeModel> DisplayEmployee();
        /// <summary>
        /// This is Display Employee by ID method.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        EmployeeModel DisplayEmployeebyID(int ID);
        /// <summary>
        /// This is Update Employee method.
        /// </summary>
        /// <param name="employeeModels"></param>
        /// <returns></returns>
        bool UpdateEmployee(EmployeeModel employeeModels);
        /// <summary>
        /// This is Empoyee Delete method.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        bool DeleteEmployee(int ID);

    }
}
