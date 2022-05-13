namespace Forms
{
    partial class CarsDataBase
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
            this.cars_dataGridView = new System.Windows.Forms.DataGridView();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cars_label = new System.Windows.Forms.Label();
            this.addCar_label = new System.Windows.Forms.Label();
            this.make_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.pricePerDay_label = new System.Windows.Forms.Label();
            this.carType_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.make_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.year_textBox = new System.Windows.Forms.TextBox();
            this.pricePerDay_textBox = new System.Windows.Forms.TextBox();
            this.carType_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.carsExplorer = new System.Windows.Forms.Button();
            this.clearDataBase_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.number_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cars_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.AliceBlue;
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Location = new System.Drawing.Point(925, 524);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(85, 52);
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
            this.load_button.Location = new System.Drawing.Point(236, 510);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(112, 66);
            this.load_button.TabIndex = 2;
            this.load_button.Text = "Load data";
            this.load_button.UseVisualStyleBackColor = false;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // cars_dataGridView
            // 
            this.cars_dataGridView.AllowUserToAddRows = false;
            this.cars_dataGridView.AllowUserToDeleteRows = false;
            this.cars_dataGridView.AutoGenerateColumns = false;
            this.cars_dataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.cars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cars_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.cars_dataGridView.DataSource = this.carsBindingSource;
            this.cars_dataGridView.GridColor = System.Drawing.Color.Orange;
            this.cars_dataGridView.Location = new System.Drawing.Point(236, 59);
            this.cars_dataGridView.Name = "cars_dataGridView";
            this.cars_dataGridView.ReadOnly = true;
            this.cars_dataGridView.Size = new System.Drawing.Size(774, 445);
            this.cars_dataGridView.TabIndex = 3;
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
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "Car type";
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            this.carTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.carTypeDataGridViewTextBoxColumn.Width = 113;
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
            // carsBindingSource
            // 
            this.carsBindingSource.DataSource = typeof(RentalServiceLib.Cars);
            // 
            // cars_label
            // 
            this.cars_label.AutoSize = true;
            this.cars_label.Location = new System.Drawing.Point(231, 13);
            this.cars_label.Name = "cars_label";
            this.cars_label.Size = new System.Drawing.Size(52, 27);
            this.cars_label.TabIndex = 4;
            this.cars_label.Text = "Cars";
            // 
            // addCar_label
            // 
            this.addCar_label.AutoSize = true;
            this.addCar_label.Location = new System.Drawing.Point(12, 13);
            this.addCar_label.Name = "addCar_label";
            this.addCar_label.Size = new System.Drawing.Size(126, 27);
            this.addCar_label.TabIndex = 5;
            this.addCar_label.Text = "Add new car";
            // 
            // make_label
            // 
            this.make_label.AutoSize = true;
            this.make_label.Location = new System.Drawing.Point(12, 59);
            this.make_label.Name = "make_label";
            this.make_label.Size = new System.Drawing.Size(62, 27);
            this.make_label.TabIndex = 6;
            this.make_label.Text = "Make";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(12, 135);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(71, 27);
            this.model_label.TabIndex = 7;
            this.model_label.Text = "Model";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(12, 211);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(51, 27);
            this.year_label.TabIndex = 8;
            this.year_label.Text = "Year";
            // 
            // pricePerDay_label
            // 
            this.pricePerDay_label.AutoSize = true;
            this.pricePerDay_label.Location = new System.Drawing.Point(12, 287);
            this.pricePerDay_label.Name = "pricePerDay_label";
            this.pricePerDay_label.Size = new System.Drawing.Size(130, 27);
            this.pricePerDay_label.TabIndex = 9;
            this.pricePerDay_label.Text = "Price per day";
            // 
            // carType_label
            // 
            this.carType_label.AutoSize = true;
            this.carType_label.Location = new System.Drawing.Point(12, 363);
            this.carType_label.Name = "carType_label";
            this.carType_label.Size = new System.Drawing.Size(88, 27);
            this.carType_label.TabIndex = 10;
            this.carType_label.Text = "Car type";
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(12, 439);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(87, 27);
            this.number_label.TabIndex = 11;
            this.number_label.Text = "Number";
            // 
            // make_textBox
            // 
            this.make_textBox.Location = new System.Drawing.Point(17, 89);
            this.make_textBox.Name = "make_textBox";
            this.make_textBox.Size = new System.Drawing.Size(190, 34);
            this.make_textBox.TabIndex = 12;
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(17, 165);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(190, 34);
            this.model_textBox.TabIndex = 13;
            // 
            // year_textBox
            // 
            this.year_textBox.Location = new System.Drawing.Point(17, 241);
            this.year_textBox.Name = "year_textBox";
            this.year_textBox.Size = new System.Drawing.Size(190, 34);
            this.year_textBox.TabIndex = 14;
            // 
            // pricePerDay_textBox
            // 
            this.pricePerDay_textBox.Location = new System.Drawing.Point(17, 317);
            this.pricePerDay_textBox.Name = "pricePerDay_textBox";
            this.pricePerDay_textBox.Size = new System.Drawing.Size(190, 34);
            this.pricePerDay_textBox.TabIndex = 15;
            // 
            // carType_textBox
            // 
            this.carType_textBox.Location = new System.Drawing.Point(17, 393);
            this.carType_textBox.Name = "carType_textBox";
            this.carType_textBox.Size = new System.Drawing.Size(190, 34);
            this.carType_textBox.TabIndex = 16;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.AliceBlue;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Location = new System.Drawing.Point(17, 515);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(82, 52);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.AliceBlue;
            this.clear_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Location = new System.Drawing.Point(125, 515);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(82, 52);
            this.clear_button.TabIndex = 19;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.AliceBlue;
            this.update_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(472, 509);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(112, 66);
            this.update_button.TabIndex = 20;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // carsExplorer
            // 
            this.carsExplorer.BackColor = System.Drawing.Color.AliceBlue;
            this.carsExplorer.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.carsExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsExplorer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsExplorer.Location = new System.Drawing.Point(590, 510);
            this.carsExplorer.Name = "carsExplorer";
            this.carsExplorer.Size = new System.Drawing.Size(123, 66);
            this.carsExplorer.TabIndex = 21;
            this.carsExplorer.Text = "View cars in explorer";
            this.carsExplorer.UseVisualStyleBackColor = false;
            this.carsExplorer.Click += new System.EventHandler(this.carsExplorer_Click);
            // 
            // clearDataBase_button
            // 
            this.clearDataBase_button.BackColor = System.Drawing.Color.AliceBlue;
            this.clearDataBase_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clearDataBase_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDataBase_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDataBase_button.Location = new System.Drawing.Point(354, 509);
            this.clearDataBase_button.Name = "clearDataBase_button";
            this.clearDataBase_button.Size = new System.Drawing.Size(112, 66);
            this.clearDataBase_button.TabIndex = 22;
            this.clearDataBase_button.Text = "Clear";
            this.clearDataBase_button.UseVisualStyleBackColor = false;
            this.clearDataBase_button.Click += new System.EventHandler(this.clearDataBase_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.AliceBlue;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.Location = new System.Drawing.Point(719, 510);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(119, 66);
            this.delete_button.TabIndex = 29;
            this.delete_button.Text = "Delete selected row";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // number_textBox
            // 
            this.number_textBox.Location = new System.Drawing.Point(17, 469);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(190, 34);
            this.number_textBox.TabIndex = 30;
            // 
            // CarsDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.number_textBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clearDataBase_button);
            this.Controls.Add(this.carsExplorer);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.carType_textBox);
            this.Controls.Add(this.pricePerDay_textBox);
            this.Controls.Add(this.year_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.make_textBox);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.carType_label);
            this.Controls.Add(this.pricePerDay_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.make_label);
            this.Controls.Add(this.addCar_label);
            this.Controls.Add(this.cars_label);
            this.Controls.Add(this.cars_dataGridView);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.close_button);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CarsDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.cars_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.DataGridView cars_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.Label cars_label;
        private System.Windows.Forms.Label addCar_label;
        private System.Windows.Forms.Label make_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label pricePerDay_label;
        private System.Windows.Forms.Label carType_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.TextBox make_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox year_textBox;
        private System.Windows.Forms.TextBox pricePerDay_textBox;
        private System.Windows.Forms.TextBox carType_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button carsExplorer;
        private System.Windows.Forms.Button clearDataBase_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox number_textBox;
    }
}