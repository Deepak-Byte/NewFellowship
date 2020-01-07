//----------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------------
namespace EmployeeAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeBusinessLayer.InterfaceBusinessLayer;
    using EmployeeCommanLayer.EmployeeModel;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// This is class EmployeeController which perform a database to fronend connection.
    /// which i perform by ApiController and by Route which guide the API to appropreate method.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The employeebusiness.
        /// </summary>
        private readonly IEmployeeBusinessLayer employeebusiness;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// In constructor of EmployeeController initializing a Interface of BusinessLayer. 
        /// </summary>
        /// <param name="employeebusinesslayer">The employeebusinesslayer.</param>
        public EmployeeController(IEmployeeBusinessLayer employeebusinesslayer)
        {
            this.employeebusiness = employeebusinesslayer;
        }
        /// <summary>
        /// Adds the employee method controller which add the coming data from frontend to backed.
        /// whic in from of employee model only.
        /// IActionResult is an interface, we can create a custom response as a return,
        /// when you use ActionResult you can return only predefined ones for returning a View or a resource.
        /// With IActionResult we can return error also.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        public IActionResult AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                bool result = employeebusiness.AddEmployee(employeeModel);
                if (result == true)
                {
                    string message = "Employee Added Successfully";
                    return Ok(new { result , message , employeeModel});
                    //return Content("Employee Added Successfully");
                }
                else
                {
                    string message = "Either Email Already Exit Or Techanicale Problem";
                    return Ok(new { message });
                    //return BadRequest("Employee Already Exit");
                }
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        /// <summary>
        /// Deletes the employee Delete ny ID which will acept only int ID.
        /// and return IAction type of statemenet.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete/{ID}")]
        public IActionResult DeleteEmployee(int ID)
        {
            try
            {
                var deleteresult = employeebusiness.DeleteEmployee(ID);
                if (deleteresult ==true)
                {
                    string message = "Employee Data Has Been Deleted SuccessFully";
                    return Ok(new { deleteresult , message});
                }
                else
                {
                    string message = "Employee Data Not Deleted Or Already Deleted";
                    return Ok(new { message });
                    //return BadRequest("Employee Data Not Deleted Yet");
                }
                //return Content("Deleted Successfully");
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }
        /// <summary>
        /// Updates the employee method which update employee model.
        /// </summary>
        /// <param name="employeeModels">The employee models.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("update")]
        public IActionResult UpdateEmployee(EmployeeModel employeeModels)
        {
            try
            {
                var updateresult = employeebusiness.UpdateEmployee(employeeModels);
                if (updateresult == true)
                {
                    string message = "Employee Data Has Been Updated Successfully";
                    return Ok(new { updateresult , message , employeeModels });
                }
                else
                {
                    return BadRequest("Data Not Updated Yet");
                }
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        /// <summary>
        /// Displays the employee.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("view")]
        public IActionResult DisplayEmployee()
        {
            try
            {
                var list = employeebusiness.DisplayEmployee();
                return Ok(new { list }); 
            }
            catch (Exception Exception)
            {
                throw Exception;
            }
        }

        /// <summary>
        /// Displays the employeeby identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("viewId/{ID}")]
        public IActionResult DisplayEmployeebyID(int ID)
        {
            try
            {
                ////taking all data from database in employee model format.
                EmployeeModel singleEmployeedata = employeebusiness.DisplayEmployeebyID(ID);
                return Ok(new { singleEmployeedata });
            }
            catch(Exception Exception)
            {
                throw Exception;
            }
        }
    }
}