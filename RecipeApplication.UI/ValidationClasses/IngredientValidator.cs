using RecipeApplication.BL.DataTransformationObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace RecipeApplication.UI.ValidationClasses
{

    /// <summary>
    /// Class to Validate Ingredients on the UI layer
    /// </summary>
   public class IngredientValidator : ValidationBase
    {

        #region Constructor

        /// <summary>
        /// Default Constructor 
        /// </summary>
        public IngredientValidator() :base()
        {

        }


        #endregion

        #region Validation Methods

        /// <summary>
        /// Method to check to see if a ingredient name was entered
        /// </summary>
        /// <param name="control">The text box name for the ingredient name</param>
        /// <returns>True if an ingredient name was entered</returns>
        public bool ValidateIngredientName(TextBox control)
        {
            var isValid = true;

            if(String.IsNullOrEmpty(control.Text))
            {
                errorProvider.SetError(control, "You must enter an ingredient name");
                isValid = false;
           
            }
            else
            {
                Clear(control);
            }

            return isValid;
        }



        /// <summary>
        /// Method to check to see if an ingredient was selected
        /// </summary>
        /// <param name="control">The combo box for the ingredient</param>
        /// <returns>True if a selection was made</returns>
        public bool ValidateIngredientSelection(ComboBox control)
        {
            var isValid = true;

            var ingredient = control.SelectedItem as IngredientDTO;

            if (ingredient == null || ingredient !=null && ingredient.Name == "Select A Ingredient")
            {
                errorProvider.SetError(control, "You must select an ingredient");
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
