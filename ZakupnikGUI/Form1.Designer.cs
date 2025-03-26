namespace ZakupnikGUI
{
    partial class Form1
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
            Menu = new GroupBox();
            btnShoppingList = new Button();
            btnAddRecipe = new Button();
            btnRecipesList = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Controls.Add(btnExit);
            Menu.Controls.Add(btnRecipesList);
            Menu.Controls.Add(btnAddRecipe);
            Menu.Controls.Add(btnShoppingList);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(200, 450);
            Menu.TabIndex = 0;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            Menu.Enter += groupBox1_Enter;
            // 
            // btnShoppingList
            // 
            btnShoppingList.Dock = DockStyle.Top;
            btnShoppingList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnShoppingList.Location = new Point(3, 19);
            btnShoppingList.Name = "btnShoppingList";
            btnShoppingList.Size = new Size(194, 52);
            btnShoppingList.TabIndex = 0;
            btnShoppingList.Text = "Lista zakupów";
            btnShoppingList.UseVisualStyleBackColor = true;
            btnShoppingList.Click += btnShoppingList_Click;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Dock = DockStyle.Top;
            btnAddRecipe.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnAddRecipe.Location = new Point(3, 71);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(194, 52);
            btnAddRecipe.TabIndex = 1;
            btnAddRecipe.Text = "Dodaj przepis";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnRecipesList
            // 
            btnRecipesList.Dock = DockStyle.Top;
            btnRecipesList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnRecipesList.Location = new Point(3, 123);
            btnRecipesList.Name = "btnRecipesList";
            btnRecipesList.Size = new Size(194, 52);
            btnRecipesList.TabIndex = 2;
            btnRecipesList.Text = "Lista przepisów";
            btnRecipesList.UseVisualStyleBackColor = true;
            btnRecipesList.Click += btnRecipesList_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnExit.Location = new Point(3, 395);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 52);
            btnExit.TabIndex = 3;
            btnExit.Text = "Koniec";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(Menu);
            Name = "Form1";
            Text = "ZAKUPNIK";
            Load += Form1_Load;
            Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Menu;
        private Button btnShoppingList;
        private Button btnExit;
        private Button btnRecipesList;
        private Button btnAddRecipe;
        private Panel panel1;
    }
}
