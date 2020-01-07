//---------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.VisitorPattern
{
    /// <summary>
    /// This is class Vehicle.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.VisitorPattern.IAcceptVisitor" />
    public class Matket:IAcceptVisitor
    {
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        virtual public int cost { get; set; } = 0;
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }   
    /// <summary>
    /// This is class car.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.VisitorPattern.Matket" />
    public class Mealsnonveg : Matket
    {
        public override int cost { get ; set ; } = 5000;
    }
    /// <summary>
    /// This is class Truck.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.VisitorPattern.Matket" />
    public class Milk : Matket
    {
        public override int cost { get; set; } = 10000;
    }
    /// <summary>
    /// This is class Plane.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.VisitorPattern.Matket" />
    public class Busicut : Matket
    {
        public override int cost { get; set; } = 50000;
    }
    /*******************************************Permorm latter****************************************************/
    //public void Accept(IVisitor visitor)
    //{
    //    visitor.Visit(this);
    //} 
}
