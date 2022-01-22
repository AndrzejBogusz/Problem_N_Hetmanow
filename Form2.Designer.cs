
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.boardSizeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createNewBoardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz rozmiar planszy";
            // 
            // boardSizeText
            // 
            this.boardSizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boardSizeText.Location = new System.Drawing.Point(143, 98);
            this.boardSizeText.Name = "boardSizeText";
            this.boardSizeText.Size = new System.Drawing.Size(91, 26);
            this.boardSizeText.TabIndex = 1;
            this.boardSizeText.TextChanged += new System.EventHandler(this.boardSizeText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rozmiar planszy od 3 do 32 (standardowa 8)";
            // 
            // createNewBoardButton
            // 
            this.createNewBoardButton.Location = new System.Drawing.Point(143, 130);
            this.createNewBoardButton.Name = "createNewBoardButton";
            this.createNewBoardButton.Size = new System.Drawing.Size(91, 23);
            this.createNewBoardButton.TabIndex = 4;
            this.createNewBoardButton.Text = "Utwórz plansze";
            this.createNewBoardButton.UseVisualStyleBackColor = true;
            this.createNewBoardButton.Click += new System.EventHandler(this.createNewBoardButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(382, 211);
            this.Controls.Add(this.createNewBoardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boardSizeText);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Nowa plansza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boardSizeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createNewBoardButton;
    }
}