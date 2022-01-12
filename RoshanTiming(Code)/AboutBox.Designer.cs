
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
            this.steam_l = new System.Windows.Forms.Label();
            this.dev_l = new System.Windows.Forms.Label();
            this.close_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // steam_l
            // 
            this.steam_l.AutoSize = true;
            this.steam_l.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.steam_l.Location = new System.Drawing.Point(48, 56);
            this.steam_l.Name = "steam_l";
            this.steam_l.Size = new System.Drawing.Size(182, 23);
            this.steam_l.TabIndex = 6;
            this.steam_l.Text = "Steam id - jolychik";
            // 
            // dev_l
            // 
            this.dev_l.AutoSize = true;
            this.dev_l.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.dev_l.Location = new System.Drawing.Point(48, 21);
            this.dev_l.Name = "dev_l";
            this.dev_l.Size = new System.Drawing.Size(196, 23);
            this.dev_l.TabIndex = 7;
            this.dev_l.Text = "Developer - jolychik";
            this.dev_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // close_b
            // 
            this.close_b.BackColor = System.Drawing.Color.LightGray;
            this.close_b.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close_b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.close_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.close_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_b.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.close_b.Location = new System.Drawing.Point(47, 87);
            this.close_b.Name = "close_b";
            this.close_b.Size = new System.Drawing.Size(197, 57);
            this.close_b.TabIndex = 22;
            this.close_b.Text = "Close";
            this.close_b.UseVisualStyleBackColor = false;
            this.close_b.Click += new System.EventHandler(this.Again_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.close_b);
            this.Controls.Add(this.dev_l);
            this.Controls.Add(this.steam_l);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About the Program";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label steam_l;
        private System.Windows.Forms.Label dev_l;
        private System.Windows.Forms.Button close_b;
    }
}
