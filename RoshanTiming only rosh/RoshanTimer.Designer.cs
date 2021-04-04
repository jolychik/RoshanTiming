
namespace WindowsFormsApp1
{
    partial class Clear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.Minute = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.TextBox();
            this.Lminute = new System.Windows.Forms.Label();
            this.Lsecond = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RClear = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.MI3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minute
            // 
            this.Minute.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minute.Location = new System.Drawing.Point(200, 121);
            this.Minute.Multiline = true;
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(180, 30);
            this.Minute.TabIndex = 0;
            this.Minute.TextChanged += new System.EventHandler(this.Minute_TextChanged);
            this.Minute.Enter += new System.EventHandler(this.Minute_Enter_1);
            this.Minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Minute_KeyPress);
            // 
            // Calc
            // 
            this.Calc.BackColor = System.Drawing.Color.LightGray;
            this.Calc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.Calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calc.Location = new System.Drawing.Point(72, 291);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(274, 66);
            this.Calc.TabIndex = 2;
            this.Calc.Text = "Посчитать и скопировать";
            this.Calc.UseVisualStyleBackColor = false;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Second
            // 
            this.Second.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Second.Location = new System.Drawing.Point(200, 178);
            this.Second.Multiline = true;
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(180, 30);
            this.Second.TabIndex = 1;
            this.Second.TextChanged += new System.EventHandler(this.Second_TextChanged);
            this.Second.Enter += new System.EventHandler(this.Second_Enter);
            this.Second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Second_KeyPress);
            this.Second.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Second_KeyUp);
            // 
            // Lminute
            // 
            this.Lminute.AutoSize = true;
            this.Lminute.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lminute.Location = new System.Drawing.Point(22, 121);
            this.Lminute.Name = "Lminute";
            this.Lminute.Size = new System.Drawing.Size(162, 23);
            this.Lminute.TabIndex = 5;
            this.Lminute.Text = "Введите минуту";
            // 
            // Lsecond
            // 
            this.Lsecond.AutoSize = true;
            this.Lsecond.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lsecond.Location = new System.Drawing.Point(22, 178);
            this.Lsecond.Name = "Lsecond";
            this.Lsecond.Size = new System.Drawing.Size(172, 23);
            this.Lsecond.TabIndex = 6;
            this.Lsecond.Text = "Введите секунду";
            this.Lsecond.Click += new System.EventHandler(this.Lsecond_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenu1});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(148, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "костыль1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ItemMenu1
            // 
            this.ItemMenu1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemMenu1.Name = "ItemMenu1";
            this.ItemMenu1.Size = new System.Drawing.Size(140, 20);
            this.ItemMenu1.Text = "Закрыть программу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(108, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Вы что-то не ввели";
            this.label6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(394, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 170);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(146, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(110, 24);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "костыль2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.toolStripMenuItem1.Text = "О программе";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Пример";
            this.label7.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.RClear);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(394, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 66);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // RClear
            // 
            this.RClear.AutoSize = true;
            this.RClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RClear.Location = new System.Drawing.Point(296, 9);
            this.RClear.Name = "RClear";
            this.RClear.Size = new System.Drawing.Size(50, 16);
            this.RClear.TabIndex = 21;
            this.RClear.Text = "Заново";
            this.RClear.Visible = false;
            this.RClear.Click += new System.EventHandler(this.c_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI3});
            this.menuStrip3.Location = new System.Drawing.Point(257, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(105, 24);
            this.menuStrip3.TabIndex = 20;
            this.menuStrip3.Text = "Тёмная тема";
            this.menuStrip3.Visible = false;
            // 
            // MI3
            // 
            this.MI3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MI3.Name = "MI3";
            this.MI3.Size = new System.Drawing.Size(97, 20);
            this.MI3.Text = "Тёмная тема";
            // 
            // Clear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lsecond);
            this.Controls.Add(this.Lminute);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoshanTiming v0.3 alpha";
            this.Load += new System.EventHandler(this.RoshanTimer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Minute;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.Label Lminute;
        private System.Windows.Forms.Label Lsecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemMenu1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem MI3;
        private System.Windows.Forms.Label RClear;
    }
}