//---------------------------------------------------------------------
// <copyright file="ConcreteComputerFactory.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPattern.PrototypeDesignPattern
{
    /// <summary>
    /// This is class IEmployee.
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        IEmployee Clone();
    }
}
