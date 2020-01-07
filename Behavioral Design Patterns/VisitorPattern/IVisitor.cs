//---------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.VisitorPattern
{
    /// <summary>
    /// This is interface.
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visitors the specified vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        void Visitor(Matket vehicle);
    }
}
