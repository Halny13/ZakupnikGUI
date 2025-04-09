namespace ZakupnikGUI
{
    partial class ControlAddRecipe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1title = new Label();
            label2nameOfInd = new Label();
            textBoxTitle = new TextBox();
            textBoxIng = new TextBox();
            AddIngridend = new Button();
            AddRecipe = new Button();
            labelAddIng = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1title
            // 
            label1title.AutoSize = true;
            label1title.Location = new Point(77, 40);
            label1title.Margin = new Padding(4, 0, 4, 0);
            label1title.Name = "label1title";
            label1title.Size = new Size(140, 25);
            label1title.TabIndex = 0;
            label1title.Text = "Nazwa przepisu:";
            // 
            // label2nameOfInd
            // 
            label2nameOfInd.AutoSize = true;
            label2nameOfInd.Location = new Point(77, 112);
            label2nameOfInd.Margin = new Padding(4, 0, 4, 0);
            label2nameOfInd.Name = "label2nameOfInd";
            label2nameOfInd.Size = new Size(87, 25);
            label2nameOfInd.TabIndex = 1;
            label2nameOfInd.Text = "Składniki:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(279, 27);
            textBoxTitle.Margin = new Padding(4, 5, 4, 5);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(141, 31);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxIng
            // 
            textBoxIng.Location = new Point(279, 98);
            textBoxIng.Margin = new Padding(4, 5, 4, 5);
            textBoxIng.Name = "textBoxIng";
            textBoxIng.Size = new Size(141, 31);
            textBoxIng.TabIndex = 3;
            // 
            // AddIngridend
            // 
            AddIngridend.Location = new Point(524, 98);
            AddIngridend.Margin = new Padding(4, 5, 4, 5);
            AddIngridend.Name = "AddIngridend";
            AddIngridend.Size = new Size(173, 38);
            AddIngridend.TabIndex = 4;
            AddIngridend.Text = "Dodaj składnik";
            AddIngridend.UseVisualStyleBackColor = true;
            AddIngridend.Click += AddIngridend_Click;
            // 
            // AddRecipe
            // 
            AddRecipe.Location = new Point(601, 497);
            AddRecipe.Margin = new Padding(4, 5, 4, 5);
            AddRecipe.Name = "AddRecipe";
            AddRecipe.Size = new Size(209, 207);
            AddRecipe.TabIndex = 5;
            AddRecipe.Text = "Dodaj przepis";
            AddRecipe.UseVisualStyleBackColor = true;
            AddRecipe.Click += AddRecipe_Click;
            // 
            // labelAddIng
            // 
            labelAddIng.AutoSize = true;
            labelAddIng.Location = new Point(77, 175);
            labelAddIng.Margin = new Padding(4, 0, 4, 0);
            labelAddIng.Name = "labelAddIng";
            labelAddIng.Size = new Size(149, 25);
            labelAddIng.TabIndex = 6;
            labelAddIng.Text = "Dodane składniki";
            // 
            // button1
            // 
            button1.Location = new Point(61, 583);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "temp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ControlAddRecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(labelAddIng);
            Controls.Add(AddRecipe);
            Controls.Add(AddIngridend);
            Controls.Add(textBoxIng);
            Controls.Add(textBoxTitle);
            Controls.Add(label2nameOfInd);
            Controls.Add(label1title);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ControlAddRecipe";
            Size = new Size(857, 750);
            Load += ControlAddRecipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1title;
        private Label label2nameOfInd;
        private TextBox textBoxTitle;
        private TextBox textBoxIng;
        private Button AddIngridend;
        private Button AddRecipe;
        private Label labelAddIng;
        private Button button1;
    }
}
