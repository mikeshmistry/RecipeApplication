using RecipeApplication.UI.ValidationClasses;
using System;
using System.Collections.Generic;
using System.Text;
using RecipeApplication.BL;
using System.Windows.Forms;
using System.Threading.Tasks;
using RecipeApplication.BL.DataTransformationObjects;

namespace RecipeApplication.UI.UIClasses
{
    /// <summary>
    /// UI class to represent a recipe object that takes in a validation object and a business class object
    /// </summary>
    public class RecipeUI : BaseUI<RecipeValidator, Recipe>
    {

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public RecipeUI() : base()
        {
          
          
        }

        #endregion


        #region Methods

        /// <summary>
        /// Method to add a recipe to the database if valid 
        /// </summary>
        /// <param name="name">The name of the recipe</param>
        public async Task AddRecipeAsync(TextBox name)
        {

            var isValid =  ValidationObject.ValidateRecipeName(name);
            if (isValid)
            {
                var recipeToAdd = new RecipeDTO() { Name = name.Text };
                var added = await BusinessObject.AddRecipeAsync(recipeToAdd);


                if (added)
                {
                    ShowMessage($"Recipe {recipeToAdd.Name} Added");
                    name.Clear();
                }
                else
                    ShowMessage($"Recipe {recipeToAdd.Name} Not Added");

                

            }



        }

       
        
        /// <summary>
        /// Method to Populate a comboBox with all recipes  
        /// </summary>
        /// <param name="recipes">The comboBox to populate</param>
        /// <param name="recipesList">The list of recipes</param>
        /// <param name="buttonRecipe">Optional parameter to hide the button given</param>
        public void PopulateRecipesList(ComboBox recipes,List<RecipeDTO> recipesList, Button buttonRecipe = null)
        {
           
           var count = recipesList.Count;
            if (count != 0)
            {
                
                if(recipesList[0].Name !="Select A Recipe")
                recipesList.Insert(0, new RecipeDTO() { RecipeId = 0, Name = "Select A Recipe" });

                recipes.DataSource = recipesList;
                recipes.Enabled = true;
                recipes.ValueMember = "RecipeId";
                recipes.DisplayMember = "Name";

                

                if (buttonRecipe !=null)
                buttonRecipe.Enabled = true;

                recipes.SelectedIndex = 0;
            }
            else
            {
                recipes.DataSource = null;
                recipes.Enabled = false;

                if (buttonRecipe != null)
                    buttonRecipe.Enabled = false;


            }


        }


        /// <summary>
        /// Method to get all the recipes
        /// </summary>
        /// <returns>A List of all the Recipes</returns>
        public async Task<List<RecipeDTO>> GetAllRecipesAsync()
        {
            
           var allRecipes = await BusinessObject.GetAllRecipesAsync();

            return allRecipes;
        }

       /// <summary>
       /// Method to delete a recipe  
       /// </summary>
       /// <param name="recipe">The recipe to delete</param>
        public async Task DeleteRecipeAsync(ComboBox recipe)
        {

            var isValid = ValidationObject.ValidateRecipeSelection(recipe);

               
            if(isValid)
            {
                var recipeToDelete = recipe.SelectedItem as RecipeDTO;
                var deleted = await BusinessObject.DeleteRecipeAsync(recipeToDelete);

                if (deleted)
                    ShowMessage($"Recipe {recipeToDelete.Name} Deleted Successfully");
                else
                    ShowMessage($"Recipe {recipeToDelete.Name} Not Deleted");
            }
        }

        /// <summary>
        /// Method to get a recipe with ingredients and cooking instructions
        /// </summary>
        /// <param name="recipe">The recipe to get the ingredients and cooking instructions for</param>
        /// <returns>A recipe</returns>
        public async Task<RecipeDTO> GetRecipeWithIngredientsAndInstructions(RecipeDTO recipe)
        {
            var foundRecipe = await BusinessObject.GetRecipeWithIngredientsAndInstructionsAsync(recipe);
            return foundRecipe;
        }
       

        #endregion

    }
}
