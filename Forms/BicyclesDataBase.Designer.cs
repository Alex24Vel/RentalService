namespace Forms
{
    partial class BicyclesDataBase
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
            this.bicycles_dataGridView = new System.Windows.Forms.DataGridView();
            this.clear_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.number_comboBox = new System.Windows.Forms.ComboBox();
            this.pricePerDay_textBox = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.make_textBox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.pricePerDay_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.make_label = new System.Windows.Forms.Label();
            this.addBicycle_label = new System.Windows.Forms.Label();
            this.bicycles_label = new System.Windows.Forms.Label();
            this.bicyclesExplorer = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.clearDataBase_button = new System.Windows.Forms.Button();
            this.bicyclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bicycles_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicyclesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(742, 502);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(90, 56);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(234, 496);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(122, 62);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "Load data";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // bicycles_dataGridView
            // 
            this.bicycles_dataGridView.AllowUserToAddRows = false;
            this.bicycles_dataGridView.AllowUserToDeleteRows = false;
            this.bicycles_dataGridView.AutoGenerateColumns = false;
            this.bicycles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bicycles_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.bicycles_dataGridView.DataSource = this.bicyclesBindingSource;
            this.bicycles_dataGridView.Location = new System.Drawing.Point(234, 43);
            this.bicycles_dataGridView.Name = "bicycles_dataGridView";
            this.bicycles_dataGridView.ReadOnly = true;
            this.bicycles_dataGridView.RowHeadersWidth = 51;
            this.bicycles_dataGridView.RowTemplate.Height = 24;
            this.bicycles_dataGridView.Size = new System.Drawing.Size(599, 447);
            this.bicycles_dataGridView.TabIndex = 2;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(109, 430);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(82, 52);
            this.clear_button.TabIndex = 61;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(17, 430);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 52);
            this.add_button.TabIndex = 60;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // number_comboBox
            // 
            this.number_comboBox.DataSource = this.bicyclesBindingSource;
            this.number_comboBox.DisplayMember = "Number";
            this.number_comboBox.FormattingEnabled = true;
            this.number_comboBox.Location = new System.Drawing.Point(17, 384);
            this.number_comboBox.Name = "number_comboBox";
            this.number_comboBox.Size = new System.Drawing.Size(174, 35);
            this.number_comboBox.TabIndex = 59;
            this.number_comboBox.ValueMember = "Number";
            // 
            // pricePerDay_textBox
            // 
            this.pricePerDay_textBox.Location = new System.Drawing.Point(17, 307);
            this.pricePerDay_textBox.Name = "pricePerDay_textBox";
            this.pricePerDay_textBox.Size = new System.Drawing.Size(174, 34);
            this.pricePerDay_textBox.TabIndex = 58;
            // 
            // year_textBox
            // 
            this.year_textBox.Location = new System.Drawing.Point(17, 231);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(174, 34);
            this.year_textBox.TabIndex = 57;
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(17, 155);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(174, 34);
            this.model_textBox.TabIndex = 56;
            // 
            // make_textBox
            // 
            this.make_textBox.Location = new System.Drawing.Point(17, 79);
            this.make_textBox.Name = "make_textBox";
            this.make_textBox.Size = new System.Drawing.Size(174, 34);
            this.make_textBox.TabIndex = 55;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(12, 354);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(87, 27);
            this.number_label.TabIndex = 54;
            this.number_label.Text = "Number";
            // 
            // pricePerDay_label
            // 
            this.pricePerDay_label.AutoSize = true;
            this.pricePerDay_label.Location = new System.Drawing.Point(12, 277);
            this.pricePerDay_label.Name = "pricePerDay_label";
            this.pricePerDay_label.Size = new System.Drawing.Size(130, 27);
            this.pricePerDay_label.TabIndex = 53;
            this.pricePerDay_label.Text = "Price per day";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(12, 201);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(51, 27);
            this.year_label.TabIndex = 52;
            this.year_label.Text = "Year";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(12, 125);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(71, 27);
            this.model_label.TabIndex = 51;
            this.model_label.Text = "Model";
            // 
            // make_label
            // 
            this.make_label.AutoSize = true;
            this.make_label.Location = new System.Drawing.Point(12, 49);
            this.make_label.Name = "make_label";
            this.make_label.Size = new System.Drawing.Size(62, 27);
            this.make_label.TabIndex = 50;
            this.make_label.Text = "Make";
            // 
            // addBicycle_label
            // 
            this.addBicycle_label.AutoSize = true;
            this.addBicycle_label.Location = new System.Drawing.Point(12, 13);
            this.addBicycle_label.Name = "addBicycle_label";
            this.addBicycle_label.Size = new System.Drawing.Size(159, 27);
            this.addBicycle_label.TabIndex = 49;
            this.addBicycle_label.Text = "Add new bicycle";
            // 
            // bicycles_label
            // 
            this.bicycles_label.AutoSize = true;
            this.bicycles_label.Location = new System.Drawing.Point(229, 13);
            this.bicycles_label.Name = "bicycles_label";
            this.bicycles_label.Size = new System.Drawing.Size(82, 27);
            this.bicycles_label.TabIndex = 62;
            this.bicycles_label.Text = "Bicycles";
            // 
            // bicyclesExplorer
            // 
            this.bicyclesExplorer.Location = new System.Drawing.Point(568, 496);
            this.bicyclesExplorer.Name = "bicyclesExplorer";
            this.bicyclesExplorer.Size = new System.Drawing.Size(139, 62);
            this.bicyclesExplorer.TabIndex = 65;
            this.bicyclesExplorer.Text = "View bicycles in explorer";
            this.bicyclesExplorer.UseVisualStyleBackColor = true;
            this.bicyclesExplorer.Click += new System.EventHandler(this.bicyclesExplorer_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(465, 496);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(97, 62);
            this.update_button.TabIndex = 64;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // clearDataBase_button
            // 
            this.clearDataBase_button.Location = new System.Drawing.Point(362, 496);
            this.clearDataBase_button.Name = "clearDataBase_button";
            this.clearDataBase_button.Size = new System.Drawing.Size(97, 62);
            this.clearDataBase_button.TabIndex = 63;
            this.clearDataBase_button.Text = "Clear";
            this.clearDataBase_button.UseVisualStyleBackColor = true;
            this.clearDataBase_button.Click += new System.EventHandler(this.clearDataBase_button_Click);
            // 
            // bicyclesBindingSource
            // 
            this.bicyclesBindingSource.DataSource = typeof(RentalServiceLib.Bicycles);
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
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Price per day";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerDayDataGridViewTextBoxColumn.Width = 155;
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
            // BicyclesDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 570);
            this.Controls.Add(this.bicyclesExplorer);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clearDataBase_button);
            this.Controls.Add(this.bicycles_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.number_comboBox);
            this.Controls.Add(this.pricePerDay_textBox);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.make_textBox);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.pricePerDay_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.make_label);
            this.Controls.Add(this.addBicycle_label);
            this.Controls.Add(this.bicycles_dataGridView);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.close_button);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "BicyclesDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BicyclesDataBase";
            this.Load += new System.EventHandler(this.BicyclesDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bicycles_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicyclesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.DataGridView bicycles_dataGridView;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox number_comboBox;
        private System.Windows.Forms.TextBox pricePerDay_textBox;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox make_textBox;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label pricePerDay_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label make_label;
        private System.Windows.Forms.Label addBicycle_label;
        private System.Windows.Forms.Label bicycles_label;
        private System.Windows.Forms.Button bicyclesExplorer;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button clearDataBase_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bicyclesBindingSource;
    }
}