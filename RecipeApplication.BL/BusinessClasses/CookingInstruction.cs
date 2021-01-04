using Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using RecipeApplication.BL.DataTransformationObjects;

namespace RecipeApplication.BL
{
    /// <summary>
    /// Business class to represent a cooking instruction object
    /// </summary>
    public class CookingInstruction : BusinessBase
    {
        #region Field

        /// <summary>
        /// Field for the cooking instruction repository 
        /// </summary>
        private readonly CookingInstructionRepository cookingInstructionRepository;

        #endregion 

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CookingInstruction(): base()
        {
            cookingInstructionRepository = new CookingInstructionRepository(RecipeContext);
        }

        #endregion

        #region Business Logic Layer

        /// <summary>
        /// Method to add a cooking instruction
        /// </summary>
        /// <param name="instruction">The recipe to be added</param>
        /// <returns>True if it was added</returns>
        public async Task<bool> AddCookingInstructionAsync(CookingInstructionDTO instruction)
        {
            var isAdded = true;

            try
            {
                var instructionToBeAdded = CreateInstructionEntity(instruction);
                await Task.Run(() => cookingInstructionRepository.Add(instructionToBeAdded));
            }
            catch (Exception ex)
            {
                isAdded = false;
                // TODO:Add logging 
            }

            return isAdded;
        }

        /// <summary>
        /// Method to get all cooking instructions
        /// </summary>
        /// <returns>A list of cooking instructions</returns>
        public async Task<List<CookingInstructionDTO>> GetAllCookingInstructionsAsync()
        {
            var cookingInstructionList = new List<CookingInstructionDTO>();

            try
            {
                var allInstructions = await Task.Run(() => cookingInstructionRepository.GetAll());

                //get a list of all recipes and return them
                cookingInstructionList = (from instructions in allInstructions
                                          select new CookingInstructionDTO
                                          {
                                              CookingInstructionId = instructions.CookingInstructionId,
                                              Name = instructions.Name


                                          }).ToList<CookingInstructionDTO>();



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            return cookingInstructionList;
        }

        /// <summary>
        /// Method to delete a cooking instruction from the database
        /// </summary>
        /// <param name="instructionid">The id of the cooking instruction to be deleted</param>
        /// <returns>True if the cooking instruction was deleted</returns>
        public async Task<bool> DeleteCookingInstructionAsync(CookingInstructionDTO instruction)
        {
            var deleted = true;

            try
            {
                await Task.Run(() => cookingInstructionRepository.DeleteCookingInstruction(instruction.CookingInstructionId));
            }
            catch(Exception ex)
            {
                deleted = false;
            }


            return deleted;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Method to convert a cooking instruction to an entity class so it can be added to the database
        /// </summary>
        /// <param name="instruction">The instruction to be converted</param>
        /// <returns>An instance of the Cooking Instruction entity</returns>
        private Entities.CookingInstruction CreateInstructionEntity(CookingInstructionDTO instruction)
        {

            var instructionEntity = new Entities.CookingInstruction()
            {
                Name = instruction.Name,
                Instruction = instruction.Instruction
            };

            return instructionEntity;

        }

        /// <summary>
        /// Method to add a cooking instruction to a recipe
        /// </summary>
        /// <param name="recipe">The recipe to add the cooking instruction to</param>
        /// <param name="instruction">The cooking instruction to add to the recipe</param>
        /// <returns></returns>
        public async Task<bool> AddCookingInstructionToRecipeAsync(RecipeDTO recipe,CookingInstructionDTO instruction)
        {
            var added = true;

            try 
            {
                await Task.Run(() => cookingInstructionRepository.AssignCookingInstructionsToRecipe(recipe.RecipeId, instruction.CookingInstructionId));             
            }
            catch(Exception ex)
            {
                added = false;
            }

            return added;
        }

        #endregion

    }

}

