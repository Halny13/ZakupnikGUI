namespace ZakupnikGUI
{
    partial class ControlRecipesList
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
            buttonPre = new Button();
            buttonNext = new Button();
            labelTitle = new Label();
            labelIngredients = new Label();
            labelIndex = new Label();
            labelCount = new Label();
            SuspendLayout();
            // 
            // buttonPre
            // 
            buttonPre.Location = new Point(144, 66);
            buttonPre.Name = "buttonPre";
            buttonPre.Size = new Size(75, 23);
            buttonPre.TabIndex = 0;
            buttonPre.Text = "Poprzedni";
            buttonPre.UseVisualStyleBackColor = true;
            buttonPre.Click += buttonPre_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(51, 66);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "Nastepny";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(51, 112);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(32, 15);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Tytuł";
            // 
            // labelIngredients
            // 
            labelIngredients.AutoSize = true;
            labelIngredients.Location = new Point(51, 159);
            labelIngredients.Name = "labelIngredients";
            labelIngredients.Size = new Size(54, 15);
            labelIngredients.TabIndex = 3;
            labelIngredients.Text = "Składniki";
            // 
            // labelIndex
            // 
            labelIndex.AutoSize = true;
            labelIndex.Location = new Point(84, 21);
            labelIndex.Name = "labelIndex";
            labelIndex.Size = new Size(38, 15);
            labelIndex.TabIndex = 4;
            labelIndex.Text = "label1";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(154, 22);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(38, 15);
            labelCount.TabIndex = 5;
            labelCount.Text = "label2";
            // 
            // ControlRecipesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelCount);
            Controls.Add(labelIndex);
            Controls.Add(labelIngredients);
            Controls.Add(labelTitle);
            Controls.Add(buttonNext);
            Controls.Add(buttonPre);
            Name = "ControlRecipesList";
            Size = new Size(600, 450);
            Load += ControlRecipesList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPre;
        private Button buttonNext;
        private Label labelTitle;
        private Label labelIngredients;
        private Label labelIndex;
        private Label labelCount;
    }
}
