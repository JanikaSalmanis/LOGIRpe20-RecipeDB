namespace RecipeDB
{
    partial class GookBook
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listIngridient = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Recipe";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.Location = new System.Drawing.Point(12, 62);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(144, 121);
            this.listRecipe.TabIndex = 1;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingridient";
            // 
            // listIngridient
            // 
            this.listIngridient.FormattingEnabled = true;
            this.listIngridient.Location = new System.Drawing.Point(298, 62);
            this.listIngridient.Name = "listIngridient";
            this.listIngridient.Size = new System.Drawing.Size(153, 121);
            this.listIngridient.TabIndex = 3;
            // 
            // GookBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listIngridient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.Label1);
            this.Name = "GookBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GookBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listIngridient;
    }
}

