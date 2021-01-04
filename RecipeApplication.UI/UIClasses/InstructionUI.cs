using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeApplication.BL;
using RecipeApplication.BL.DataTransformationObjects;
using RecipeApplication.UI;
using RecipeApplication.UI.ValidationClasses;

namespace RecipeApplication.UI.UIClasses
{
    /// <summary>
    /// UI class to represent a cooking instruction object that takes in a validation object and a business class object
    /// </summary>
    public class InstructionUI : BaseUI<InstructionValidator, CookingInstruction>
    {
        #region Field

        /// <summary>
        /// Field to the RecipeUI class
        /// </summary>
        private RecipeUI recipeUI;

        #endregion 

        #region Constructor

        /// <summary>
        /// Default Constructors
        /// </summary>
        public InstructionUI() : base()
        {
            recipeUI = new RecipeUI();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to add a cooking instruction to the database if valid 
        /// </summary>
        /// <param name="name">The name of the instruction</param>
        /// <param name="instruction">The cooking instructions</param>
        /// <returns></returns>
        public async Task AddCookingInstructionAsync(TextBox name, TextBox instruction)
        {
            var isNameValid = ValidationObject.ValidateInstructionName(name);
            var isInstructionValid = ValidationObject.ValidateInstruction(instruction);

            var added = true;

            if (isNameValid && isInstructionValid)
            {
                var cookingInstructionToAdd = new CookingInstructionDTO();
                cookingInstructionToAdd.Name = name.Text;
                cookingInstructionToAdd.Instruction = instruction.Text;

                added = await Task.Run(() => BusinessObject.AddCookingInstructionAsync(cookingInstructionToAdd));

                if (added)
                {
                    ShowMessage($"Cooking Instruction {cookingInstructionToAdd.Name} Added");
                    name.Clear();
                    instruction.Clear();
                }
                else
                    ShowMessage($"Cooking Instruction {cookingInstructionToAdd.Name} Not Added");

            }

          
        }

        /// <summary>
        /// Method to delete a cooking instruction from the database
        /// </summary>
        /// <param name="instruction"></param>
        /// <returns></returns>
        public async Task DeleteCookingInstructionAsync(ComboBox instruction)
        {
            var isValid = ValidationObject.ValidateInstructionSelection(instruction);

            if (isValid)
            {
                var instructionToDelete = instruction.SelectedItem as CookingInstructionDTO;
                var deleted = await BusinessObject.DeleteCookingInstructionAsync(instructionToDelete);

                if (deleted)
                    ShowMessage($"Cooking Instruction {instructionToDelete.Name} Deleted Successfully");
                else
                    ShowMessage($"Cooking Instruction {instructionToDelete.Name} Not Deleted");
            }
        }

        /// <summary>
        /// Method to get all cooking instructions and bind them to a comboBox 
        /// </summary>
        /// <param name="instruction">The comboBox for the instruction to bind to</param>
        /// <param name="instructions">The list of all cooking instructions</param>
        /// <param name="buttonInstruction">The button for enabling. This is a optional parameter</param>
        /// <returns></returns>
        public void PopulateInstructionList(ComboBox instruction,List<CookingInstructionDTO> instructions ,Button buttonInstruction = null)
        {
           
            
            var count = instructions.Count;
            if (count != 0)
            {
                if (instructions[0].Name != "Select A Instruction")
                    instructions.Insert(0, new CookingInstructionDTO() { CookingInstructionId=0, Name = "Select A Instruction" });

                instruction.DataSource = instructions;
                instruction.Enabled = true;
                instruction.ValueMember = "CookingInstructionId";
               instruction.DisplayMember = "Name";

                if(buttonInstruction !=null)
                    buttonInstruction.Enabled = true;
            }
            else
            {
                instruction.DataSource = null;
                instruction.Enabled = false;

                if (buttonInstruction != null)
                    buttonInstruction.Enabled = false;

            }
        }

        /// <summary>
        /// Method to get all cooking instructions
        /// </summary>
        /// <returns>A list of cooking instructions</returns>
        public async Task<List<CookingInstructionDTO>> GetCookingInstructionsAsync()
        {
            List<CookingInstructionDTO> allInstructions = new List<CookingInstructionDTO>();
            allInstructions = await BusinessObject.GetAllCookingInstructionsAsync();

            return allInstructions;
        }


        /// <summary>
        /// Method to add a cooking instruction to a recipe
        /// </summary>
        /// <param name="recipe">The recipe to add the cooking instruction to </param>
        /// <param name="instruction">The instruction to add to the recipe</param>
        public async Task AddCookingInstructionToRecipe(ComboBox recipe,ComboBox instruction)
        {
            var isRecipeValid = recipeUI.ValidationObject.ValidateRecipeSelection(recipe);
            var isInstructionValid = ValidationObject.ValidateInstructionSelection(instruction);

            if(isRecipeValid && isInstructionValid)
            {
                var recipeToAddInstruction = recipe.SelectedItem as RecipeDTO;
                var instructionToAddToRecipe = instruction.SelectedItem as CookingInstructionDTO;
                var added = await BusinessObject.AddCookingInstructionToRecipeAsync(recipeToAddInstruction, instructionToAddToRecipe);

                if (added)
                    ShowMessage($"Cooking Instruction {instructionToAddToRecipe.Name} Added To Recipe {recipeToAddInstruction.Name} ");
                else
                    ShowMessage($"Cooking Instruction {instructionToAddToRecipe.Name} Not Added To Recipe {recipeToAddInstruction.Name} ");

            }
        }

        #endregion 

    }
}
