using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RecipeApplication.UI.UIClasses
{
    /// <summary>
    /// Class to create references to UI objects when need
    /// </summary>
    internal class UICreator
    {

        #region Fields

        /// <summary>
        /// Field for the RecipeUI class
        /// </summary>
        private RecipeUI recipeUI;

        /// <summary>
        /// Field for the IngredientUI class
        /// </summary>
        private IngredientUI ingredientUI;

        /// <summary>
        /// Field for the InstructionUI class
        /// </summary>
        private InstructionUI instructionUI;

        #endregion

        #region Properties

        /// <summary>
        /// Property to a RecipeUI class which handles validation and interaction with business object 
        /// </summary>
        public RecipeUI RecipeUI
        {
            get
            {
                return recipeUI;
            }
        }

        /// <summary>
        /// Property to an IngredientUI class which handles validation and interaction with business object 
        /// </summary>
        public IngredientUI IngredientUI { 
            get 
            {
                return ingredientUI;
            } 
        }

        /// <summary>
        /// Property to a InstructionUI class which handles validation and interaction with business object 
        /// </summary>
        public InstructionUI InstructionUI 
        { 
            get
            {
                return instructionUI;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public UICreator()
        {
            recipeUI = new RecipeUI();
            ingredientUI = new IngredientUI();
            instructionUI = new InstructionUI();
        }

        #endregion

     
    }
}
