using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RecipeApplication.UI.ValidationClasses;


namespace RecipeApplication.UI.UIClasses
{
    /// <summary>
    /// Base UI Class that is generic 
    /// </summary>
    /// <typeparam name="ValidationClass">The strongly typed UI validation class</typeparam>
    /// <typeparam name="BusinessClass">The strongly typed Business class</typeparam>
    public abstract class BaseUI<ValidationClass,BusinessClass> 
       where ValidationClass: class, new () 
       where BusinessClass : class, new()
       
   {
        #region Properties
        
        /// <summary>
        /// Property to the validation class
        /// </summary>
        public ValidationClass ValidationObject { get; private set; }

        /// <summary>
        /// Property to the business object class
        /// </summary>
        public BusinessClass BusinessObject { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseUI()
        {
            ValidationObject =  new ValidationClass();
            BusinessObject   =  new BusinessClass();
            
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to show a message on the UI 
        /// </summary>
        /// <param name="message">The message to show</param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        #endregion 
    }
}
