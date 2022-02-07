
namespace SqlApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sign_in_label = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.userSurname = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 99);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // Exit
            // 
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(598, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(20, 20);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 8;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(168)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.Sign_in_label);
            this.panel1.Controls.Add(this.userPass);
            this.panel1.Controls.Add(this.userLogin);
            this.panel1.Controls.Add(this.userSurname);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.button_register);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 380);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Sign_in_label
            // 
            this.Sign_in_label.AutoSize = true;
            this.Sign_in_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_in_label.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sign_in_label.Location = new System.Drawing.Point(264, 349);
            this.Sign_in_label.Name = "Sign_in_label";
            this.Sign_in_label.Size = new System.Drawing.Size(66, 19);
            this.Sign_in_label.TabIndex = 11;
            this.Sign_in_label.Text = "Sign in";
            this.Sign_in_label.Click += new System.EventHandler(this.Sign_in_label_Click);
            // 
            // userPass
            // 
            this.userPass.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPass.Location = new System.Drawing.Point(312, 195);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(294, 41);
            this.userPass.TabIndex = 10;
            this.userPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userPass.UseSystemPasswordChar = true;
            this.userPass.Enter += new System.EventHandler(this.userPass_Enter);
            this.userPass.Leave += new System.EventHandler(this.userPass_Leave);
            // 
            // userLogin
            // 
            this.userLogin.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLogin.Location = new System.Drawing.Point(12, 195);
            this.userLogin.Multiline = true;
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(294, 49);
            this.userLogin.TabIndex = 9;
            this.userLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userLogin.Enter += new System.EventHandler(this.userLogin_Enter);
            this.userLogin.Leave += new System.EventHandler(this.userLogin_Leave);
            // 
            // userSurname
            // 
            this.userSurname.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSurname.Location = new System.Drawing.Point(312, 129);
            this.userSurname.Multiline = true;
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(294, 49);
            this.userSurname.TabIndex = 7;
            this.userSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userSurname.Enter += new System.EventHandler(this.userSurname_Enter);
            this.userSurname.Leave += new System.EventHandler(this.userSurname_Leave);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.Window;
            this.userName.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(12, 129);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(294, 49);
            this.userName.TabIndex = 6;
            this.userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(252)))), ((int)(((byte)(111)))));
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(252)))), ((int)(((byte)(127)))));
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_register.Location = new System.Drawing.Point(220, 296);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(155, 41);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Sign up";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userSurname;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.Label Sign_in_label;
        private System.Windows.Forms.PictureBox Exit;
    }
}