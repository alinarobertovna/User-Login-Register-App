namespace Question2
{
    partial class Login
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
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.psw_txt = new System.Windows.Forms.TextBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(123, 95);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(58, 13);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(125, 136);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(56, 13);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password:";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(189, 92);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(140, 20);
            this.username_txt.TabIndex = 2;
            // 
            // psw_txt
            // 
            this.psw_txt.Location = new System.Drawing.Point(189, 136);
            this.psw_txt.Name = "psw_txt";
            this.psw_txt.Size = new System.Drawing.Size(140, 20);
            this.psw_txt.TabIndex = 3;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(108, 197);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(88, 26);
            this.new_btn.TabIndex = 4;
            this.new_btn.Text = "New User?";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(276, 197);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(88, 26);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 279);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.psw_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox psw_txt;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button login_btn;
    }
}

