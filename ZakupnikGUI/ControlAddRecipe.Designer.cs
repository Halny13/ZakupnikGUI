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
            SuspendLayout();
            // 
            // label1title
            // 
            label1title.AutoSize = true;
            label1title.Location = new Point(54, 24);
            label1title.Name = "label1title";
            label1title.Size = new Size(92, 15);
            label1title.TabIndex = 0;
            label1title.Text = "Nazwa przepisu:";
            // 
            // label2nameOfInd
            // 
            label2nameOfInd.AutoSize = true;
            label2nameOfInd.Location = new Point(54, 67);
            label2nameOfInd.Name = "label2nameOfInd";
            label2nameOfInd.Size = new Size(57, 15);
            label2nameOfInd.TabIndex = 1;
            label2nameOfInd.Text = "Składniki:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(195, 16);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // textBoxIng
            // 
            textBoxIng.Location = new Point(195, 59);
            textBoxIng.Name = "textBoxIng";
            textBoxIng.Size = new Size(100, 23);
            textBoxIng.TabIndex = 3;
            // 
            // AddIngridend
            // 
            AddIngridend.Location = new Point(367, 59);
            AddIngridend.Name = "AddIngridend";
            AddIngridend.Size = new Size(121, 23);
            AddIngridend.TabIndex = 4;
            AddIngridend.Text = "Dodaj składnik";
            AddIngridend.UseVisualStyleBackColor = true;
            AddIngridend.Click += AddIngridend_Click;
            // 
            // AddRecipe
            // 
            AddRecipe.Location = new Point(408, 286);
            AddRecipe.Name = "AddRecipe";
            AddRecipe.Size = new Size(146, 124);
            AddRecipe.TabIndex = 5;
            AddRecipe.Text = "Dodaj przepis";
            AddRecipe.UseVisualStyleBackColor = true;
            AddRecipe.Click += AddRecipe_Click;
            // 
            // labelAddIng
            // 
            labelAddIng.AutoSize = true;
            labelAddIng.Location = new Point(54, 105);
            labelAddIng.Name = "labelAddIng";
            labelAddIng.Size = new Size(97, 15);
            labelAddIng.TabIndex = 6;
            labelAddIng.Text = "Dodane składniki";
            // 
            // ControlAddRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelAddIng);
            Controls.Add(AddRecipe);
            Controls.Add(AddIngridend);
            Controls.Add(textBoxIng);
            Controls.Add(textBoxTitle);
            Controls.Add(label2nameOfInd);
            Controls.Add(label1title);
            Name = "ControlAddRecipe";
            Size = new Size(600, 450);
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
    }
}
