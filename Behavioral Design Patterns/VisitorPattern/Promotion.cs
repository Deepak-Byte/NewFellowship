//---------------------------------------------------------------------
// <copyright file="Promotion.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.VisitorPattern
{
    /// <summary>
    /// This is calss Promotion.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.VisitorPattern.IVisitor" />
    public class Promotion:IVisitor
    {
        //public void Visit(Vehicle vehicle)
        //{
        //    vehicle.cost = (int)(vehicle.cost * 0.9);
        //}        
        /// <summary>
        /// Visitors the specified vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public void Visitor(Matket vehicle)
        {
            vehicle.cost = (int)(vehicle.cost * 0.9);
        }
    }
}
