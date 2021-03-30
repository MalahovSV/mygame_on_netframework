
namespace LandsOfTheVoid
{
    partial class Inventory
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.ArmorPanel = new System.Windows.Forms.Panel();
            this.WeaponPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Experience = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.Mind = new System.Windows.Forms.Label();
            this.Intellect = new System.Windows.Forms.Label();
            this.Agality = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.Stamina = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArmorPanel
            // 
            this.ArmorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ArmorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArmorPanel.Location = new System.Drawing.Point(155, 14);
            this.ArmorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ArmorPanel.Name = "ArmorPanel";
            this.ArmorPanel.Size = new System.Drawing.Size(208, 288);
            this.ArmorPanel.TabIndex = 2;
            // 
            // WeaponPanel
            // 
            this.WeaponPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WeaponPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeaponPanel.Location = new System.Drawing.Point(16, 14);
            this.WeaponPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WeaponPanel.Name = "WeaponPanel";
            this.WeaponPanel.Size = new System.Drawing.Size(129, 288);
            this.WeaponPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Experience);
            this.groupBox1.Controls.Add(this.Level);
            this.groupBox1.Controls.Add(this.Mind);
            this.groupBox1.Controls.Add(this.Intellect);
            this.groupBox1.Controls.Add(this.Agality);
            this.groupBox1.Controls.Add(this.Health);
            this.groupBox1.Controls.Add(this.Stamina);
            this.groupBox1.Controls.Add(this.Power);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 309);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(348, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Param";
            // 
            // Experience
            // 
            this.Experience.AutoSize = true;
            this.Experience.Location = new System.Drawing.Point(8, 36);
            this.Experience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Experience.Name = "Experience";
            this.Experience.Size = new System.Drawing.Size(75, 15);
            this.Experience.TabIndex = 4;
            this.Experience.Text = "Experience";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(8, 21);
            this.Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(40, 15);
            this.Level.TabIndex = 4;
            this.Level.Text = "Level";
            // 
            // Mind
            // 
            this.Mind.AutoSize = true;
            this.Mind.Location = new System.Drawing.Point(8, 70);
            this.Mind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mind.Name = "Mind";
            this.Mind.Size = new System.Drawing.Size(37, 15);
            this.Mind.TabIndex = 4;
            this.Mind.Text = "Mind";
            // 
            // Intellect
            // 
            this.Intellect.AutoSize = true;
            this.Intellect.Location = new System.Drawing.Point(8, 130);
            this.Intellect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Intellect.Name = "Intellect";
            this.Intellect.Size = new System.Drawing.Size(58, 15);
            this.Intellect.TabIndex = 4;
            this.Intellect.Text = "Intellect";
            // 
            // Agality
            // 
            this.Agality.AutoSize = true;
            this.Agality.Location = new System.Drawing.Point(8, 115);
            this.Agality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Agality.Name = "Agality";
            this.Agality.Size = new System.Drawing.Size(54, 15);
            this.Agality.TabIndex = 4;
            this.Agality.Text = "Agality ";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Location = new System.Drawing.Point(8, 55);
            this.Health.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(52, 15);
            this.Health.TabIndex = 4;
            this.Health.Text = "Health ";
            // 
            // Stamina
            // 
            this.Stamina.AutoSize = true;
            this.Stamina.Location = new System.Drawing.Point(8, 85);
            this.Stamina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stamina.Name = "Stamina";
            this.Stamina.Size = new System.Drawing.Size(61, 15);
            this.Stamina.TabIndex = 5;
            this.Stamina.Text = "Stamina ";
            // 
            // Power
            // 
            this.Power.AutoSize = true;
            this.Power.Location = new System.Drawing.Point(8, 100);
            this.Power.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(49, 15);
            this.Power.TabIndex = 4;
            this.Power.Text = "Power ";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(880, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ArmorPanel);
            this.Controls.Add(this.WeaponPanel);
            this.Font = new System.Drawing.Font("Century", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel WeaponPanel;
        private System.Windows.Forms.Panel ArmorPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label Stamina;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Agality;
        private System.Windows.Forms.Label Intellect;
        private System.Windows.Forms.Label Mind;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.Label Level;
    }
}

