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
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.renterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDate_textBox = new System.Windows.Forms.TextBox();
            this.dueDate_textBox = new System.Windows.Forms.TextBox();
            this.clearDataBase_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.vehicleNumbers_comboBox = new System.Windows.Forms.ComboBox();
            this.vehicleNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersExplorer_button = new System.Windows.Forms.Button();
            this.showOnly_label = new System.Windows.Forms.Label();
            this.showBy_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleNumbersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrder_textBox
            // 
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
            this.vehicles_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "Vehicle", true));
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
            this.vehicles_comboBox.SelectedIndexChanged += new System.EventHandler(this.vehicles_comboBox_SelectedIndexChanged);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(RentalServiceLib.Orders);
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
            this.add_button.Location = new System.Drawing.Point(17, 459);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(94, 53);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(928, 564);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(82, 57);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(117, 459);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(97, 53);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
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
            this.load_button.Location = new System.Drawing.Point(271, 518);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(110, 60);
            this.load_button.TabIndex = 12;
            this.load_button.Text = "Load data";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
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
            this.orders_dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.orders_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.renterDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn,
            this.vehicleNumberDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.orders_dataGridView.DataSource = this.ordersBindingSource;
            this.orders_dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orders_dataGridView.GridColor = System.Drawing.Color.DimGray;
            this.orders_dataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.orders_dataGridView.Location = new System.Drawing.Point(271, 86);
            this.orders_dataGridView.MinimumSize = new System.Drawing.Size(0, 45);
            this.orders_dataGridView.Name = "orders_dataGridView";
            this.orders_dataGridView.ReadOnly = true;
            this.orders_dataGridView.Size = new System.Drawing.Size(741, 426);
            this.orders_dataGridView.TabIndex = 18;
            // 
            // renterDataGridViewTextBoxColumn
            // 
            this.renterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.renterDataGridViewTextBoxColumn.DataPropertyName = "Renter";
            this.renterDataGridViewTextBoxColumn.HeaderText = "Renter";
            this.renterDataGridViewTextBoxColumn.Name = "renterDataGridViewTextBoxColumn";
            this.renterDataGridViewTextBoxColumn.ReadOnly = true;
            this.renterDataGridViewTextBoxColumn.Width = 98;
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            this.vehicleDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleDataGridViewTextBoxColumn.Width = 101;
            // 
            // vehicleNumberDataGridViewTextBoxColumn
            // 
            this.vehicleNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vehicleNumberDataGridViewTextBoxColumn.DataPropertyName = "VehicleNumber";
            this.vehicleNumberDataGridViewTextBoxColumn.HeaderText = "Vehicle number";
            this.vehicleNumberDataGridViewTextBoxColumn.Name = "vehicleNumberDataGridViewTextBoxColumn";
            this.vehicleNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleNumberDataGridViewTextBoxColumn.Width = 179;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "Rent date";
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueDateDataGridViewTextBoxColumn.Width = 120;
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
            this.clearDataBase_button.Location = new System.Drawing.Point(503, 520);
            this.clearDataBase_button.Name = "clearDataBase_button";
            this.clearDataBase_button.Size = new System.Drawing.Size(110, 60);
            this.clearDataBase_button.TabIndex = 22;
            this.clearDataBase_button.Text = "Clear ";
            this.clearDataBase_button.UseVisualStyleBackColor = true;
            this.clearDataBase_button.Click += new System.EventHandler(this.clearDataBase_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(387, 520);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(110, 60);
            this.update_button.TabIndex = 23;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
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
            // vehicleNumbersBindingSource
            // 
            this.vehicleNumbersBindingSource.DataSource = typeof(RentalServiceLib.VehicleNumbers);
            // 
            // ordersExplorer_button
            // 
            this.ordersExplorer_button.Location = new System.Drawing.Point(619, 520);
            this.ordersExplorer_button.Name = "ordersExplorer_button";
            this.ordersExplorer_button.Size = new System.Drawing.Size(154, 69);
            this.ordersExplorer_button.TabIndex = 25;
            this.ordersExplorer_button.Text = "Show orders in file explorer";
            this.ordersExplorer_button.UseVisualStyleBackColor = true;
            this.ordersExplorer_button.Click += new System.EventHandler(this.ordersExplorer_button_Click);
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
            this.showBy_comboBox.SelectedIndexChanged += new System.EventHandler(this.showBy_comboBox_SelectedIndexChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 633);
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
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orders_dataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource ordersBindingSource;
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
        private System.Windows.Forms.BindingSource vehicleNumbersBindingSource;
        private System.Windows.Forms.Button ordersExplorer_button;
        private System.Windows.Forms.Label showOnly_label;
        private System.Windows.Forms.ComboBox showBy_comboBox;
    }
}