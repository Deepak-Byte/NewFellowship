//---------------------------------------------------------------------
// <copyright file="AbstractVisitor.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Thsi is class AbstractVisitor
    /// </summary>
    public abstract class AbstractVisitor
    {
        /// <summary>
        /// The abstract chatroomcase
        /// </summary>
        private AbstractChatroom abstractChatroomcase = null;
        /// <summary>
        /// The name
        /// </summary>
        public string name = null;
        /// <summary>
        /// Sends the specified SMS.
        /// </summary>
        /// <param name="sms">The SMS.</param>
        public void send(string sms)
        {
            Console.WriteLine("{0} == >{1}",name , sms);
            abstractChatroomcase.Send(sms, this);
        }
        /// <summary>
        /// Recesives the specified SMS.
        /// </summary>
        /// <param name="sms">The SMS.</param>
        public abstract void Recesive(string sms);
        /// <summary>
        /// Enters the specified abstract chatroom.
        /// </summary>
        /// <param name="abstractChatroom">The abstract chatroom.</param>
        public void Enter(AbstractChatroom abstractChatroom)
        {
            if(abstractChatroom!=null)
            {
                Leave();
            }
            abstractChatroom.Register(this);
            abstractChatroomcase = abstractChatroom;
        }
        /// <summary>
        /// Leaves this instance.
        /// </summary>
        public void Leave()
        {
            if (abstractChatroomcase != null)
            {
                abstractChatroomcase.UnRegister(this);
                abstractChatroomcase = null;
            }
        }
    }
}
