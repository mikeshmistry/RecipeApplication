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
    /// Business class to represent an ingredient object
    /// </summary>
    public class Ingredient : BusinessBase
    {
        #region Field

        /// <summary>
        /// Field to get a reference to the ingredientRepository 
        /// </summary>
        private readonly IngredientRepository ingredientRepository;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Ingredient() : base()
        {

            ingredientRepository = new IngredientRepository(RecipeContext);
        }

        #endregion

        #region Business Logic Layer Methods

        /// <summary>
        /// Method to add an ingredient to the database 
        /// </summary>
        /// <param name="ingredient">the ingredient object to be added</param>
        /// <returns>True if added to the database</returns>
        public async Task<bool> AddIngredientAsync(IngredientDTO ingredient)
        {
            var isAdded = true;

            try
            {
                var ingredientToBeAdded = CreateIngredientEntity(ingredient);
                await Task.Run(() => ingredientRepository.Add(ingredientToBeAdded));
            }
            catch (Exception ex)
            {
                isAdded = false;
                // TODO:Add logging 
            }

            return isAdded;
        }


        /// <summary>
        /// Method to get a list of all Ingredients 
        /// </summary>
        /// <returns>A List of all Ingredients</returns>
        public async Task<List<IngredientDTO>> GetAllIngredientsAsync()
        {
            var ingredientList = new List<IngredientDTO>();

            try
            {
                var allIngredients = await Task.Run(() => ingredientRepository.GetAll());

                //get a list of all recipes and return them
                ingredientList = (from ingredient in allIngredients
                                  select new IngredientDTO
                                  {
                                      IngredientId = ingredient.IngredientId,
                                      Name = ingredient.Name
                                  }).ToList<IngredientDTO>();



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());

            }

            return ingredientList;
        }

        /// <summary>
        /// Method to delete an ingredient from the database 
        /// </summary>
        /// <param name="ingredient">The ingredient to delete</param>
        /// <returns>True if the ingredient was deleted</returns>
        public async Task<bool> DeleteIngredientAsync(IngredientDTO ingredient)
        {
            var isDeleted = true;

            try
            {
                await Task.Run(() => ingredientRepository.DeleteIngrident(ingredient.IngredientId));

            }
            catch (Exception ex)
            {
                isDeleted = false;
            }


            return isDeleted;
        }

        /// <summary>
        /// Method to add an ingredient to a recipe
        /// </summary>
        /// <param name="recipe">The recipe to add the ingredient to</param>
        /// <param name="ingredient">The ingredient to add the recipe to</param>
        /// <returns></returns>
        public async Task<bool> AddIngredientToRecipeAsync(RecipeDTO recipe, IngredientDTO ingredient)
        {
            var ingredientAdded = true;

            try
            {
                await Task.Run(() => ingredientRepository.AddIngredientToRecipe(recipe.RecipeId, ingredient.IngredientId));
            }
            catch(Exception ex)
            {
                ingredientAdded = false;
            }

            return ingredientAdded;
        }

        #endregion



        #region Private Methods

        /// <summary>
        /// Method to convert a ingredient to an entity class so it can be added to the database
        /// </summary>
        /// <param name="ingredient">The ingredient to be converted</param>
        /// <returns>An instance of the ingredient entity</returns>
        private Entities.Ingredient CreateIngredientEntity(IngredientDTO ingredient)
        {

            var ingredientEntity = new Entities.Ingredient();
            ingredientEntity.Name = ingredient.Name;

            return ingredientEntity;

        }

        #endregion

    }
}
