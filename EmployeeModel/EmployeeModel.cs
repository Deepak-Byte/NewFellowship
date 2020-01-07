//----------------------------------------------------------------------------
// <copyright file="EmployeeModel.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------------
namespace EmployeeCommanLayer.EmployeeModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This is EmployeeModel class which get set the value of each.
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        //[RegularExpression(@"^(?i)(individual|staff)$", ErrorMessage = "It Should Be Only Integer")]
        //[Required(ErrorMessage ="Id Number Is Required In Integer")]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        // [StringLength(15), Required(ErrorMessage ="Name Requird Only In String Format")]
        [RegularExpression(@"^[a-zA-Z\s]+$")]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [StringLength(25),Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
      //  [MaxLength(13),Required]
        [RegularExpression(@"^\d{1,15}$", ErrorMessage = "Please enter up to 15 digits for a contact number")]
        public string Number { get; set; }
        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        //[Range(0,100),Required]
        [RegularExpression(@"^[0-9]*$")]
        public string Age { get; set; }
    }
}
