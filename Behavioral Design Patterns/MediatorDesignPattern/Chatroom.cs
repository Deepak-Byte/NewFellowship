//---------------------------------------------------------------------
// <copyright file="Chatroom.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class Chatroom.
    /// </summary>
    /// <seealso cref="Behavioral_Design_Patterns.MediatorDesignPattern.AbstractChatroom" />
    public class Chatroom : AbstractChatroom
    {
        /// <summary>
        /// Sends the specified SMS.
        /// </summary>
        /// <param name="sms">The SMS.</param>
        /// <param name="Sender">The sender.</param>
        public override void Send(string sms, AbstractVisitor Sender)
        {
            foreach (var visitor in activeVisitors)
            {
                if (visitor != null)
                {
                    visitor.Recesive(sms);
                }

            }
        }
        /// <summary>
        /// Registers the specified visitor.
        /// </summary>
        /// <param name="Visitor">The visitor.</param>
        public override void Register(AbstractVisitor Visitor)
        {
            activeVisitors.Add(Visitor);
        }
        /// <summary>
        /// Uns the register.
        /// </summary>
        /// <param name="Visitor">The visitor.</param>
        public override void UnRegister(AbstractVisitor Visitor)
        {
            activeVisitors.Remove(Visitor);
        }

        /*********************************************************************************************************/

        //public override void send(string sms, AbstractVisitor Visitor)
        //{

        //}

        //public override void Register(AbstractVisitor Visitor)
        //{
        //    activeVisitors.Add(Visitor);
        //}

        //public override void UnRegister(AbstractVisitor Visitor)
        //{
        //    activeVisitors.Remove(Visitor);
        //}
    }
}
