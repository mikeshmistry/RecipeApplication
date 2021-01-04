using RecipeApplication.BL.DataTransformationObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApplication.UI.ValidationClasses
{
    /// <summary>
    /// Class to validate cooking instructions On the UI layer
    /// </summary>
   public class InstructionValidator : ValidationBase
    {

        #region Constructors
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public InstructionValidator() : base()
        {

        }

        #endregion


        #region Validation Methods

        /// <summary>
        /// Method to validate the cooking instruction name
        /// </summary>
        /// <param name="control">The text box containing the instruction name</param>
        /// <returns>True if the name for the instruction was entered</returns>
        public  bool ValidateInstructionName(TextBox control)
        {
            var isValid = true;

            if( String.IsNullOrEmpty(control.Text))
            {
                errorProvider.SetError(control, "You must enter an instruction name");
                isValid = false;
            }
            else
            {
                Clear(control);
            }

            return isValid;
        }

        /// <summary>
        /// Method to validate the cooking instruction 
        /// </summary>
        /// <param name="control">The text box containing the instructions</param>
        /// <returns>True if the name for the instruction was entered</returns>
        public bool ValidateInstruction(TextBox control)
        {
            var isValid = true;

            if (String.IsNullOrEmpty(control.Text))
            {
                errorProvider.SetError(control, "You must enter the cooking instructions");
                isValid = false;
            }
            else
            {
                Clear(control);
            }

            return isValid;
        }


        /// <summary>
        /// Method to check to see if a cooking instruction was is selected
        /// </summary>
        /// <param name="control">The combo box for the cooking instruction</param>
        /// <returns>True if a selection was made</returns>
        public bool ValidateInstructionSelection(ComboBox control)
        {
            var isValid = true;

            var instruction = control.SelectedItem as CookingInstructionDTO;

            if (instruction == null || instruction !=null && instruction.Name == "Select A Instruction")
            {
                errorProvider.SetError(control, "You must select a cooking instruction");
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
