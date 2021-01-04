
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

        #endregion

        #region Private Methods

        /// <summary>
        /// Method to convert a recipe to an entity class so it can be added to the database
        /// </summary>
        /// <param name="recipe">The recipe to be converted</param>
        /// <returns>An instance of the recipe entity</returns>
        private Entities.Recipe CreateRecipeEntity(RecipeDTO recipe)
        {

            var recipeEntity = new Entities.Recipe();
            recipeEntity.Name = recipe.Name;
   
            return recipeEntity;

        }

        #endregion

    }
}
