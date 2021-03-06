﻿using Stockapp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockapp.Data
{
    public class Player : ISoftDelete, Identificable
    {
        /// <summary>
        /// DataBase generated Id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary>
        /// Unique C.I. Alternate key
        /// </summary>
        public int CI { get; set; }

        /// <summary>
        /// Reference for the User
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// Asociated User.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Individual name
        /// </summary>
        [StringLength(30)]
        public string Name { get; set; }

        /// <summary>
        /// Individual surname
        /// </summary>
        [StringLength(30)]
        public string Surname { get; set; }

        /// <summary>
        /// User email. Used for registration
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Reference to the portfolio
        /// </summary>
        public long PortfolioId { get; set; }

        /// <summary>
        /// Player's portfolio.
        /// </summary>
        public virtual Portfolio Portfolio { get; set; }

        /// <summary>
        /// Soft delete
        /// </summary>
        public bool IsDeleted { get; set; }

        public Player()
        {
            this.IsDeleted = false;
        }

    }
}
