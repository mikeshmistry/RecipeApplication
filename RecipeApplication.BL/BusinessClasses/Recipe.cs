
using RecipeApplication.BL.DataTransformationObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication.BL
{

    /// <summary>
    /// Business class to represent a recipe object
    /// </summary>
    public class Recipe : BusinessBase
    {

        #region Field

        /// <summary>
        /// Field to get a reference to the recipeRepository 
        /// </summary>
        private readonly RecipeRepository recipeRepository;

        #endregion



        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Recipe() : base()
        {
            recipeRepository = new RecipeRepository(RecipeContext);


        }

        #endregion

        #region Business Logic Layer

        /// <summary>
        /// Method to add a recipe
        /// </summary>
        /// <param name="recipe">The recipe to be added</param>
        /// <returns>True if it was added</returns>
        public async Task<bool> AddRecipeAsync(RecipeDTO recipe)
        {
            var isAdded = true;

            try
            {
                var recipeToBeAdded = CreateRecipeEntity(recipe);
                await Task.Run(() => recipeRepository.Add(recipeToBeAdded));
            }
            catch (Exception ex)
            {
                isAdded = false;
                // TODO:Add logging 
            }

            return isAdded;
        }

        /// <summary>
        /// Method to get a list of all recipes 
        /// </summary>
        /// <returns>A List of all Recipes</returns>
        public async Task<List<RecipeDTO>> GetAllRecipesAsync()
        {
            var recipeList = new List<RecipeDTO>();

            try
            {
                var allrecipes = await Task.Run(() => recipeRepository.GetAll());

                //get a list of all recipes and return them
                recipeList = (from recipes in allrecipes
                              select new RecipeDTO
                              {
                                  RecipeId = recipes.RecipeId,
                                  Name = recipes.Name
                              }).ToList<RecipeDTO>();



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            return recipeList;
        }

        /// <summary>
        /// Method to delete a recipe and all of its ingredients and cooking instructions
        /// </summary>
        /// <param name="recipe">The recipe to be deleted</param>
        /// <returns>True if the recipe was deleted</returns>
        public async Task<bool> DeleteRecipeAsync(RecipeDTO recipe)
        {
            var isDeleted = true;
            try
            {
                await Task.Run(() => recipeRepository.DeleteRecipe(recipe.RecipeId));
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }

            return isDeleted;
        }

        /// <summary>
        /// Method to get a recipe will all ingredients and cooking instructions
        /// </summary>
        /// <param name="recipe">The recipe to get the ingredients and cooking instructions for</param>
        /// <returns>A recipe object</returns>
        public async Task<RecipeDTO> GetRecipeWithIngredientsAndInstructionsAsync(RecipeDTO recipe)
        {
            RecipeDTO recipeToReturn = null;
            try
            {
                var foundRecipe = await Task.Run(() =>
                                               recipeRepository.GetRecipeWithIngredientsAndInstructions(recipe.RecipeId));

                if (foundRecipe != null)
                {
                    recipeToReturn = new RecipeDTO()
                    {
                        RecipeId = foundRecipe.RecipeId,
                        Name = foundRecipe.Name
                    };

                    //get the ingredients
                    if (foundRecipe.Ingredients != null)
                        recipeToReturn.Ingredients = await Task.Run(() => ConvertIngredients(foundRecipe.Ingredients));

                    //get the cooking instructions
                    if (foundRecipe.CookingInstructions != null)
                        recipeToReturn.Instructions = await Task.Run(() => ConvertInstructions(foundRecipe.CookingInstructions));
                }
            }
            catch (Exception ex)
            {

            }


            return recipeToReturn;
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Method to convert a collections of ingredients to a list of ingredientsDTO   
        /// </summary>
        /// <param name="ingredients">The collection to of ingredients to covert</param>
        /// <returns>A list of ingredientDTO objects</returns>
        private List<IngredientDTO> ConvertIngredients(ICollection<Entities.Ingredient> ingredients)
        {
            var ingredientList = (from ingredient in ingredients
                                  select new IngredientDTO
                                  {
                                      IngredientId = ingredient.IngredientId,
                                      Name = ingredient.Name
                                  }).ToList<IngredientDTO>();

            return ingredientList;
        }


        /// <summary>
        /// Method to convert a collections of instructions to a list of instructionsDTO   
        /// </summary>
        /// <param name="instruction">The collection to of cooking instructions to covert</param>
        /// <returns>A list of CookingInstructionsDTO objects</returns>
        private List<CookingInstructionDTO> ConvertInstructions(ICollection<Entities.CookingInstruction> instructions)
        {
            var instructionList = (from instruction in instructions
                                   select new CookingInstructionDTO
                                   {
                                       CookingInstructionId = instruction.CookingInstructionId,
                                       Name = instruction.Name,
                                       Instruction = instruction.Instruction

                                   }).ToList<CookingInstructionDTO>();

            return instructionList;
        }

        /// <summary>
        /// Method to convert a recipe to an entity class so it can be added to the database
        /// </summary>
        /// <param name="recipe">The recipe to be converted</param>
        /// <returns>An instance of the recipe entity</returns>
        private Entities.Recipe CreateRecipeEntity(RecipeDTO recipe)
        {

            var recipeEntity = new Entities.Recipe
            {
                Name = recipe.Name
            };

            return recipeEntity;

        }

        #endregion

    }
}
