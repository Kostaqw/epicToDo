
namespace EpicUi
{
    partial class Character
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.LvlLabel = new System.Windows.Forms.Label();
            this.ExpBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StrengthBar = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.IntelectBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.CreativeBar = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 223);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(32, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 250);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(52, 13);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Возраст:";
            // 
            // LvlLabel
            // 
            this.LvlLabel.AutoSize = true;
            this.LvlLabel.Location = new System.Drawing.Point(12, 275);
            this.LvlLabel.Name = "LvlLabel";
            this.LvlLabel.Size = new System.Drawing.Size(54, 13);
            this.LvlLabel.TabIndex = 3;
            this.LvlLabel.Text = "Уровень:";
            // 
            // ExpBar
            // 
            this.ExpBar.Location = new System.Drawing.Point(222, 27);
            this.ExpBar.Name = "ExpBar";
            this.ExpBar.Size = new System.Drawing.Size(228, 23);
            this.ExpBar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Опыт:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сила:";
            // 
            // StrengthBar
            // 
            this.StrengthBar.Location = new System.Drawing.Point(222, 70);
            this.StrengthBar.Name = "StrengthBar";
            this.StrengthBar.Size = new System.Drawing.Size(228, 23);
            this.StrengthBar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Интилект:";
            // 
            // IntelectBar
            // 
            this.IntelectBar.Location = new System.Drawing.Point(222, 112);
            this.IntelectBar.Name = "IntelectBar";
            this.IntelectBar.Size = new System.Drawing.Size(228, 23);
            this.IntelectBar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Творчество:";
            // 
            // CreativeBar
            // 
            this.CreativeBar.Location = new System.Drawing.Point(222, 154);
            this.CreativeBar.Name = "CreativeBar";
            this.CreativeBar.Size = new System.Drawing.Size(228, 23);
            this.CreativeBar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Здоровье:";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(222, 194);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(228, 23);
            this.HealthBar.TabIndex = 12;
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 302);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CreativeBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IntelectBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StrengthBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExpBar);
            this.Controls.Add(this.LvlLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Character";
            this.Text = "Character";
            this.Load += new System.EventHandler(this.Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label LvlLabel;
        private System.Windows.Forms.ProgressBar ExpBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar StrengthBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar IntelectBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar CreativeBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar HealthBar;
    }
}