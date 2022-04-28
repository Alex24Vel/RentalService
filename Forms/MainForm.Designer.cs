﻿namespace Forms
{
    partial class MainForm
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
            this.exitMain_button = new System.Windows.Forms.Button();
            this.renter_button = new System.Windows.Forms.Button();
            this.database_button = new System.Windows.Forms.Button();
            this.orders_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitMain_button
            // 
            this.exitMain_button.Location = new System.Drawing.Point(246, 303);
            this.exitMain_button.Name = "exitMain_button";
            this.exitMain_button.Size = new System.Drawing.Size(167, 82);
            this.exitMain_button.TabIndex = 0;
            this.exitMain_button.Text = "Exit";
            this.exitMain_button.UseVisualStyleBackColor = true;
            this.exitMain_button.Click += new System.EventHandler(this.exitMain_button_Click);
            // 
            // renter_button
            // 
            this.renter_button.Location = new System.Drawing.Point(27, 111);
            this.renter_button.Name = "renter_button";
            this.renter_button.Size = new System.Drawing.Size(167, 82);
            this.renter_button.TabIndex = 2;
            this.renter_button.Text = "Add renter";
            this.renter_button.UseVisualStyleBackColor = true;
            this.renter_button.Click += new System.EventHandler(this.renter_button_Click);
            // 
            // database_button
            // 
            this.database_button.Location = new System.Drawing.Point(27, 303);
            this.database_button.Name = "database_button";
            this.database_button.Size = new System.Drawing.Size(167, 82);
            this.database_button.TabIndex = 4;
            this.database_button.Text = "Vehicle database";
            this.database_button.UseVisualStyleBackColor = true;
            this.database_button.Click += new System.EventHandler(this.database_button_Click);
            // 
            // orders_button
            // 
            this.orders_button.Location = new System.Drawing.Point(246, 111);
            this.orders_button.Name = "orders_button";
            this.orders_button.Size = new System.Drawing.Size(167, 82);
            this.orders_button.TabIndex = 5;
            this.orders_button.Text = "View current rental orders";
            this.orders_button.UseVisualStyleBackColor = true;
            this.orders_button.Click += new System.EventHandler(this.orders_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 473);
            this.Controls.Add(this.orders_button);
            this.Controls.Add(this.database_button);
            this.Controls.Add(this.renter_button);
            this.Controls.Add(this.exitMain_button);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitMain_button;
        private System.Windows.Forms.Button renter_button;
        private System.Windows.Forms.Button database_button;
        private System.Windows.Forms.Button orders_button;
    }
}