using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApplication.BL.DataTransformationObjects
{
    /// <summary>
    /// Class to represent an ingredient data transformation object  
    /// </summary>
    public class IngredientDTO
    {

        #region Properties

        /// <summary>
        /// Property for the id of the ingredient
        /// </summary>
        public int IngredientId { get; set; }

        /// <summary>
        /// Property for name for the ingredient
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructor
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public IngredientDTO()
        {

        }

        #endregion 
    }
}
