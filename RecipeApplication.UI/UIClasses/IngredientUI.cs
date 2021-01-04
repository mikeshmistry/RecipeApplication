using RecipeApplication.UI.ValidationClasses;
using System;
using System.Collections.Generic;
using System.Text;
using RecipeApplication.BL;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeApplication.BL.DataTransformationObjects;

namespace RecipeApplication.UI.UIClasses
{
    /// <summary>
    /// UI class to represent an ingredient object that takes in a validation object and a business class object
    /// </summary>
    public class IngredientUI : BaseUI<IngredientValidator, Ingredient>
    {
        #region Fields

        private RecipeUI recipeUI;

        #endregion 
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public IngredientUI() : base()
        {
            recipeUI = new RecipeUI();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to add an ingredient to the database 
        /// </summary>
        /// <param name="ingredient">The name of the ingredient</param>
        /// <returns></returns>
        public async Task AddIngredient(TextBox ingredient)
        {
            var isValid = ValidationObject.ValidateIngredientName(ingredient);
            var added = false;

            if (isValid)
            {
                var ingredientToAdd = new IngredientDTO() { Name = ingredient.Text };
                added = await BusinessObject.AddIngredientAsync(ingredientToAdd);


                if (added)
                    ShowMessage($"Ingredient {ingredientToAdd.Name} Added");

                else
                    ShowMessage($"Ingredient {ingredientToAdd.Name} Not Added");
            }

        }


        /// <summary>
        ///  Method to get all ingredients and bind them to a combo box
        /// </summary>
        /// <param name="ingredient">The combo to populate the ingredient with</param>
        /// <param name="ingredients">The list of all ingredients</param>
        /// <param name="buttonIngredient">The button for enabling. This is a optional parameter</param>
        /// <returns></returns>     
        public void PopulateIngredientList(ComboBox ingredient, List<IngredientDTO> ingredients, Button buttonIngredient = null)
        {


            var count = ingredients.Count;
            if (count != 0)
            {

                if (ingredients[0].Name != "Select A Ingredient")
                    ingredients.Insert(0, new IngredientDTO() { IngredientId = 0, Name = "Select A Ingredient" });

                ingredient.DataSource = ingredients;

                ingredient.Enabled = true;
                ingredient.ValueMember = "IngredientId";
                ingredient.DisplayMember = "Name";

                if (buttonIngredient != null)
                    buttonIngredient.Enabled = true;


            }
            else
            {
                ingredient.DataSource = null;
                ingredient.Enabled = false;

                if (buttonIngredient != null)
                    buttonIngredient.Enabled = false;


            }


        }

        /// <summary>
        /// Method to get all ingredients
        /// </summary>
        /// <returns>A list of ingredients</returns>
        public async Task<List<IngredientDTO>> GetAllIngredientsAsync()
        {
            List<IngredientDTO> allIngredients = new List<IngredientDTO>();
            allIngredients = await BusinessObject.GetAllIngredientsAsync();

            return allIngredients;
        }



        /// <summary>
        /// Method to delete an ingredient
        /// </summary>
        /// <param name="ingredient">The ingredient to delete</param>
        public async Task DeleteIngredientAsync(ComboBox ingredient)
        {
            var isValid = ValidationObject.ValidateIngredientSelection(ingredient);

            if (isValid)
            {
                var ingredientToDelete = ingredient.SelectedItem as IngredientDTO;
                var deleted = await BusinessObject.DeleteIngredientAsync(ingredientToDelete);

                if (deleted)
                    ShowMessage($"Recipe {ingredientToDelete.Name} Deleted Successfully");
                else
                    ShowMessage($"Recipe {ingredientToDelete.Name} Not Deleted");
            }
        }


        /// <summary>
        /// Method to add an ingredient to a recipe
        /// </summary>
        /// <param name="recipe">The recipe to add the ingredient to</param>
        /// <param name="ingredient">The ingredient to add the recipe to</param>
        public async Task AddIngredientToRecipeAsync(ComboBox recipe, ComboBox ingredient)
        {
            var isRecipeValid = recipeUI.ValidationObject.ValidateRecipeSelection(recipe);
            var isIngredientValid = ValidationObject.ValidateIngredientSelection(ingredient);

            //Check if the recipe and ingredient is valid
            if(isRecipeValid && isIngredientValid)
            {
                var recipeToAddIngredientTo = recipe.SelectedItem as RecipeDTO;
                var ingredientToAddToRecipe = ingredient.SelectedItem as IngredientDTO;

                var added = await BusinessObject.AddIngredientToRecipeAsync(recipeToAddIngredientTo, ingredientToAddToRecipe);

                if (added)
                    ShowMessage($"Ingredient {ingredientToAddToRecipe.Name} Added To Recipe {recipeToAddIngredientTo.Name}");
                else
                    ShowMessage($"Ingredient {ingredientToAddToRecipe.Name} Not Added To Recipe {recipeToAddIngredientTo.Name}");

            }
        }
        #endregion
    }
}
