//---------------------------------------------------------------------
// <copyright file="LegalLimitedCommand.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Structural_Design_Patterns.ProxyDesignPattern
{
    /// <summary>
    /// This is LegalLimitedCommand class.
    /// </summary>
    /// <seealso cref="Structural_Design_Patterns.ProxyDesignPattern.InterfaceUserItem" />
    public class LegalLimitedCommand : InterfaceUserItem
    {
        /// <summary>
        /// The ishead
        /// </summary>
        private bool Ishead;
        /// <summary>
        /// The interface user
        /// </summary>
        private InterfaceUserItem InterfaceUser;
        /// <summary>
        /// Initializes a new instance of the <see cref="LegalLimitedCommand"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="secondname">The secondname.</param>
        public LegalLimitedCommand(string name, string secondname)
        {
            if ("deepak".Equals(name) && "kumar".Equals(secondname))
            { 
                 Ishead = true;
                 InterfaceUser = new CommonCommnad();
            }
        }
        /// <summary>
        /// Shows the nameof user.
        /// </summary>
        /// <param name="name">The name.</param>
        public void ShowNameofUser(string name )
        {
            if (Ishead)
            {
                InterfaceUser.ShowNameofUser(name);
            }
            else
            {
                InterfaceUser.ShowNameofUser(name);
            }
        }
    }
}
