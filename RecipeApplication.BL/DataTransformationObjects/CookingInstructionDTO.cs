using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeApplication.BL.DataTransformationObjects
{
    public class CookingInstructionDTO
    {
        #region Properties

        /// <summary>
        /// Property for the cooking instruction 
        /// </summary>
        public int CookingInstructionId { get; set; }

        /// <summary>
        /// Property for the name for the cooking instruction 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Property for the cooking instruction 
        /// </summary>
        public string Instruction { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CookingInstructionDTO()
        {

        }

        #endregion 


    }
}
