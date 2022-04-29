namespace Forms
{
    partial class LoginForm
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
            this.login_groupBox = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.login_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_groupBox
            // 
            this.login_groupBox.Controls.Add(this.clear_button);
            this.login_groupBox.Controls.Add(this.login_button);
            this.login_groupBox.Controls.Add(this.password_textBox);
            this.login_groupBox.Controls.Add(this.username_textBox);
            this.login_groupBox.Controls.Add(this.password_label);
            this.login_groupBox.Controls.Add(this.username_label);
            this.login_groupBox.Location = new System.Drawing.Point(42, 70);
            this.login_groupBox.Name = "login_groupBox";
            this.login_groupBox.Size = new System.Drawing.Size(346, 208);
            this.login_groupBox.TabIndex = 0;
            this.login_groupBox.TabStop = false;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(211, 136);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(116, 52);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(12, 136);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(116, 52);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(140, 78);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(187, 33);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textBox_KeyDown);
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(140, 29);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(187, 33);
            this.username_textBox.TabIndex = 2;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(7, 73);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(93, 26);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(7, 32);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(98, 26);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(309, 302);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(116, 52);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // message_textBox
            // 
            this.message_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message_textBox.Location = new System.Drawing.Point(54, 38);
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(257, 26);
            this.message_textBox.TabIndex = 6;
            this.message_textBox.TabStop = false;
            this.message_textBox.Text = "Authorize to access data";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 366);
            this.Controls.Add(this.message_textBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_groupBox);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Service Login";
            this.login_groupBox.ResumeLayout(false);
            this.login_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox login_groupBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox message_textBox;
    }
}

