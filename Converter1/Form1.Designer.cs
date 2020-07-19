namespace Converter1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.TextBox();
            this.temp2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.calc = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.journal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Converter1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Controls.Add(this.temp2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.temp1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(275, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.calc);
            this.groupBox2.Location = new System.Drawing.Point(275, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.journal);
            this.groupBox3.Location = new System.Drawing.Point(275, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 129);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Журнал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фаренгейты:";
            // 
            // temp1
            // 
            this.temp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp1.ForeColor = System.Drawing.Color.Navy;
            this.temp1.Location = new System.Drawing.Point(25, 51);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(100, 28);
            this.temp1.TabIndex = 1;
            this.temp1.Text = "0";
            this.temp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temp2
            // 
            this.temp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temp2.ForeColor = System.Drawing.Color.Red;
            this.temp2.Location = new System.Drawing.Point(217, 51);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(100, 28);
            this.temp2.TabIndex = 3;
            this.temp2.Text = "0";
            this.temp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Гр.Цельсия:";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(149, 40);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(53, 21);
            this.radio1.TabIndex = 4;
            this.radio1.TabStop = true;
            this.radio1.Text = ">>>";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(149, 68);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(53, 21);
            this.radio2.TabIndex = 5;
            this.radio2.TabStop = true;
            this.radio2.Text = "<<<";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(41, 29);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(123, 27);
            this.calc.TabIndex = 0;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(170, 29);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(123, 27);
            this.reset.TabIndex = 1;
            this.reset.Text = "Сбросить";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // journal
            // 
            this.journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journal.Location = new System.Drawing.Point(3, 18);
            this.journal.Multiline = true;
            this.journal.Name = "journal";
            this.journal.Size = new System.Drawing.Size(334, 108);
            this.journal.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 339);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер температур";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.TextBox temp2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox journal;
    }
}

