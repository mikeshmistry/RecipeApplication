﻿using System;
using System.Collections.Generic;
using System.Text;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace RecipeApplication.BL
{
    /// <summary>
    /// Business base class for communicating with the database layer 
    /// </summary>
    public abstract class BusinessBase
    {
        #region Properties
        
        /// <summary>
        /// Property to the context
        /// </summary>
        protected RecipeContext RecipeContext { get; set; }

        #endregion 

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BusinessBase()
        {
            var options = new DbContextOptionsBuilder<RecipeContext>()
                      .UseSqlServer("Server=localhost\\SQLEXPRESS; Database=Recipes; Trusted_Connection=True;")
                      .Options;

            RecipeContext = new RecipeContext(options);
            
         
            
        }

        #endregion

    }
}
