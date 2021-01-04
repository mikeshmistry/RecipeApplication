﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApplication.BL.DataTransformationObjects
{
    
    /// <summary>
    /// Class to represent a recipe data transfer object
    /// </summary>
    public class RecipeDTO
    {

        #region Properties

        /// <summary>
        /// Property  for the recipe id
        /// </summary>
        public int RecipeId { get; set; }

        /// <summary>
        /// Property for the Name
        /// </summary>
        public String Name { get; set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecipeDTO()
        {

        }

        #endregion 

    }
}
