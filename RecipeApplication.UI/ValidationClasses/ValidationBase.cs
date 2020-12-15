using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace RecipeApplication.UI.ValidationClasses
{
    /// <summary>
    /// Base validation class used to validate UI components 
    /// </summary>
  internal abstract class ValidationBase
    {
        #region fields

        /// <summary>
        /// error provider for the validation 
        /// </summary>
        protected ErrorProvider errorProvider;

        #endregion


        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ValidationBase()
        {
           
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

        }

        #endregion

        #region Base Methods

        /// <summary>
        /// Method to clear the message on successful validation
        /// </summary>
        /// <param name="control">The control to clear the message for</param>
        protected void Clear(Control control)
        {
            errorProvider.SetError(control, String.Empty);
        }


        #endregion
    }
}
