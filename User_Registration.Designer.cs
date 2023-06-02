namespace Question2
{
    partial class User_Registration
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
            this.id_lbl = new System.Windows.Forms.Label();
            this.fn_lbl = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.fn_txt = new System.Windows.Forms.TextBox();
            this.ln_lbl = new System.Windows.Forms.Label();
            this.ln_txt = new System.Windows.Forms.TextBox();
            this.dpt_lbl = new System.Windows.Forms.Label();
            this.dpt_txt = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.psw_lbl = new System.Windows.Forms.Label();
            this.psw_txt = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.phone_error = new System.Windows.Forms.Label();
            this.email_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(142, 83);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(70, 13);
            this.id_lbl.TabIndex = 0;
            this.id_lbl.Text = "Employee ID:";
            // 
            // fn_lbl
            // 
            this.fn_lbl.AutoSize = true;
            this.fn_lbl.Location = new System.Drawing.Point(142, 119);
            this.fn_lbl.Name = "fn_lbl";
            this.fn_lbl.Size = new System.Drawing.Size(60, 13);
            this.fn_lbl.TabIndex = 1;
            this.fn_lbl.Text = "First Name:";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(229, 80);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(166, 20);
            this.id_txt.TabIndex = 2;
            // 
            // fn_txt
            // 
            this.fn_txt.Location = new System.Drawing.Point(229, 119);
            this.fn_txt.Name = "fn_txt";
            this.fn_txt.Size = new System.Drawing.Size(166, 20);
            this.fn_txt.TabIndex = 3;
            // 
            // ln_lbl
            // 
            this.ln_lbl.AutoSize = true;
            this.ln_lbl.Location = new System.Drawing.Point(142, 161);
            this.ln_lbl.Name = "ln_lbl";
            this.ln_lbl.Size = new System.Drawing.Size(61, 13);
            this.ln_lbl.TabIndex = 4;
            this.ln_lbl.Text = "Last Name:";
            // 
            // ln_txt
            // 
            this.ln_txt.Location = new System.Drawing.Point(229, 161);
            this.ln_txt.Name = "ln_txt";
            this.ln_txt.Size = new System.Drawing.Size(166, 20);
            this.ln_txt.TabIndex = 5;
            // 
            // dpt_lbl
            // 
            this.dpt_lbl.AutoSize = true;
            this.dpt_lbl.Location = new System.Drawing.Point(142, 201);
            this.dpt_lbl.Name = "dpt_lbl";
            this.dpt_lbl.Size = new System.Drawing.Size(65, 13);
            this.dpt_lbl.TabIndex = 6;
            this.dpt_lbl.Text = "Department:";
            // 
            // dpt_txt
            // 
            this.dpt_txt.Location = new System.Drawing.Point(229, 201);
            this.dpt_txt.Name = "dpt_txt";
            this.dpt_txt.Size = new System.Drawing.Size(166, 20);
            this.dpt_txt.TabIndex = 7;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(142, 241);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(81, 13);
            this.phone_lbl.TabIndex = 8;
            this.phone_lbl.Text = "Phone Number:";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(229, 238);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(166, 20);
            this.phone_txt.TabIndex = 9;
            this.phone_txt.TextChanged += new System.EventHandler(this.phone_txt_TextChanged);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(127, 302);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(96, 13);
            this.email_lbl.TabIndex = 10;
            this.email_lbl.Text = "User Name (email):";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(229, 299);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(166, 20);
            this.email_txt.TabIndex = 11;
            this.email_txt.TextChanged += new System.EventHandler(this.email_txt_TextChanged);
            // 
            // psw_lbl
            // 
            this.psw_lbl.AutoSize = true;
            this.psw_lbl.Location = new System.Drawing.Point(142, 361);
            this.psw_lbl.Name = "psw_lbl";
            this.psw_lbl.Size = new System.Drawing.Size(56, 13);
            this.psw_lbl.TabIndex = 12;
            this.psw_lbl.Text = "Password:";
            // 
            // psw_txt
            // 
            this.psw_txt.Location = new System.Drawing.Point(229, 358);
            this.psw_txt.Name = "psw_txt";
            this.psw_txt.Size = new System.Drawing.Size(166, 20);
            this.psw_txt.TabIndex = 13;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(145, 408);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(75, 23);
            this.reg_btn.TabIndex = 14;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // phone_error
            // 
            this.phone_error.AutoSize = true;
            this.phone_error.ForeColor = System.Drawing.Color.Red;
            this.phone_error.Location = new System.Drawing.Point(254, 270);
            this.phone_error.Name = "phone_error";
            this.phone_error.Size = new System.Drawing.Size(112, 13);
            this.phone_error.TabIndex = 15;
            this.phone_error.Text = "Invalid Phone Number";
            this.phone_error.Visible = false;
            // 
            // email_error
            // 
            this.email_error.AutoSize = true;
            this.email_error.ForeColor = System.Drawing.Color.Red;
            this.email_error.Location = new System.Drawing.Point(274, 331);
            this.email_error.Name = "email_error";
            this.email_error.Size = new System.Drawing.Size(66, 13);
            this.email_error.TabIndex = 16;
            this.email_error.Text = "Invalid Email";
            this.email_error.Visible = false;
            // 
            // User_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 481);
            this.Controls.Add(this.email_error);
            this.Controls.Add(this.phone_error);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.psw_txt);
            this.Controls.Add(this.psw_lbl);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.dpt_txt);
            this.Controls.Add(this.dpt_lbl);
            this.Controls.Add(this.ln_txt);
            this.Controls.Add(this.ln_lbl);
            this.Controls.Add(this.fn_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.fn_lbl);
            this.Controls.Add(this.id_lbl);
            this.Name = "User_Registration";
            this.Text = "User_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label fn_lbl;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox fn_txt;
        private System.Windows.Forms.Label ln_lbl;
        private System.Windows.Forms.TextBox ln_txt;
        private System.Windows.Forms.Label dpt_lbl;
        private System.Windows.Forms.TextBox dpt_txt;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label psw_lbl;
        private System.Windows.Forms.TextBox psw_txt;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label phone_error;
        private System.Windows.Forms.Label email_error;
    }
}