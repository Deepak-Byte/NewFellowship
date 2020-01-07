//---------------------------------------------------------------------
// <copyright file="Markup.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.VisitorPattern
{
    /// <summary>
    /// This is class Markup.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.VisitorPattern.IVisitor" />
    public class Markup : IVisitor
    {
        //public void Visit(Vehicle vehicle)
        //{
        //    vehicle.cost += 7500;
        //}        
        /// <summary>
        /// Visitors the specified vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public void Visitor(Matket vehicle)
        {
            vehicle.cost += 7500;
        }
    }
}
