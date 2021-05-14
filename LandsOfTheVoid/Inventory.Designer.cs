
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Experience = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.Mind = new System.Windows.Forms.Label();
            this.Intellect = new System.Windows.Forms.Label();
            this.Agality = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.Stamina = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.Label();
            this.tableInventory = new System.Windows.Forms.DataGridView();
            this.classItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutOn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HelmPanel = new System.Windows.Forms.Panel();
            this.ArmorPanel = new System.Windows.Forms.Panel();
            this.WeaponPanel = new System.Windows.Forms.Panel();
            this.GasMaskPanel = new System.Windows.Forms.Panel();
            this.rucksackPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UnloadSystem = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BootsPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableInventory)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(501, 450);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(665, 179);
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
            this.Stamina.Click += new System.EventHandler(this.Stamina_Click);
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
            // dataGridView1
            // 
            this.tableInventory.AllowUserToAddRows = false;
            this.tableInventory.AllowUserToDeleteRows = false;
            this.tableInventory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.tableInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classItem,
            this.NameItem,
            this.weight,
            this.Count,
            this.PutOn});
            this.tableInventory.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableInventory.Location = new System.Drawing.Point(501, 14);
            this.tableInventory.Name = "dataGridView1";
            this.tableInventory.ReadOnly = true;
            this.tableInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableInventory.Size = new System.Drawing.Size(667, 429);
            this.tableInventory.TabIndex = 4;
            this.tableInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // classItem
            // 
            this.classItem.HeaderText = "Класс";
            this.classItem.Name = "classItem";
            this.classItem.ReadOnly = true;
            // 
            // NameItem
            // 
            this.NameItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameItem.HeaderText = "Предмет";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            this.NameItem.Width = 85;
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // PutOn
            // 
            this.PutOn.HeaderText = "Надет";
            this.PutOn.Name = "PutOn";
            this.PutOn.ReadOnly = true;
            // 
            // HelmPanel
            // 
            this.HelmPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HelmPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HelmPanel.Location = new System.Drawing.Point(149, 12);
            this.HelmPanel.Name = "HelmPanel";
            this.HelmPanel.Size = new System.Drawing.Size(200, 137);
            this.HelmPanel.TabIndex = 6;
            // 
            // ArmorPanel
            // 
            this.ArmorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ArmorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ArmorPanel.Location = new System.Drawing.Point(149, 155);
            this.ArmorPanel.Name = "ArmorPanel";
            this.ArmorPanel.Size = new System.Drawing.Size(200, 288);
            this.ArmorPanel.TabIndex = 5;
            // 
            // WeaponPanel
            // 
            this.WeaponPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeaponPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeaponPanel.Location = new System.Drawing.Point(13, 155);
            this.WeaponPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WeaponPanel.Name = "WeaponPanel";
            this.WeaponPanel.Size = new System.Drawing.Size(129, 288);
            this.WeaponPanel.TabIndex = 1;
            // 
            // GasMaskPanel
            // 
            this.GasMaskPanel.BackColor = System.Drawing.SystemColors.Window;
            this.GasMaskPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GasMaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GasMaskPanel.Location = new System.Drawing.Point(13, 12);
            this.GasMaskPanel.Name = "GasMaskPanel";
            this.GasMaskPanel.Size = new System.Drawing.Size(129, 137);
            this.GasMaskPanel.TabIndex = 7;
            // 
            // rucksackPanel
            // 
            this.rucksackPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rucksackPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rucksackPanel.Location = new System.Drawing.Point(355, 155);
            this.rucksackPanel.Name = "rucksackPanel";
            this.rucksackPanel.Size = new System.Drawing.Size(140, 185);
            this.rucksackPanel.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(355, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 137);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(355, 346);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 97);
            this.panel4.TabIndex = 10;
            // 
            // UnloadSystem
            // 
            this.UnloadSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UnloadSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UnloadSystem.Location = new System.Drawing.Point(149, 450);
            this.UnloadSystem.Name = "UnloadSystem";
            this.UnloadSystem.Size = new System.Drawing.Size(200, 179);
            this.UnloadSystem.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(13, 450);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 179);
            this.panel6.TabIndex = 12;
            // 
            // BootsPanel
            // 
            this.BootsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BootsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BootsPanel.Location = new System.Drawing.Point(355, 450);
            this.BootsPanel.Name = "BootsPanel";
            this.BootsPanel.Size = new System.Drawing.Size(140, 179);
            this.BootsPanel.TabIndex = 13;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 857);
            this.Controls.Add(this.BootsPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.UnloadSystem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rucksackPanel);
            this.Controls.Add(this.GasMaskPanel);
            this.Controls.Add(this.HelmPanel);
            this.Controls.Add(this.ArmorPanel);
            this.Controls.Add(this.tableInventory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WeaponPanel);
            this.Font = new System.Drawing.Font("Century", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
            ((System.ComponentModel.ISupportInitialize)(this.tableInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel WeaponPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label Stamina;
        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Agality;
        private System.Windows.Forms.Label Intellect;
        private System.Windows.Forms.Label Mind;
        private System.Windows.Forms.Label Experience;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.DataGridView tableInventory;
        private System.Windows.Forms.Panel ArmorPanel;
        private System.Windows.Forms.Panel HelmPanel;
        private System.Windows.Forms.Panel GasMaskPanel;
        private System.Windows.Forms.Panel rucksackPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel UnloadSystem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel BootsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn classItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PutOn;
    }
}

