//---------------------------------------------------------------------
// <copyright file="MediatorMain.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace Behavioral_Design_Patterns.MediatorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// This is class MediatorMain
    /// </summary>
    public class MediatorMain
    {
        /// <summary>
        /// Mediators the mainmethod.
        /// </summary>
        public void MediatorMainmethod()
        {
            var sam = new Visitor("Sam");
            var michiokaku = new Visitor("Michiokaku");
            var ramu_kaka = new Visitor("Ramu_kaka");

            Chatroom chatroom = new Chatroom();
            sam.Enter(chatroom);
            michiokaku.Enter(chatroom);
            ramu_kaka.Enter(chatroom);

            sam.send("hello every one Kya chalraha h");
            Console.WriteLine();
            michiokaku.send("Fouge chal raha h");
            Console.WriteLine();
            ramu_kaka.send("Nahi be Time pass chal raha h");
            Console.ReadKey();
        }
    }
}
