using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeApplication.BL.DataTransformationObjects;
using RecipeApplication.UI.UIClasses;


namespace RecipeApplication.UI
{
    public partial class RecipeApplication : Form
    {
        #region Field
        /// <summary>
        /// Instance to the UICreator class
        /// </summary>
        private UICreator UIHelper;

      

      
        #endregion

        #region Constructor

        public RecipeApplication()
        {
           
            InitializeComponent();
           
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method to populate all Recipes List used in the application 
        /// </summary>
        private async Task PopulateAllRecipeListAsync()
        {
            var recipeList = await UIHelper.RecipeUI.GetAllRecipesAsync();
            UIHelper.RecipeUI.PopulateRecipesList(cbRecipes, recipeList,btnDeleteRecipe);
            UIHelper.RecipeUI.PopulateRecipesList(cbAddToRecipe, recipeList);
            UIHelper.RecipeUI.PopulateRecipesList(cbCookingInstructionRecipe, recipeList);
            UIHelper.RecipeUI.PopulateRecipesList(cbViewRecipe, recipeList);
           
        }

        /// <summary>
        /// Method to populate all Ingredient List used in the application
        /// </summary>
        private async Task PopulateIngredientListAsync()
        {
            var ingredientList = await UIHelper.IngredientUI.GetAllIngredientsAsync();
            UIHelper.IngredientUI.PopulateIngredientList(cbIngredients, ingredientList);
            UIHelper.IngredientUI.PopulateIngredientList(cbDeleteIngredient, ingredientList,btnDeleteIngredient);
            
        }

        
        /// <summary>
        /// Method to populate all Cooking Instructions List used in the application 
        /// </summary>
        /// <returns></returns>
        private async Task PopulateCookingInstructionListAsync()
        {
            var instructionsList = await UIHelper.InstructionUI.GetCookingInstructionsAsync();
            UIHelper.InstructionUI.PopulateInstructionList(cbDeleteInstruction, instructionsList,btnDeleteInstruction);
            UIHelper.InstructionUI.PopulateInstructionList(cbCookingInstruction, instructionsList);
        }


        /// <summary>
        /// Method to disable a button if one of the comboBox's data sources are null
        /// </summary>
        /// <param name="first">The first comboBox to check</param>
        /// <param name="second">The second comboBox to check</param>
        /// <param name="buttonToCheck">The button to enable or disable</param>
        private void CheckButtonEnabled(ComboBox first, ComboBox second, Button button)
        {
            if (first.DataSource == null || second.DataSource == null)
                button.Enabled = false;
          
            else
                button.Enabled = true;
        }

        #endregion 

        #region Events

        private async void RecipeApplicationAsync_Load(object sender, EventArgs e)
        {
            //create an instance of the UI helper class
             UIHelper = new UICreator();

            //Populate all recipeList
            await PopulateAllRecipeListAsync();

            //Populate all ingredientList 
            await PopulateIngredientListAsync();

            //Populate all cooking instructions List
            await PopulateCookingInstructionListAsync();

            //Check for adding ingredient to a recipe 
            CheckButtonEnabled(cbIngredients, cbAddToRecipe, btnAddToRecipe);
            
            //Check for adding a cooking instruction to a recipe
            CheckButtonEnabled(cbCookingInstruction, cbCookingInstructionRecipe, btnAddCookingInstructionToRecipe);

        }



        #region Add Recipe Tab Events

        private async void BtnAddRecipeAsync_Click(object sender, EventArgs e)
        {
            btnAddRecipe.Enabled = false;
            await UIHelper.RecipeUI.AddRecipeAsync(txtAddRecipe);
            btnAddRecipe.Enabled = true;
            await PopulateAllRecipeListAsync();
            //Check for adding ingredient to a recipe 
            CheckButtonEnabled(cbIngredients, cbAddToRecipe, btnAddToRecipe);
            //Check for adding a cooking instruction to a recipe
            CheckButtonEnabled(cbCookingInstruction, cbCookingInstructionRecipe, btnAddCookingInstructionToRecipe);
        }
    


        private async void BtnDeleteRecipeAsync_Click(object sender, EventArgs e)
        {

            cbRecipes.Enabled = false;
            btnDeleteRecipe.Enabled = false;
            await UIHelper.RecipeUI.DeleteRecipeAsync(cbRecipes);
            cbRecipes.Enabled = true;
            btnDeleteRecipe.Enabled = true;
            await PopulateAllRecipeListAsync();

            //Check for adding ingredient to a recipe 
            CheckButtonEnabled(cbIngredients, cbAddToRecipe, btnAddToRecipe);
            //Check for adding a cooking instruction to a recipe
            CheckButtonEnabled(cbCookingInstruction, cbCookingInstructionRecipe, btnAddCookingInstructionToRecipe);
        }


        #endregion

        #region Add Ingredient Tab Events

        private async void BtnAddIngridientAsync_Click(object sender, EventArgs e)
        {
            btnAddIngridient.Enabled = false;
            txtIngridentName.Enabled = false;
            await UIHelper.IngredientUI.AddIngredient(txtIngridentName);
            btnAddIngridient.Enabled = true;
            txtIngridentName.Enabled = true;
            await PopulateIngredientListAsync();
            txtIngridentName.Clear();
            //Check for adding ingredient to a recipe 
            CheckButtonEnabled(cbIngredients, cbAddToRecipe, btnAddToRecipe);
            
        }


        private async void btnDeleteIngredientAsync_Click(object sender, EventArgs e)
        {
            btnDeleteIngredient.Enabled = false;
            cbDeleteIngredient.Enabled = false;
            await UIHelper.IngredientUI.DeleteIngredientAsync(cbDeleteIngredient);
            btnDeleteIngredient.Enabled = true;
            cbDeleteIngredient.Enabled = true;
            await PopulateIngredientListAsync();
            //Check for adding ingredient to a recipe 
            CheckButtonEnabled(cbIngredients, cbAddToRecipe, btnAddToRecipe);
            

        }



        private async void BtnAddToRecipeAsync_Click(object sender, EventArgs e)
        {
            cbIngredients.Enabled = false;
            cbAddToRecipe.Enabled = false;
            btnAddToRecipe.Enabled = false;
            await UIHelper.IngredientUI.AddIngredientToRecipeAsync(cbAddToRecipe, cbIngredients);
            cbIngredients.Enabled = true;
            cbAddToRecipe.Enabled = true;
            btnAddToRecipe.Enabled = true;

        }

        #endregion

        #region Add Cooking Instructions Tab Events


        private async void BtnAddInstructionAsync_Click(object sender, EventArgs e)
        {
            btnAddInstruction.Enabled = false;
            txtInstructionName.Enabled = false;
            txtCookingInstruction.Enabled = false;
            await UIHelper.InstructionUI.AddCookingInstructionAsync(txtInstructionName, txtCookingInstruction);
            btnAddInstruction.Enabled = true;
            txtInstructionName.Enabled = true;
            txtCookingInstruction.Enabled = true;
            await PopulateCookingInstructionListAsync();
            

        }


        private async void btnDeleteInstructionAsync_Click(object sender, EventArgs e)
        {

            cbDeleteInstruction.Enabled = false;
            btnDeleteInstruction.Enabled = false;
            await UIHelper.InstructionUI.DeleteCookingInstructionAsync(cbDeleteInstruction);
            cbDeleteInstruction.Enabled = true;
            btnDeleteInstruction.Enabled = true;
            await PopulateCookingInstructionListAsync();
            //Check for adding ingredient to a recipe 
            CheckButtonEnabled(cbIngredients, cbAddToRecipe, btnAddToRecipe);
            //Check for adding a cooking instruction to a recipe
            CheckButtonEnabled(cbCookingInstruction, cbCookingInstructionRecipe, btnAddCookingInstructionToRecipe);

        }

        private async void BtnAddCookingInstructionToRecipeAsync_Click(object sender, EventArgs e)
        {
            cbCookingInstruction.Enabled = false;
            cbCookingInstructionRecipe.Enabled = false;
            btnAddCookingInstructionToRecipe.Enabled = false;
            await UIHelper.InstructionUI.AddCookingInstructionToRecipe(cbCookingInstructionRecipe, cbCookingInstruction);
            cbCookingInstruction.Enabled = true;
            cbCookingInstructionRecipe.Enabled = true;
            btnAddCookingInstructionToRecipe.Enabled = true;


        }






        #endregion

        #endregion
    }
}
