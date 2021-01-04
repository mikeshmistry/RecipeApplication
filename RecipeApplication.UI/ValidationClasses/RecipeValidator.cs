using RecipeApplication.BL.DataTransformationObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace RecipeApplication.UI.ValidationClasses
{
    /// <summary>
    /// Class to validate recipes on the UI layer
    /// </summary>
   public class RecipeValidator : ValidationBase
    {

        #region Constructor

        /// <summary>
        /// Default Constructor 
        /// </summary>
        public RecipeValidator() :base()
        {

        }

        #endregion

        #region Validation Methods

        /// <summary>
        /// Method to validate a recipe Name
        /// </summary>
        /// <param name="control">The text box to validate</param>
        /// <returns>True if the text box is not empty</returns>
        public bool ValidateRecipeName(TextBox control)
        {
            var isValid = true;

            if(control.Text.Length == 0)
            {
               
                errorProvider.SetError(control, "You must enter a recipe name");
               isValid = false;
           
            }
            else
            {
                Clear(control);
            }
                
           

            return isValid;
        }


        /// <summary>
        /// Method to check to see if a recipe is selected
        /// </summary>
        /// <param name="control">The combo box for the recipe</param>
        /// <returns>True if a selection was made</returns>
        public bool ValidateRecipeSelection(ComboBox control)
        {
            var isValid = true;

            var recipe = control.SelectedItem as RecipeDTO;

           
            if (recipe ==null || recipe != null && recipe.Name == "Select A Recipe")
            {
                errorProvider.SetError(control, "You must select a recipe");
                isValid = false;
            }
            else
            {
                Clear(control);
            }

            return isValid;
        }


        #endregion 
    }
}
