namespace LockerApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locker Application";
            // 
            // UsernameLb
            // 
            this.UsernameLb.AutoSize = true;
            this.UsernameLb.Location = new System.Drawing.Point(49, 145);
            this.UsernameLb.Name = "UsernameLb";
            this.UsernameLb.Size = new System.Drawing.Size(60, 15);
            this.UsernameLb.TabIndex = 1;
            this.UsernameLb.Text = "Username";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(49, 200);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(57, 15);
            this.PasswordLb.TabIndex = 2;
            this.PasswordLb.Text = "Password";
            // 
            // UsernameTb
            // 
            this.UsernameTb.Location = new System.Drawing.Point(179, 142);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(164, 23);
            this.UsernameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(179, 192);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(164, 23);
            this.PasswordTb.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(447, 142);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 30);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(447, 185);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(150, 30);
            this.EnterButton.TabIndex = 6;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.UsernameLb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label UsernameLb;
        private Label PasswordLb;
        private TextBox UsernameTb;
        private TextBox PasswordTb;
        private Button SaveButton;
        private Button EnterButton;
    }
}