
namespace RoshanTiming
{
    partial class AboutBox
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lminute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Again = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lminute
            // 
            this.Lminute.AutoSize = true;
            this.Lminute.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lminute.Location = new System.Drawing.Point(36, 54);
            this.Lminute.Name = "Lminute";
            this.Lminute.Size = new System.Drawing.Size(182, 23);
            this.Lminute.TabIndex = 6;
            this.Lminute.Text = "Steam id - jolychik";
            this.Lminute.Click += new System.EventHandler(this.Lminute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Developer - jolychik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Again
            // 
            this.Again.BackColor = System.Drawing.Color.LightGray;
            this.Again.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Again.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.Again.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.Again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Again.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Again.Location = new System.Drawing.Point(35, 85);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(197, 57);
            this.Again.TabIndex = 22;
            this.Again.Text = "Close";
            this.Again.UseVisualStyleBackColor = false;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 156);
            this.Controls.Add(this.Again);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lminute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lminute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Again;
    }
}
