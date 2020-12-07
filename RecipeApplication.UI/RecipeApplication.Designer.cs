
namespace RecipeApplication.UI
{
    partial class RecipeApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAddRecipe = new System.Windows.Forms.TabPage();
            this.tableDeleteRecipeButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.tableDeleteRecipeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeleteRecipe = new System.Windows.Forms.Label();
            this.cbRecipes = new System.Windows.Forms.ComboBox();
            this.tableAddRecipeButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.tableAddRecipeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtAddRecipe = new System.Windows.Forms.TextBox();
            this.tabAddRecipeControl = new System.Windows.Forms.TabControl();
            this.tabAddIngridient = new System.Windows.Forms.TabPage();
            this.tableAddIngridentButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddIngridient = new System.Windows.Forms.Button();
            this.tableIngredientLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblIngridentName = new System.Windows.Forms.Label();
            this.txtIngridentName = new System.Windows.Forms.TextBox();
            this.tabAddCookingInstruction = new System.Windows.Forms.TabPage();
            this.tableCookingInstructionsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblInstructionName = new System.Windows.Forms.Label();
            this.txtInstructionName = new System.Windows.Forms.TextBox();
            this.lblCookingInstructions = new System.Windows.Forms.Label();
            this.txtCookingInstruction = new System.Windows.Forms.TextBox();
            this.tableButtonAddInstructionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddInstruction = new System.Windows.Forms.Button();
            this.tabViewRecipe = new System.Windows.Forms.TabPage();
            this.tableViewRecipeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblViewRecipe = new System.Windows.Forms.Label();
            this.cbViewRecipe = new System.Windows.Forms.ComboBox();
            this.tabAddRecipe.SuspendLayout();
            this.tableDeleteRecipeButtonLayout.SuspendLayout();
            this.tableDeleteRecipeLayout.SuspendLayout();
            this.tableAddRecipeButtonLayout.SuspendLayout();
            this.tableAddRecipeLayout.SuspendLayout();
            this.tabAddRecipeControl.SuspendLayout();
            this.tabAddIngridient.SuspendLayout();
            this.tableAddIngridentButtonLayout.SuspendLayout();
            this.tableIngredientLayout.SuspendLayout();
            this.tabAddCookingInstruction.SuspendLayout();
            this.tableCookingInstructionsLayout.SuspendLayout();
            this.tableButtonAddInstructionLayout.SuspendLayout();
            this.tabViewRecipe.SuspendLayout();
            this.tableViewRecipeLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAddRecipe
            // 
            this.tabAddRecipe.Controls.Add(this.tableDeleteRecipeButtonLayout);
            this.tabAddRecipe.Controls.Add(this.tableDeleteRecipeLayout);
            this.tabAddRecipe.Controls.Add(this.tableAddRecipeButtonLayout);
            this.tabAddRecipe.Controls.Add(this.tableAddRecipeLayout);
            this.tabAddRecipe.Location = new System.Drawing.Point(4, 24);
            this.tabAddRecipe.Name = "tabAddRecipe";
            this.tabAddRecipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddRecipe.Size = new System.Drawing.Size(727, 359);
            this.tabAddRecipe.TabIndex = 1;
            this.tabAddRecipe.Text = "Add Recipe";
            this.tabAddRecipe.UseVisualStyleBackColor = true;
            // 
            // tableDeleteRecipeButtonLayout
            // 
            this.tableDeleteRecipeButtonLayout.ColumnCount = 1;
            this.tableDeleteRecipeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDeleteRecipeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDeleteRecipeButtonLayout.Controls.Add(this.btnDeleteRecipe, 0, 0);
            this.tableDeleteRecipeButtonLayout.Location = new System.Drawing.Point(285, 121);
            this.tableDeleteRecipeButtonLayout.Name = "tableDeleteRecipeButtonLayout";
            this.tableDeleteRecipeButtonLayout.RowCount = 1;
            this.tableDeleteRecipeButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDeleteRecipeButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDeleteRecipeButtonLayout.Size = new System.Drawing.Size(97, 32);
            this.tableDeleteRecipeButtonLayout.TabIndex = 6;
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRecipe.Location = new System.Drawing.Point(3, 4);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteRecipe.TabIndex = 2;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // tableDeleteRecipeLayout
            // 
            this.tableDeleteRecipeLayout.ColumnCount = 2;
            this.tableDeleteRecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.43979F));
            this.tableDeleteRecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.56021F));
            this.tableDeleteRecipeLayout.Controls.Add(this.lblDeleteRecipe, 0, 0);
            this.tableDeleteRecipeLayout.Controls.Add(this.cbRecipes, 1, 0);
            this.tableDeleteRecipeLayout.Location = new System.Drawing.Point(3, 82);
            this.tableDeleteRecipeLayout.Name = "tableDeleteRecipeLayout";
            this.tableDeleteRecipeLayout.RowCount = 1;
            this.tableDeleteRecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDeleteRecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableDeleteRecipeLayout.Size = new System.Drawing.Size(379, 33);
            this.tableDeleteRecipeLayout.TabIndex = 5;
            // 
            // lblDeleteRecipe
            // 
            this.lblDeleteRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeleteRecipe.AutoSize = true;
            this.lblDeleteRecipe.Location = new System.Drawing.Point(3, 9);
            this.lblDeleteRecipe.Name = "lblDeleteRecipe";
            this.lblDeleteRecipe.Size = new System.Drawing.Size(94, 15);
            this.lblDeleteRecipe.TabIndex = 0;
            this.lblDeleteRecipe.Text = "Recipes :";
            // 
            // cbRecipes
            // 
            this.cbRecipes.FormattingEnabled = true;
            this.cbRecipes.Location = new System.Drawing.Point(103, 3);
            this.cbRecipes.Name = "cbRecipes";
            this.cbRecipes.Size = new System.Drawing.Size(273, 23);
            this.cbRecipes.TabIndex = 1;
            this.cbRecipes.Text = "Select a Recipe";
            // 
            // tableAddRecipeButtonLayout
            // 
            this.tableAddRecipeButtonLayout.ColumnCount = 1;
            this.tableAddRecipeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddRecipeButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddRecipeButtonLayout.Controls.Add(this.btnAddRecipe, 0, 0);
            this.tableAddRecipeButtonLayout.Location = new System.Drawing.Point(285, 44);
            this.tableAddRecipeButtonLayout.Name = "tableAddRecipeButtonLayout";
            this.tableAddRecipeButtonLayout.RowCount = 1;
            this.tableAddRecipeButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddRecipeButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddRecipeButtonLayout.Size = new System.Drawing.Size(97, 32);
            this.tableAddRecipeButtonLayout.TabIndex = 4;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRecipe.Location = new System.Drawing.Point(3, 4);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(91, 23);
            this.btnAddRecipe.TabIndex = 2;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // tableAddRecipeLayout
            // 
            this.tableAddRecipeLayout.ColumnCount = 2;
            this.tableAddRecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.43979F));
            this.tableAddRecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.56021F));
            this.tableAddRecipeLayout.Controls.Add(this.lblRecipeName, 0, 0);
            this.tableAddRecipeLayout.Controls.Add(this.txtAddRecipe, 1, 0);
            this.tableAddRecipeLayout.Location = new System.Drawing.Point(0, 3);
            this.tableAddRecipeLayout.Name = "tableAddRecipeLayout";
            this.tableAddRecipeLayout.RowCount = 1;
            this.tableAddRecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddRecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddRecipeLayout.Size = new System.Drawing.Size(382, 35);
            this.tableAddRecipeLayout.TabIndex = 3;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(3, 10);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(95, 15);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name :";
            // 
            // txtAddRecipe
            // 
            this.txtAddRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddRecipe.Location = new System.Drawing.Point(104, 6);
            this.txtAddRecipe.Name = "txtAddRecipe";
            this.txtAddRecipe.Size = new System.Drawing.Size(275, 23);
            this.txtAddRecipe.TabIndex = 1;
            this.txtAddRecipe.Text = "Enter Recipe Name";
            // 
            // tabAddRecipeControl
            // 
            this.tabAddRecipeControl.Controls.Add(this.tabAddRecipe);
            this.tabAddRecipeControl.Controls.Add(this.tabAddIngridient);
            this.tabAddRecipeControl.Controls.Add(this.tabAddCookingInstruction);
            this.tabAddRecipeControl.Controls.Add(this.tabViewRecipe);
            this.tabAddRecipeControl.Location = new System.Drawing.Point(12, 12);
            this.tabAddRecipeControl.Name = "tabAddRecipeControl";
            this.tabAddRecipeControl.SelectedIndex = 0;
            this.tabAddRecipeControl.ShowToolTips = true;
            this.tabAddRecipeControl.Size = new System.Drawing.Size(735, 387);
            this.tabAddRecipeControl.TabIndex = 0;
            this.tabAddRecipeControl.SelectedIndexChanged += new System.EventHandler(this.tabAddRecipeControl_SelectedIndexChanged);
            // 
            // tabAddIngridient
            // 
            this.tabAddIngridient.Controls.Add(this.tableAddIngridentButtonLayout);
            this.tabAddIngridient.Controls.Add(this.tableIngredientLayout);
            this.tabAddIngridient.Location = new System.Drawing.Point(4, 24);
            this.tabAddIngridient.Name = "tabAddIngridient";
            this.tabAddIngridient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddIngridient.Size = new System.Drawing.Size(727, 359);
            this.tabAddIngridient.TabIndex = 2;
            this.tabAddIngridient.Text = "Add Ingredient";
            this.tabAddIngridient.UseVisualStyleBackColor = true;
            // 
            // tableAddIngridentButtonLayout
            // 
            this.tableAddIngridentButtonLayout.ColumnCount = 1;
            this.tableAddIngridentButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddIngridentButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddIngridentButtonLayout.Controls.Add(this.btnAddIngridient, 0, 0);
            this.tableAddIngridentButtonLayout.Location = new System.Drawing.Point(280, 44);
            this.tableAddIngridentButtonLayout.Name = "tableAddIngridentButtonLayout";
            this.tableAddIngridentButtonLayout.RowCount = 1;
            this.tableAddIngridentButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddIngridentButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableAddIngridentButtonLayout.Size = new System.Drawing.Size(105, 32);
            this.tableAddIngridentButtonLayout.TabIndex = 5;
            // 
            // btnAddIngridient
            // 
            this.btnAddIngridient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIngridient.Location = new System.Drawing.Point(3, 4);
            this.btnAddIngridient.Name = "btnAddIngridient";
            this.btnAddIngridient.Size = new System.Drawing.Size(99, 23);
            this.btnAddIngridient.TabIndex = 2;
            this.btnAddIngridient.Text = "Add Ingredient";
            this.btnAddIngridient.UseVisualStyleBackColor = true;
            // 
            // tableIngredientLayout
            // 
            this.tableIngredientLayout.ColumnCount = 2;
            this.tableIngredientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.41361F));
            this.tableIngredientLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.58639F));
            this.tableIngredientLayout.Controls.Add(this.lblIngridentName, 0, 0);
            this.tableIngredientLayout.Controls.Add(this.txtIngridentName, 1, 0);
            this.tableIngredientLayout.Location = new System.Drawing.Point(3, 3);
            this.tableIngredientLayout.Name = "tableIngredientLayout";
            this.tableIngredientLayout.RowCount = 1;
            this.tableIngredientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableIngredientLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableIngredientLayout.Size = new System.Drawing.Size(382, 35);
            this.tableIngredientLayout.TabIndex = 4;
            // 
            // lblIngridentName
            // 
            this.lblIngridentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngridentName.AutoSize = true;
            this.lblIngridentName.Location = new System.Drawing.Point(3, 10);
            this.lblIngridentName.Name = "lblIngridentName";
            this.lblIngridentName.Size = new System.Drawing.Size(113, 15);
            this.lblIngridentName.TabIndex = 0;
            this.lblIngridentName.Text = "Ingredient Name :";
            // 
            // txtIngridentName
            // 
            this.txtIngridentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngridentName.Location = new System.Drawing.Point(122, 6);
            this.txtIngridentName.Name = "txtIngridentName";
            this.txtIngridentName.Size = new System.Drawing.Size(257, 23);
            this.txtIngridentName.TabIndex = 1;
            this.txtIngridentName.Text = "Enter Ingredient Name";
            // 
            // tabAddCookingInstruction
            // 
            this.tabAddCookingInstruction.Controls.Add(this.tableButtonAddInstructionLayout);
            this.tabAddCookingInstruction.Controls.Add(this.tableCookingInstructionsLayout);
            this.tabAddCookingInstruction.Location = new System.Drawing.Point(4, 24);
            this.tabAddCookingInstruction.Name = "tabAddCookingInstruction";
            this.tabAddCookingInstruction.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCookingInstruction.Size = new System.Drawing.Size(727, 359);
            this.tabAddCookingInstruction.TabIndex = 3;
            this.tabAddCookingInstruction.Text = "Add Cooking Instructions";
            this.tabAddCookingInstruction.UseVisualStyleBackColor = true;
            // 
            // tableCookingInstructionsLayout
            // 
            this.tableCookingInstructionsLayout.ColumnCount = 2;
            this.tableCookingInstructionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.69072F));
            this.tableCookingInstructionsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.30928F));
            this.tableCookingInstructionsLayout.Controls.Add(this.lblInstructionName, 0, 0);
            this.tableCookingInstructionsLayout.Controls.Add(this.txtInstructionName, 1, 0);
            this.tableCookingInstructionsLayout.Controls.Add(this.lblCookingInstructions, 0, 2);
            this.tableCookingInstructionsLayout.Controls.Add(this.txtCookingInstruction, 1, 2);
            this.tableCookingInstructionsLayout.Location = new System.Drawing.Point(0, 3);
            this.tableCookingInstructionsLayout.Name = "tableCookingInstructionsLayout";
            this.tableCookingInstructionsLayout.RowCount = 3;
            this.tableCookingInstructionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.29269F));
            this.tableCookingInstructionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.70732F));
            this.tableCookingInstructionsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableCookingInstructionsLayout.Size = new System.Drawing.Size(388, 130);
            this.tableCookingInstructionsLayout.TabIndex = 4;
            // 
            // lblInstructionName
            // 
            this.lblInstructionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstructionName.AutoSize = true;
            this.lblInstructionName.Location = new System.Drawing.Point(3, 6);
            this.lblInstructionName.Name = "lblInstructionName";
            this.lblInstructionName.Size = new System.Drawing.Size(147, 15);
            this.lblInstructionName.TabIndex = 0;
            this.lblInstructionName.Text = "Instruction Name :";
            // 
            // txtInstructionName
            // 
            this.txtInstructionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstructionName.Location = new System.Drawing.Point(156, 3);
            this.txtInstructionName.Name = "txtInstructionName";
            this.txtInstructionName.Size = new System.Drawing.Size(229, 23);
            this.txtInstructionName.TabIndex = 1;
            this.txtInstructionName.Text = "Enter Instruction Name";
            // 
            // lblCookingInstructions
            // 
            this.lblCookingInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCookingInstructions.AutoSize = true;
            this.lblCookingInstructions.Location = new System.Drawing.Point(3, 78);
            this.lblCookingInstructions.Name = "lblCookingInstructions";
            this.lblCookingInstructions.Size = new System.Drawing.Size(147, 15);
            this.lblCookingInstructions.TabIndex = 2;
            this.lblCookingInstructions.Text = "Cooking Instructions :";
            // 
            // txtCookingInstruction
            // 
            this.txtCookingInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCookingInstruction.Location = new System.Drawing.Point(156, 44);
            this.txtCookingInstruction.Multiline = true;
            this.txtCookingInstruction.Name = "txtCookingInstruction";
            this.txtCookingInstruction.Size = new System.Drawing.Size(229, 83);
            this.txtCookingInstruction.TabIndex = 3;
            this.txtCookingInstruction.Text = "Enter Cooking Instructions";
            // 
            // tableButtonAddInstructionLayout
            // 
            this.tableButtonAddInstructionLayout.ColumnCount = 1;
            this.tableButtonAddInstructionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonAddInstructionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonAddInstructionLayout.Controls.Add(this.btnAddInstruction, 0, 0);
            this.tableButtonAddInstructionLayout.Location = new System.Drawing.Point(283, 139);
            this.tableButtonAddInstructionLayout.Name = "tableButtonAddInstructionLayout";
            this.tableButtonAddInstructionLayout.RowCount = 1;
            this.tableButtonAddInstructionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonAddInstructionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableButtonAddInstructionLayout.Size = new System.Drawing.Size(105, 32);
            this.tableButtonAddInstructionLayout.TabIndex = 6;
            // 
            // btnAddInstruction
            // 
            this.btnAddInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInstruction.Location = new System.Drawing.Point(3, 4);
            this.btnAddInstruction.Name = "btnAddInstruction";
            this.btnAddInstruction.Size = new System.Drawing.Size(99, 23);
            this.btnAddInstruction.TabIndex = 2;
            this.btnAddInstruction.Text = "Add Instruction";
            this.btnAddInstruction.UseVisualStyleBackColor = true;
            // 
            // tabViewRecipe
            // 
            this.tabViewRecipe.Controls.Add(this.tableViewRecipeLayout);
            this.tabViewRecipe.Location = new System.Drawing.Point(4, 24);
            this.tabViewRecipe.Name = "tabViewRecipe";
            this.tabViewRecipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewRecipe.Size = new System.Drawing.Size(727, 359);
            this.tabViewRecipe.TabIndex = 4;
            this.tabViewRecipe.Text = "View Recipe";
            this.tabViewRecipe.UseVisualStyleBackColor = true;
            // 
            // tableViewRecipeLayout
            // 
            this.tableViewRecipeLayout.ColumnCount = 2;
            this.tableViewRecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.43979F));
            this.tableViewRecipeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.56021F));
            this.tableViewRecipeLayout.Controls.Add(this.lblViewRecipe, 0, 0);
            this.tableViewRecipeLayout.Controls.Add(this.cbViewRecipe, 1, 0);
            this.tableViewRecipeLayout.Location = new System.Drawing.Point(0, 0);
            this.tableViewRecipeLayout.Name = "tableViewRecipeLayout";
            this.tableViewRecipeLayout.RowCount = 1;
            this.tableViewRecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableViewRecipeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableViewRecipeLayout.Size = new System.Drawing.Size(379, 33);
            this.tableViewRecipeLayout.TabIndex = 6;
            // 
            // lblViewRecipe
            // 
            this.lblViewRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewRecipe.AutoSize = true;
            this.lblViewRecipe.Location = new System.Drawing.Point(3, 9);
            this.lblViewRecipe.Name = "lblViewRecipe";
            this.lblViewRecipe.Size = new System.Drawing.Size(94, 15);
            this.lblViewRecipe.TabIndex = 0;
            this.lblViewRecipe.Text = "Recipes :";
            // 
            // cbViewRecipe
            // 
            this.cbViewRecipe.FormattingEnabled = true;
            this.cbViewRecipe.Location = new System.Drawing.Point(103, 3);
            this.cbViewRecipe.Name = "cbViewRecipe";
            this.cbViewRecipe.Size = new System.Drawing.Size(273, 23);
            this.cbViewRecipe.TabIndex = 1;
            this.cbViewRecipe.Text = "Select a Recipe";
            // 
            // RecipeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tabAddRecipeControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipeApplication";
            this.Text = "Recipe Application ";
            this.tabAddRecipe.ResumeLayout(false);
            this.tableDeleteRecipeButtonLayout.ResumeLayout(false);
            this.tableDeleteRecipeLayout.ResumeLayout(false);
            this.tableDeleteRecipeLayout.PerformLayout();
            this.tableAddRecipeButtonLayout.ResumeLayout(false);
            this.tableAddRecipeLayout.ResumeLayout(false);
            this.tableAddRecipeLayout.PerformLayout();
            this.tabAddRecipeControl.ResumeLayout(false);
            this.tabAddIngridient.ResumeLayout(false);
            this.tableAddIngridentButtonLayout.ResumeLayout(false);
            this.tableIngredientLayout.ResumeLayout(false);
            this.tableIngredientLayout.PerformLayout();
            this.tabAddCookingInstruction.ResumeLayout(false);
            this.tableCookingInstructionsLayout.ResumeLayout(false);
            this.tableCookingInstructionsLayout.PerformLayout();
            this.tableButtonAddInstructionLayout.ResumeLayout(false);
            this.tabViewRecipe.ResumeLayout(false);
            this.tableViewRecipeLayout.ResumeLayout(false);
            this.tableViewRecipeLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAddRecipe;
        private System.Windows.Forms.TableLayoutPanel tableAddRecipeButtonLayout;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TableLayoutPanel tableAddRecipeLayout;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtAddRecipe;
        private System.Windows.Forms.TabControl tabAddRecipeControl;
        private System.Windows.Forms.TableLayoutPanel tableDeleteRecipeButtonLayout;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.TableLayoutPanel tableDeleteRecipeLayout;
        private System.Windows.Forms.Label lblDeleteRecipe;
        private System.Windows.Forms.ComboBox cbRecipes;
        private System.Windows.Forms.TabPage tabAddIngridient;
        private System.Windows.Forms.TableLayoutPanel tableAddIngridentButtonLayout;
        private System.Windows.Forms.Button btnAddIngridient;
        private System.Windows.Forms.TableLayoutPanel tableIngredientLayout;
        private System.Windows.Forms.Label lblIngridentName;
        private System.Windows.Forms.TextBox txtIngridentName;
        private System.Windows.Forms.TabPage tabAddCookingInstruction;
        private System.Windows.Forms.TableLayoutPanel tableCookingInstructionsLayout;
        private System.Windows.Forms.Label lblCookingInstructions;
        private System.Windows.Forms.Label lblInstructionName;
        private System.Windows.Forms.TextBox txtInstructionName;
        private System.Windows.Forms.TextBox txtCookingInstruction;
        private System.Windows.Forms.TableLayoutPanel tableButtonAddInstructionLayout;
        private System.Windows.Forms.Button btnAddInstruction;
        private System.Windows.Forms.TabPage tabViewRecipe;
        private System.Windows.Forms.TableLayoutPanel tableViewRecipeLayout;
        private System.Windows.Forms.Label lblViewRecipe;
        private System.Windows.Forms.ComboBox cbViewRecipe;
    }
}

