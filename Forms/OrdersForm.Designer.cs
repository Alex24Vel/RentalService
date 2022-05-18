namespace Forms
{
    partial class OrdersForm
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
            this.addOrder_textBox = new System.Windows.Forms.TextBox();
            this.chooseVehicle_label = new System.Windows.Forms.Label();
            this.vehicles_comboBox = new System.Windows.Forms.ComboBox();
            this.number_label = new System.Windows.Forms.Label();
            this.rentDate_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.orderstext_label = new System.Windows.Forms.Label();
            this.load_button = new System.Windows.Forms.Button();
            this.dueDate_label = new System.Windows.Forms.Label();
            this.renter_label = new System.Windows.Forms.Label();
            this.renter_textBox = new System.Windows.Forms.TextBox();
            this.orders_dataGridView = new System.Windows.Forms.DataGridView();
            this.rentDate_textBox = new System.Windows.Forms.TextBox();
            this.dueDate_textBox = new System.Windows.Forms.TextBox();
            this.clearDataBase_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.vehicleNumbers_comboBox = new System.Windows.Forms.ComboBox();
            this.ordersExplorer_button = new System.Windows.Forms.Button();
            this.showOnly_label = new System.Windows.Forms.Label();
            this.showBy_comboBox = new System.Windows.Forms.ComboBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleNumbersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrder_textBox
            // 
            this.addOrder_textBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addOrder_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addOrder_textBox.Location = new System.Drawing.Point(17, 21);
            this.addOrder_textBox.Name = "addOrder_textBox";
            this.addOrder_textBox.Size = new System.Drawing.Size(188, 27);
            this.addOrder_textBox.TabIndex = 1;
            this.addOrder_textBox.TabStop = false;
            this.addOrder_textBox.Text = "Add new order";
            // 
            // chooseVehicle_label
            // 
            this.chooseVehicle_label.AutoSize = true;
            this.chooseVehicle_label.Location = new System.Drawing.Point(13, 141);
            this.chooseVehicle_label.Name = "chooseVehicle_label";
            this.chooseVehicle_label.Size = new System.Drawing.Size(148, 27);
            this.chooseVehicle_label.TabIndex = 2;
            this.chooseVehicle_label.Text = "Choose vehicle";
            // 
            // vehicles_comboBox
            // 
            this.vehicles_comboBox.FormattingEnabled = true;
            this.vehicles_comboBox.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Motocycle",
            "Bicycle"});
            this.vehicles_comboBox.Location = new System.Drawing.Point(17, 171);
            this.vehicles_comboBox.Name = "vehicles_comboBox";
            this.vehicles_comboBox.Size = new System.Drawing.Size(233, 35);
            this.vehicles_comboBox.TabIndex = 3;
            this.vehicles_comboBox.SelectedIndexChanged += new System.EventHandler(this.Vehicles_comboBox_SelectedIndexChanged);
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(13, 220);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(154, 27);
            this.number_label.TabIndex = 4;
            this.number_label.Text = "Vehicle number";
            // 
            // rentDate_label
            // 
            this.rentDate_label.AutoSize = true;
            this.rentDate_label.Location = new System.Drawing.Point(13, 296);
            this.rentDate_label.Name = "rentDate_label";
            this.rentDate_label.Size = new System.Drawing.Size(100, 27);
            this.rentDate_label.TabIndex = 6;
            this.rentDate_label.Text = "Rent date";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.AliceBlue;
            this.add_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.ForeColor = System.Drawing.Color.Black;
            this.add_button.Location = new System.Drawing.Point(18, 459);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(68, 41);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.AliceBlue;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Location = new System.Drawing.Point(928, 564);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(82, 57);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.AliceBlue;
            this.clear_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.ForeColor = System.Drawing.Color.Black;
            this.clear_button.Location = new System.Drawing.Point(177, 459);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(73, 41);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // orderstext_label
            // 
            this.orderstext_label.AutoSize = true;
            this.orderstext_label.Location = new System.Drawing.Point(266, 21);
            this.orderstext_label.Name = "orderstext_label";
            this.orderstext_label.Size = new System.Drawing.Size(75, 27);
            this.orderstext_label.TabIndex = 11;
            this.orderstext_label.Text = "Orders";
            // 
            // load_button
            // 
            this.load_button.BackColor = System.Drawing.Color.AliceBlue;
            this.load_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.load_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_button.ForeColor = System.Drawing.Color.Black;
            this.load_button.Location = new System.Drawing.Point(271, 518);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(113, 58);
            this.load_button.TabIndex = 12;
            this.load_button.Text = "Load data";
            this.load_button.UseVisualStyleBackColor = false;
            this.load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // dueDate_label
            // 
            this.dueDate_label.AutoSize = true;
            this.dueDate_label.Location = new System.Drawing.Point(13, 376);
            this.dueDate_label.Name = "dueDate_label";
            this.dueDate_label.Size = new System.Drawing.Size(95, 27);
            this.dueDate_label.TabIndex = 14;
            this.dueDate_label.Text = "Due date";
            // 
            // renter_label
            // 
            this.renter_label.AutoSize = true;
            this.renter_label.Location = new System.Drawing.Point(12, 65);
            this.renter_label.Name = "renter_label";
            this.renter_label.Size = new System.Drawing.Size(73, 27);
            this.renter_label.TabIndex = 16;
            this.renter_label.Text = "Renter";
            // 
            // renter_textBox
            // 
            this.renter_textBox.Location = new System.Drawing.Point(17, 95);
            this.renter_textBox.Name = "renter_textBox";
            this.renter_textBox.Size = new System.Drawing.Size(233, 34);
            this.renter_textBox.TabIndex = 17;
            this.renter_textBox.TabStop = false;
            // 
            // orders_dataGridView
            // 
            this.orders_dataGridView.AllowUserToAddRows = false;
            this.orders_dataGridView.AllowUserToDeleteRows = false;
            this.orders_dataGridView.AutoGenerateColumns = false;
            this.orders_dataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.orders_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orders_dataGridView.DataSource = this.ordersBindingSource;
            this.orders_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orders_dataGridView.GridColor = System.Drawing.Color.Orange;
            this.orders_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.orders_dataGridView.Location = new System.Drawing.Point(271, 86);
            this.orders_dataGridView.MinimumSize = new System.Drawing.Size(0, 45);
            this.orders_dataGridView.Name = "orders_dataGridView";
            this.orders_dataGridView.ReadOnly = true;
            this.orders_dataGridView.Size = new System.Drawing.Size(741, 426);
            this.orders_dataGridView.TabIndex = 18;
            // 
            // rentDate_textBox
            // 
            this.rentDate_textBox.Location = new System.Drawing.Point(18, 326);
            this.rentDate_textBox.Name = "rentDate_textBox";
            this.rentDate_textBox.Size = new System.Drawing.Size(232, 34);
            this.rentDate_textBox.TabIndex = 20;
            this.rentDate_textBox.TabStop = false;
            // 
            // dueDate_textBox
            // 
            this.dueDate_textBox.Location = new System.Drawing.Point(18, 406);
            this.dueDate_textBox.Name = "dueDate_textBox";
            this.dueDate_textBox.Size = new System.Drawing.Size(232, 34);
            this.dueDate_textBox.TabIndex = 21;
            this.dueDate_textBox.TabStop = false;
            // 
            // clearDataBase_button
            // 
            this.clearDataBase_button.BackColor = System.Drawing.Color.AliceBlue;
            this.clearDataBase_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.clearDataBase_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDataBase_button.ForeColor = System.Drawing.Color.Black;
            this.clearDataBase_button.Location = new System.Drawing.Point(506, 518);
            this.clearDataBase_button.Name = "clearDataBase_button";
            this.clearDataBase_button.Size = new System.Drawing.Size(110, 60);
            this.clearDataBase_button.TabIndex = 22;
            this.clearDataBase_button.Text = "Clear ";
            this.clearDataBase_button.UseVisualStyleBackColor = false;
            this.clearDataBase_button.Click += new System.EventHandler(this.ClearDataBase_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.AliceBlue;
            this.update_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.ForeColor = System.Drawing.Color.Black;
            this.update_button.Location = new System.Drawing.Point(390, 518);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(110, 60);
            this.update_button.TabIndex = 23;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // vehicleNumbers_comboBox
            // 
            this.vehicleNumbers_comboBox.DataSource = this.vehicleNumbersBindingSource;
            this.vehicleNumbers_comboBox.DisplayMember = "Number";
            this.vehicleNumbers_comboBox.FormattingEnabled = true;
            this.vehicleNumbers_comboBox.Location = new System.Drawing.Point(17, 250);
            this.vehicleNumbers_comboBox.Name = "vehicleNumbers_comboBox";
            this.vehicleNumbers_comboBox.Size = new System.Drawing.Size(233, 35);
            this.vehicleNumbers_comboBox.TabIndex = 24;
            this.vehicleNumbers_comboBox.ValueMember = "Number";
            // 
            // ordersExplorer_button
            // 
            this.ordersExplorer_button.BackColor = System.Drawing.Color.AliceBlue;
            this.ordersExplorer_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ordersExplorer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersExplorer_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersExplorer_button.ForeColor = System.Drawing.Color.Black;
            this.ordersExplorer_button.Location = new System.Drawing.Point(622, 518);
            this.ordersExplorer_button.Name = "ordersExplorer_button";
            this.ordersExplorer_button.Size = new System.Drawing.Size(154, 60);
            this.ordersExplorer_button.TabIndex = 25;
            this.ordersExplorer_button.Text = "Show orders in file explorer";
            this.ordersExplorer_button.UseVisualStyleBackColor = false;
            this.ordersExplorer_button.Click += new System.EventHandler(this.OrdersExplorer_button_Click);
            // 
            // showOnly_label
            // 
            this.showOnly_label.AutoSize = true;
            this.showOnly_label.Location = new System.Drawing.Point(701, 21);
            this.showOnly_label.Name = "showOnly_label";
            this.showOnly_label.Size = new System.Drawing.Size(157, 27);
            this.showOnly_label.TabIndex = 26;
            this.showOnly_label.Text = "Orders only for:";
            // 
            // showBy_comboBox
            // 
            this.showBy_comboBox.FormattingEnabled = true;
            this.showBy_comboBox.Items.AddRange(new object[] {
            "Car",
            "Truck",
            "Motocycle",
            "Bicycle"});
            this.showBy_comboBox.Location = new System.Drawing.Point(864, 18);
            this.showBy_comboBox.Name = "showBy_comboBox";
            this.showBy_comboBox.Size = new System.Drawing.Size(121, 35);
            this.showBy_comboBox.TabIndex = 27;
            this.showBy_comboBox.SelectedIndexChanged += new System.EventHandler(this.ShowBy_comboBox_SelectedIndexChanged);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.AliceBlue;
            this.delete_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.Black;
            this.delete_button.Location = new System.Drawing.Point(782, 518);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(119, 60);
            this.delete_button.TabIndex = 28;
            this.delete_button.Text = "Delete selected row";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(RentalServiceLib.Orders);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Renter";
            this.dataGridViewTextBoxColumn1.HeaderText = "Renter";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vehicle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vehicle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 101;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VehicleNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehicle number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 179;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RentDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rent date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Due date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // vehicleNumbersBindingSource
            // 
            this.vehicleNumbersBindingSource.DataSource = typeof(RentalServiceLib.VehicleNumbers);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 633);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.showBy_comboBox);
            this.Controls.Add(this.showOnly_label);
            this.Controls.Add(this.ordersExplorer_button);
            this.Controls.Add(this.vehicleNumbers_comboBox);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clearDataBase_button);
            this.Controls.Add(this.dueDate_textBox);
            this.Controls.Add(this.rentDate_textBox);
            this.Controls.Add(this.orders_dataGridView);
            this.Controls.Add(this.renter_textBox);
            this.Controls.Add(this.renter_label);
            this.Controls.Add(this.dueDate_label);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.orderstext_label);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.rentDate_label);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.vehicles_comboBox);
            this.Controls.Add(this.chooseVehicle_label);
            this.Controls.Add(this.addOrder_textBox);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders ";
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleNumbersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addOrder_textBox;
        private System.Windows.Forms.Label chooseVehicle_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label rentDate_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label orderstext_label;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Label dueDate_label;
        private System.Windows.Forms.Label renter_label;
        private System.Windows.Forms.DataGridView orders_dataGridView;
        internal System.Windows.Forms.ComboBox vehicles_comboBox;
        internal System.Windows.Forms.TextBox renter_textBox;
        internal System.Windows.Forms.TextBox rentDate_textBox;
        internal System.Windows.Forms.TextBox dueDate_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clearDataBase_button;
        private System.Windows.Forms.Button update_button;
        internal System.Windows.Forms.ComboBox vehicleNumbers_comboBox;
        private System.Windows.Forms.Button ordersExplorer_button;
        private System.Windows.Forms.Label showOnly_label;
        private System.Windows.Forms.ComboBox showBy_comboBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource vehicleNumbersBindingSource;
    }
}