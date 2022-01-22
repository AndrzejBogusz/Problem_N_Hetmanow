
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.alg1 = new System.Windows.Forms.Button();
            this.alg2 = new System.Windows.Forms.Button();
            this.clrAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.solvingInfo = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rozmiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.losoweUstawianieKrólowychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLabel = new System.Windows.Forms.Label();
            this.executionTimeLabel = new System.Windows.Forms.Label();
            this.showWorking = new System.Windows.Forms.CheckBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alg1
            // 
            this.alg1.Location = new System.Drawing.Point(23, 38);
            this.alg1.Name = "alg1";
            this.alg1.Size = new System.Drawing.Size(123, 32);
            this.alg1.TabIndex = 0;
            this.alg1.Text = "Backtracking";
            this.alg1.UseVisualStyleBackColor = true;
            this.alg1.Click += new System.EventHandler(this.alg1_Click);
            // 
            // alg2
            // 
            this.alg2.Location = new System.Drawing.Point(152, 38);
            this.alg2.Name = "alg2";
            this.alg2.Size = new System.Drawing.Size(123, 32);
            this.alg2.TabIndex = 1;
            this.alg2.Text = "Branch and bound";
            this.alg2.UseVisualStyleBackColor = true;
            this.alg2.Click += new System.EventHandler(this.alg2_Click);
            // 
            // clrAll
            // 
            this.clrAll.Location = new System.Drawing.Point(281, 38);
            this.clrAll.Name = "clrAll";
            this.clrAll.Size = new System.Drawing.Size(123, 32);
            this.clrAll.TabIndex = 2;
            this.clrAll.Text = "Wyczyść planszę";
            this.clrAll.UseVisualStyleBackColor = true;
            this.clrAll.Click += new System.EventHandler(this.clrAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(649, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(462, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Szybkość wyświetlania";
            // 
            // solvingInfo
            // 
            this.solvingInfo.AutoSize = true;
            this.solvingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.solvingInfo.ForeColor = System.Drawing.Color.Crimson;
            this.solvingInfo.Location = new System.Drawing.Point(462, 59);
            this.solvingInfo.Name = "solvingInfo";
            this.solvingInfo.Size = new System.Drawing.Size(314, 13);
            this.solvingInfo.TabIndex = 5;
            this.solvingInfo.Text = "1000 = 1 sekunda. 0 = natychmiastowe rozwiązywanie";
            this.solvingInfo.Visible = false;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageLabel.Location = new System.Drawing.Point(25, 73);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(379, 18);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Nie wykonano działania";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rozmiarToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rozmiarToolStripMenuItem
            // 
            this.rozmiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.rozmiarToolStripMenuItem.Name = "rozmiarToolStripMenuItem";
            this.rozmiarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rozmiarToolStripMenuItem.Text = "Rozmiar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem1.Text = "Zmień rozmiar planszy";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losoweUstawianieKrólowychToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // losoweUstawianieKrólowychToolStripMenuItem
            // 
            this.losoweUstawianieKrólowychToolStripMenuItem.Name = "losoweUstawianieKrólowychToolStripMenuItem";
            this.losoweUstawianieKrólowychToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.losoweUstawianieKrólowychToolStripMenuItem.Text = "Losowe ustawianie królowych";
            this.losoweUstawianieKrólowychToolStripMenuItem.Click += new System.EventHandler(this.losoweUstawianieKrólowychToolStripMenuItem_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(462, 78);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(102, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Czas wykonania:";
            // 
            // executionTimeLabel
            // 
            this.executionTimeLabel.AutoSize = true;
            this.executionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.executionTimeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.executionTimeLabel.Location = new System.Drawing.Point(570, 76);
            this.executionTimeLabel.Name = "executionTimeLabel";
            this.executionTimeLabel.Size = new System.Drawing.Size(0, 15);
            this.executionTimeLabel.TabIndex = 8;
            // 
            // showWorking
            // 
            this.showWorking.AutoSize = true;
            this.showWorking.Location = new System.Drawing.Point(651, 77);
            this.showWorking.Name = "showWorking";
            this.showWorking.Size = new System.Drawing.Size(137, 17);
            this.showWorking.TabIndex = 9;
            this.showWorking.Text = "Wyświetl jak rozwiązuje";
            this.showWorking.UseVisualStyleBackColor = true;
            this.showWorking.CheckedChanged += new System.EventHandler(this.showWorking_CheckedChanged);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.Yellow;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(179, 24);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(464, 13);
            this.warningLabel.TabIndex = 10;
            this.warningLabel.Text = "Uwaga ustawienie wartości nawet na 0 może powodować bardzo długie wykonywanie alg" +
    "orytmu";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.showWorking);
            this.Controls.Add(this.executionTimeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.solvingInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clrAll);
            this.Controls.Add(this.alg2);
            this.Controls.Add(this.alg1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Problem 8 Hetmanów";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alg1;
        private System.Windows.Forms.Button alg2;
        private System.Windows.Forms.Button clrAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label solvingInfo;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rozmiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losoweUstawianieKrólowychToolStripMenuItem;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label executionTimeLabel;
        private System.Windows.Forms.CheckBox showWorking;
        private System.Windows.Forms.Label warningLabel;
    }
}

