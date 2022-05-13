namespace Forms
{
    partial class VehiclesDataBaseForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.cars_button = new System.Windows.Forms.Button();
            this.trucks_button = new System.Windows.Forms.Button();
            this.motocycles_button = new System.Windows.Forms.Button();
            this.bicycles_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.AliceBlue;
            this.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(394, 285);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(98, 57);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // cars_button
            // 
            this.cars_button.BackColor = System.Drawing.Color.AliceBlue;
            this.cars_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cars_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cars_button.Location = new System.Drawing.Point(39, 65);
            this.cars_button.Name = "cars_button";
            this.cars_button.Size = new System.Drawing.Size(214, 79);
            this.cars_button.TabIndex = 1;
            this.cars_button.Text = "Cars database";
            this.cars_button.UseVisualStyleBackColor = false;
            this.cars_button.Click += new System.EventHandler(this.cars_button_Click);
            // 
            // trucks_button
            // 
            this.trucks_button.BackColor = System.Drawing.Color.AliceBlue;
            this.trucks_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.trucks_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trucks_button.Location = new System.Drawing.Point(259, 65);
            this.trucks_button.Name = "trucks_button";
            this.trucks_button.Size = new System.Drawing.Size(214, 79);
            this.trucks_button.TabIndex = 2;
            this.trucks_button.Text = "Trucks database";
            this.trucks_button.UseVisualStyleBackColor = false;
            this.trucks_button.Click += new System.EventHandler(this.trucks_button_Click);
            // 
            // motocycles_button
            // 
            this.motocycles_button.BackColor = System.Drawing.Color.AliceBlue;
            this.motocycles_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.motocycles_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motocycles_button.Location = new System.Drawing.Point(37, 165);
            this.motocycles_button.Name = "motocycles_button";
            this.motocycles_button.Size = new System.Drawing.Size(216, 79);
            this.motocycles_button.TabIndex = 3;
            this.motocycles_button.Text = "Motocycles database";
            this.motocycles_button.UseVisualStyleBackColor = false;
            this.motocycles_button.Click += new System.EventHandler(this.motocycles_button_Click);
            // 
            // bicycles_button
            // 
            this.bicycles_button.BackColor = System.Drawing.Color.AliceBlue;
            this.bicycles_button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bicycles_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bicycles_button.Location = new System.Drawing.Point(259, 165);
            this.bicycles_button.Name = "bicycles_button";
            this.bicycles_button.Size = new System.Drawing.Size(216, 79);
            this.bicycles_button.TabIndex = 4;
            this.bicycles_button.Text = "Bicycles database";
            this.bicycles_button.UseVisualStyleBackColor = false;
            this.bicycles_button.Click += new System.EventHandler(this.bicycles_button_Click);
            // 
            // VehiclesDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(506, 357);
            this.Controls.Add(this.bicycles_button);
            this.Controls.Add(this.motocycles_button);
            this.Controls.Add(this.trucks_button);
            this.Controls.Add(this.cars_button);
            this.Controls.Add(this.cancel_button);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "VehiclesDataBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehiclesDataBaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button cars_button;
        private System.Windows.Forms.Button trucks_button;
        private System.Windows.Forms.Button motocycles_button;
        private System.Windows.Forms.Button bicycles_button;
    }
}