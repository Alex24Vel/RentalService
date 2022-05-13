namespace Forms
{
    partial class TrucksDataBase
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
            this.components = new System.ComponentModel.Container();
            this.close_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.trucks_dataGridView = new System.Windows.Forms.DataGridView();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trucksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearDataBase_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.trucksExplorer = new System.Windows.Forms.Button();
            this.trucks_label = new System.Windows.Forms.Label();
            this.addTruck_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.number_comboBox = new System.Windows.Forms.ComboBox();
            this.truckType_textBox = new System.Windows.Forms.TextBox();
            this.pricePerDay_textBox = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.make_textBox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.truckType_label = new System.Windows.Forms.Label();
            this.pricePerDay_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.make_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trucks_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.AliceBlue;
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_button.Location = new System.Drawing.Point(985, 568);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(86, 53);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // load_button
            // 
            this.load_button.BackColor = System.Drawing.Color.AliceBlue;
            this.load_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.Location = new System.Drawing.Point(255, 537);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(107, 62);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = false;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // trucks_dataGridView
            // 
            this.trucks_dataGridView.AllowUserToAddRows = false;
            this.trucks_dataGridView.AllowUserToDeleteRows = false;
            this.trucks_dataGridView.AutoGenerateColumns = false;
            this.trucks_dataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.trucks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trucks_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.truckTypeDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.trucks_dataGridView.DataSource = this.trucksBindingSource;
            this.trucks_dataGridView.GridColor = System.Drawing.Color.Orange;
            this.trucks_dataGridView.Location = new System.Drawing.Point(255, 43);
            this.trucks_dataGridView.Name = "trucks_dataGridView";
            this.trucks_dataGridView.ReadOnly = true;
            this.trucks_dataGridView.RowHeadersWidth = 51;
            this.trucks_dataGridView.RowTemplate.Height = 24;
            this.trucks_dataGridView.Size = new System.Drawing.Size(816, 488);
            this.trucks_dataGridView.TabIndex = 2;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.ReadOnly = true;
            this.makeDataGridViewTextBoxColumn.Width = 87;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 96;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 76;
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "PricePerDay";
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Price per pay";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerDayDataGridViewTextBoxColumn.Width = 155;
            // 
            // truckTypeDataGridViewTextBoxColumn
            // 
            this.truckTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.truckTypeDataGridViewTextBoxColumn.DataPropertyName = "TruckType";
            this.truckTypeDataGridViewTextBoxColumn.HeaderText = "Truck type";
            this.truckTypeDataGridViewTextBoxColumn.Name = "truckTypeDataGridViewTextBoxColumn";
            this.truckTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.truckTypeDataGridViewTextBoxColumn.Width = 131;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 112;
            // 
            // trucksBindingSource
            // 
            this.trucksBindingSource.DataSource = typeof(RentalServiceLib.Trucks);
            // 
            // clearDataBase_button
            // 
            this.clearDataBase_button.BackColor = System.Drawing.Color.AliceBlue;
            this.clearDataBase_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clearDataBase_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDataBase_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDataBase_button.Location = new System.Drawing.Point(368, 537);
            this.clearDataBase_button.Name = "clearDataBase_button";
            this.clearDataBase_button.Size = new System.Drawing.Size(107, 62);
            this.clearDataBase_button.TabIndex = 3;
            this.clearDataBase_button.Text = "Clear";
            this.clearDataBase_button.UseVisualStyleBackColor = false;
            this.clearDataBase_button.Click += new System.EventHandler(this.clearDataBase_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.AliceBlue;
            this.update_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(485, 537);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(107, 62);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // trucksExplorer
            // 
            this.trucksExplorer.BackColor = System.Drawing.Color.AliceBlue;
            this.trucksExplorer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.trucksExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trucksExplorer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trucksExplorer.Location = new System.Drawing.Point(598, 537);
            this.trucksExplorer.Name = "trucksExplorer";
            this.trucksExplorer.Size = new System.Drawing.Size(143, 62);
            this.trucksExplorer.TabIndex = 5;
            this.trucksExplorer.Text = "View trucks in explorer";
            this.trucksExplorer.UseVisualStyleBackColor = false;
            this.trucksExplorer.Click += new System.EventHandler(this.trucksExplorer_Click);
            // 
            // trucks_label
            // 
            this.trucks_label.AutoSize = true;
            this.trucks_label.Location = new System.Drawing.Point(250, 13);
            this.trucks_label.Name = "trucks_label";
            this.trucks_label.Size = new System.Drawing.Size(70, 27);
            this.trucks_label.TabIndex = 6;
            this.trucks_label.Text = "Trucks";
            // 
            // addTruck_label
            // 
            this.addTruck_label.AutoSize = true;
            this.addTruck_label.Location = new System.Drawing.Point(12, 13);
            this.addTruck_label.Name = "addTruck_label";
            this.addTruck_label.Size = new System.Drawing.Size(144, 27);
            this.addTruck_label.TabIndex = 7;
            this.addTruck_label.Text = "Add new truck";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.AliceBlue;
            this.clear_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(109, 505);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(82, 52);
            this.clear_button.TabIndex = 33;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.AliceBlue;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(17, 505);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 52);
            this.add_button.TabIndex = 32;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // number_comboBox
            // 
            this.number_comboBox.DataSource = this.trucksBindingSource;
            this.number_comboBox.DisplayMember = "Number";
            this.number_comboBox.FormattingEnabled = true;
            this.number_comboBox.Location = new System.Drawing.Point(17, 459);
            this.number_comboBox.Name = "number_comboBox";
            this.number_comboBox.Size = new System.Drawing.Size(207, 35);
            this.number_comboBox.TabIndex = 31;
            this.number_comboBox.ValueMember = "Number";
            // 
            // truckType_textBox
            // 
            this.truckType_textBox.Location = new System.Drawing.Point(17, 383);
            this.truckType_textBox.Name = "truckType_textBox";
            this.truckType_textBox.Size = new System.Drawing.Size(207, 34);
            this.truckType_textBox.TabIndex = 30;
            // 
            // pricePerDay_textBox
            // 
            this.pricePerDay_textBox.Location = new System.Drawing.Point(17, 307);
            this.pricePerDay_textBox.Name = "pricePerDay_textBox";
            this.pricePerDay_textBox.Size = new System.Drawing.Size(207, 34);
            this.pricePerDay_textBox.TabIndex = 29;
            // 
            // year_textBox
            // 
            this.year_textBox.Location = new System.Drawing.Point(17, 231);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(207, 34);
            this.year_textBox.TabIndex = 28;
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(17, 155);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(207, 34);
            this.model_textBox.TabIndex = 27;
            // 
            // make_textBox
            // 
            this.make_textBox.Location = new System.Drawing.Point(17, 79);
            this.make_textBox.Name = "make_textBox";
            this.make_textBox.Size = new System.Drawing.Size(207, 34);
            this.make_textBox.TabIndex = 26;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(12, 429);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(87, 27);
            this.number_label.TabIndex = 25;
            this.number_label.Text = "Number";
            // 
            // truckType_label
            // 
            this.truckType_label.AutoSize = true;
            this.truckType_label.Location = new System.Drawing.Point(12, 353);
            this.truckType_label.Name = "truckType_label";
            this.truckType_label.Size = new System.Drawing.Size(106, 27);
            this.truckType_label.TabIndex = 24;
            this.truckType_label.Text = "Truck type";
            // 
            // pricePerDay_label
            // 
            this.pricePerDay_label.AutoSize = true;
            this.pricePerDay_label.Location = new System.Drawing.Point(12, 277);
            this.pricePerDay_label.Name = "pricePerDay_label";
            this.pricePerDay_label.Size = new System.Drawing.Size(130, 27);
            this.pricePerDay_label.TabIndex = 23;
            this.pricePerDay_label.Text = "Price per day";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(12, 201);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(51, 27);
            this.year_label.TabIndex = 22;
            this.year_label.Text = "Year";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(12, 125);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(71, 27);
            this.model_label.TabIndex = 21;
            this.model_label.Text = "Model";
            // 
            // make_label
            // 
            this.make_label.AutoSize = true;
            this.make_label.Location = new System.Drawing.Point(12, 49);
            this.make_label.Name = "make_label";
            this.make_label.Size = new System.Drawing.Size(62, 27);
            this.make_label.TabIndex = 20;
            this.make_label.Text = "Make";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.AliceBlue;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.Location = new System.Drawing.Point(747, 537);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(118, 62);
            this.delete_button.TabIndex = 34;
            this.delete_button.Text = "Delete selected row";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // TrucksDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 633);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.number_comboBox);
            this.Controls.Add(this.truckType_textBox);
            this.Controls.Add(this.pricePerDay_textBox);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.make_textBox);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.truckType_label);
            this.Controls.Add(this.pricePerDay_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.make_label);
            this.Controls.Add(this.addTruck_label);
            this.Controls.Add(this.trucks_label);
            this.Controls.Add(this.trucksExplorer);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clearDataBase_button);
            this.Controls.Add(this.trucks_dataGridView);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.close_button);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TrucksDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrucksDataBase";
            ((System.ComponentModel.ISupportInitialize)(this.trucks_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trucksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.DataGridView trucks_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trucksBindingSource;
        private System.Windows.Forms.Button clearDataBase_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button trucksExplorer;
        private System.Windows.Forms.Label trucks_label;
        private System.Windows.Forms.Label addTruck_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox number_comboBox;
        private System.Windows.Forms.TextBox truckType_textBox;
        private System.Windows.Forms.TextBox pricePerDay_textBox;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox make_textBox;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label truckType_label;
        private System.Windows.Forms.Label pricePerDay_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label make_label;
        private System.Windows.Forms.Button delete_button;
    }
}