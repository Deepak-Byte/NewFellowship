//---------------------------------------------------------------------
// <copyright file="IAcceptVisitor.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.VisitorPattern
{
    /// <summary>
    /// This is interface IAcceptVisitor.
    /// </summary>
    public interface IAcceptVisitor
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        void Accept(IVisitor visitor);
    }
}
