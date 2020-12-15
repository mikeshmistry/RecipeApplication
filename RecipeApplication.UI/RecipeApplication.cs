using RecipeApplication.UI.ValidationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApplication.UI
{
    public partial class RecipeApplication : Form
    {

        #region Properties 

        /// <summary>
        /// Property to a RecipeValidator used to validate UI for recipes
        /// </summary>
        private RecipeValidator RecipeValidator { get; set; }

        /// <summary>
        /// Property to an IngredientValidator used to validate UI for ingredients tab 
        /// </summary>
        private IngredientValidator IngredientValidator { get; set; }

        /// <summary>
        /// Property to an InstructionValidator used to validate UI for cooking instructions tab
        /// </summary>
        private InstructionValidator InstructionValidator { get; set; }


        #endregion

        #region Constructor

        public RecipeApplication()
        {
            InitializeComponent();
           
        }

        #endregion

        #region Load Events

        private void RecipeApplication_Load(object sender, EventArgs e)
        {
            RecipeValidator = new RecipeValidator();
            IngredientValidator = new IngredientValidator();
            InstructionValidator = new InstructionValidator();

        }

        #endregion

        #region Add Recipe Tab Events

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {

            var isValid = RecipeValidator.ValidateRecipeName(txtAddRecipe);

            if (isValid)
            {
                MessageBox.Show("Recipe Added successfully");
            }
        }


        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            var isValid = RecipeValidator.ValidateRecipeSelection(cbRecipes);

            if (isValid)
            {
                MessageBox.Show("Deleted successfully");
            }
        }


        #endregion

        #region Add Ingredient Tab Events

        private void btnAddIngridient_Click(object sender, EventArgs e)
        {
            var isValid = IngredientValidator.ValidateIngredientName(txtIngridentName);

            if (isValid)
            {
                MessageBox.Show("Ingredient Added successfully");
            }
        }

       

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            var isRecipeSelected = RecipeValidator.ValidateRecipeSelection(cbAddToRecipe);
            var isIngredientSelected = IngredientValidator.ValidateIngredientSelection(cbIngredients);

            if(isRecipeSelected && isIngredientSelected)
            {
                MessageBox.Show("Ingredient Added to Recipe Successfully");
            }
        }

        #endregion

        #region Add Cooking Instructions Tab Events

        

        private void btnAddInstruction_Click(object sender, EventArgs e)
        {
           var isVaildName =  InstructionValidator.ValidateInstructionName(txtInstructionName);
           var isInstructionValid = InstructionValidator.ValidateInstruction(txtCookingInstruction);

            if(isVaildName && isInstructionValid)
            {
                MessageBox.Show("Added instruction successfully");
            }


        }

        private void btnAddCookingInstructionToRecipe_Click(object sender, EventArgs e)
        {
            var isInstructionSelected = InstructionValidator.ValidateInstructionSelection(cbCookingInstruction);
            var isRecipeSelected = RecipeValidator.ValidateRecipeSelection(cbCookingInstructionRecipe);

            if(isInstructionSelected && isRecipeSelected)
            {
                MessageBox.Show("Added cooking instruction to recipe");
            }
        }

        #endregion

        
    }
}
