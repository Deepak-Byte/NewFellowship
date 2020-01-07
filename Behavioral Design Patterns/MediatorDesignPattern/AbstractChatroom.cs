//---------------------------------------------------------------------
// <copyright file="AbstractChatroom.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is abstract class AbstractChatroom
    /// </summary>
    public abstract class AbstractChatroom 
    {
        /// <summary>
        /// This is list of AbstractVisitor.
        /// </summary>
        public List<AbstractVisitor> activeVisitors = new List<AbstractVisitor>();
        /// <summary>
        /// Method declaration.
        /// </summary>
        /// <param name="sms"></param>
        /// <param name="AbsVisitor"></param>
        public abstract void Send(string sms , AbstractVisitor AbsVisitor );
        /// <summary>
        /// Method declaration.
        /// </summary>
        /// <param name="Visitor"></param>
        public abstract void UnRegister(AbstractVisitor Visitor);
        /// <summary>
        /// Method declaration.
        /// </summary>
        /// <param name="Visitor"></param>
        public abstract void Register(AbstractVisitor Visitor);
    }
}
