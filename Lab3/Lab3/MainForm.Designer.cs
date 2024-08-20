
namespace Lab3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Полка = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Расстановка = new System.Windows.Forms.Button();
            this.Автор = new System.Windows.Forms.Button();
            this.Книга = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMain.BackgroundImage")));
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMain.Location = new System.Drawing.Point(0, 194);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1107, 343);
            this.PanelMain.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Полка);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Расстановка);
            this.panel2.Controls.Add(this.Автор);
            this.panel2.Controls.Add(this.Книга);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 194);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(654, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(438, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Хомам Библиотека";
            // 
            // Полка
            // 
            this.Полка.BackColor = System.Drawing.Color.SandyBrown;
            this.Полка.FlatAppearance.BorderSize = 0;
            this.Полка.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Полка.Location = new System.Drawing.Point(636, 147);
            this.Полка.Name = "Полка";
            this.Полка.Size = new System.Drawing.Size(136, 34);
            this.Полка.TabIndex = 3;
            this.Полка.Text = "Полка";
            this.Полка.UseVisualStyleBackColor = false;
            this.Полка.Click += new System.EventHandler(this.Полка_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Расстановка
            // 
            this.Расстановка.BackColor = System.Drawing.Color.SandyBrown;
            this.Расстановка.FlatAppearance.BorderSize = 0;
            this.Расстановка.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Расстановка.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Расстановка.Location = new System.Drawing.Point(923, 147);
            this.Расстановка.Name = "Расстановка";
            this.Расстановка.Size = new System.Drawing.Size(136, 34);
            this.Расстановка.TabIndex = 4;
            this.Расстановка.Text = "Расстановка\t";
            this.Расстановка.UseVisualStyleBackColor = false;
            this.Расстановка.Click += new System.EventHandler(this.Расстановка_Click);
            // 
            // Автор
            // 
            this.Автор.BackColor = System.Drawing.Color.SandyBrown;
            this.Автор.FlatAppearance.BorderSize = 0;
            this.Автор.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Автор.Location = new System.Drawing.Point(62, 147);
            this.Автор.Name = "Автор";
            this.Автор.Size = new System.Drawing.Size(136, 34);
            this.Автор.TabIndex = 1;
            this.Автор.Text = "Автор";
            this.Автор.UseVisualStyleBackColor = false;
            this.Автор.Click += new System.EventHandler(this.Автор_Click);
            // 
            // Книга
            // 
            this.Книга.BackColor = System.Drawing.Color.SandyBrown;
            this.Книга.FlatAppearance.BorderSize = 0;
            this.Книга.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Книга.Location = new System.Drawing.Point(349, 147);
            this.Книга.Name = "Книга";
            this.Книга.Size = new System.Drawing.Size(136, 34);
            this.Книга.TabIndex = 2;
            this.Книга.Text = "Книга";
            this.Книга.UseVisualStyleBackColor = false;
            this.Книга.Click += new System.EventHandler(this.Книга_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1107, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Хомам Библиотека";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Полка;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Расстановка;
        private System.Windows.Forms.Button Автор;
        private System.Windows.Forms.Button Книга;
    }
}