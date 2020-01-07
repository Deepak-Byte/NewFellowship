using System;
using System.Collections.Generic;
using System.Text;
//----------------------------------------------------------------------
// <copyright file="Cardlist.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace NEW_OPPS_PROJECT.Deckofcards
{
    public class Cardlist
    {
        /// <summary>
        /// The cardvarieties
        /// </summary>
        List<Cardvariety> cardvarieties;
        /// <summary>
        /// Gets or sets the cardvarieties.
        /// </summary>
        /// <value>
        /// The cardvarieties.
        /// </value>
        public List<Cardvariety> Cardvarieties { get => cardvarieties; set => cardvarieties = value; }
    }
}
