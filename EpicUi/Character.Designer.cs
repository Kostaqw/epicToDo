
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
            this.ExpLabel = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.StrengthBar = new System.Windows.Forms.ProgressBar();
            this.IntelectLabel = new System.Windows.Forms.Label();
            this.IntelectBar = new System.Windows.Forms.ProgressBar();
            this.CreativeLabel = new System.Windows.Forms.Label();
            this.CreativeBar = new System.Windows.Forms.ProgressBar();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.персонажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьАватарToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 238);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(32, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(12, 265);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(52, 13);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Возраст:";
            // 
            // LvlLabel
            // 
            this.LvlLabel.AutoSize = true;
            this.LvlLabel.Location = new System.Drawing.Point(12, 290);
            this.LvlLabel.Name = "LvlLabel";
            this.LvlLabel.Size = new System.Drawing.Size(54, 13);
            this.LvlLabel.TabIndex = 3;
            this.LvlLabel.Text = "Уровень:";
            // 
            // ExpBar
            // 
            this.ExpBar.Location = new System.Drawing.Point(222, 42);
            this.ExpBar.Name = "ExpBar";
            this.ExpBar.Size = new System.Drawing.Size(228, 23);
            this.ExpBar.TabIndex = 4;
            // 
            // ExpLabel
            // 
            this.ExpLabel.AutoSize = true;
            this.ExpLabel.Location = new System.Drawing.Point(222, 24);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(37, 13);
            this.ExpLabel.TabIndex = 5;
            this.ExpLabel.Text = "Опыт:";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(222, 68);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(35, 13);
            this.StrengthLabel.TabIndex = 7;
            this.StrengthLabel.Text = "Сила:";
            // 
            // StrengthBar
            // 
            this.StrengthBar.Location = new System.Drawing.Point(222, 85);
            this.StrengthBar.Name = "StrengthBar";
            this.StrengthBar.Size = new System.Drawing.Size(228, 23);
            this.StrengthBar.TabIndex = 6;
            // 
            // IntelectLabel
            // 
            this.IntelectLabel.AutoSize = true;
            this.IntelectLabel.Location = new System.Drawing.Point(222, 111);
            this.IntelectLabel.Name = "IntelectLabel";
            this.IntelectLabel.Size = new System.Drawing.Size(58, 13);
            this.IntelectLabel.TabIndex = 9;
            this.IntelectLabel.Text = "Интилект:";
            // 
            // IntelectBar
            // 
            this.IntelectBar.Location = new System.Drawing.Point(222, 127);
            this.IntelectBar.Name = "IntelectBar";
            this.IntelectBar.Size = new System.Drawing.Size(228, 23);
            this.IntelectBar.TabIndex = 8;
            // 
            // CreativeLabel
            // 
            this.CreativeLabel.AutoSize = true;
            this.CreativeLabel.Location = new System.Drawing.Point(219, 153);
            this.CreativeLabel.Name = "CreativeLabel";
            this.CreativeLabel.Size = new System.Drawing.Size(69, 13);
            this.CreativeLabel.TabIndex = 11;
            this.CreativeLabel.Text = "Творчество:";
            // 
            // CreativeBar
            // 
            this.CreativeBar.Location = new System.Drawing.Point(222, 169);
            this.CreativeBar.Name = "CreativeBar";
            this.CreativeBar.Size = new System.Drawing.Size(228, 23);
            this.CreativeBar.TabIndex = 10;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(222, 193);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(59, 13);
            this.HealthLabel.TabIndex = 13;
            this.HealthLabel.Text = "Здоровье:";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(222, 209);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(228, 23);
            this.HealthBar.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.персонажToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // персонажToolStripMenuItem
            // 
            this.персонажToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьАватарToolStripMenuItem1});
            this.персонажToolStripMenuItem.Name = "персонажToolStripMenuItem";
            this.персонажToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.персонажToolStripMenuItem.Text = "Персонаж";
            // 
            // сменитьАватарToolStripMenuItem1
            // 
            this.сменитьАватарToolStripMenuItem1.Name = "сменитьАватарToolStripMenuItem1";
            this.сменитьАватарToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.сменитьАватарToolStripMenuItem1.Text = "Сменить аватар";
            this.сменитьАватарToolStripMenuItem1.Click += new System.EventHandler(this.сменитьАватарToolStripMenuItem1_Click);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 313);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.CreativeLabel);
            this.Controls.Add(this.CreativeBar);
            this.Controls.Add(this.IntelectLabel);
            this.Controls.Add(this.IntelectBar);
            this.Controls.Add(this.StrengthLabel);
            this.Controls.Add(this.StrengthBar);
            this.Controls.Add(this.ExpLabel);
            this.Controls.Add(this.ExpBar);
            this.Controls.Add(this.LvlLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Character";
            this.Text = "Character";
            this.Load += new System.EventHandler(this.Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label LvlLabel;
        private System.Windows.Forms.ProgressBar ExpBar;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.ProgressBar StrengthBar;
        private System.Windows.Forms.Label IntelectLabel;
        private System.Windows.Forms.ProgressBar IntelectBar;
        private System.Windows.Forms.Label CreativeLabel;
        private System.Windows.Forms.ProgressBar CreativeBar;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem персонажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьАватарToolStripMenuItem1;
    }
}