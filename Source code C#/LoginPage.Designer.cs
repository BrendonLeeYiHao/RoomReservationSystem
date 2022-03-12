
namespace IOOPAssignment
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.GroupUserType = new System.Windows.Forms.GroupBox();
            this.radioLibrarian = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.GroupUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.BackgroundImage")));
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.Location = new System.Drawing.Point(579, 32);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(208, 184);
            this.PictureBox.TabIndex = 17;
            this.PictureBox.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(431, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 40);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPass.Location = new System.Drawing.Point(228, 316);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(193, 30);
            this.TextBoxPass.TabIndex = 14;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.Location = new System.Drawing.Point(228, 245);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(193, 30);
            this.TextBoxUser.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(100, 318);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(96, 248);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 25);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username :";
            // 
            // GroupUserType
            // 
            this.GroupUserType.Controls.Add(this.radioLibrarian);
            this.GroupUserType.Controls.Add(this.radioStudent);
            this.GroupUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupUserType.Location = new System.Drawing.Point(100, 99);
            this.GroupUserType.Name = "GroupUserType";
            this.GroupUserType.Size = new System.Drawing.Size(200, 117);
            this.GroupUserType.TabIndex = 11;
            this.GroupUserType.TabStop = false;
            this.GroupUserType.Text = "UserType";
            // 
            // radioLibrarian
            // 
            this.radioLibrarian.AutoSize = true;
            this.radioLibrarian.Location = new System.Drawing.Point(6, 65);
            this.radioLibrarian.Name = "radioLibrarian";
            this.radioLibrarian.Size = new System.Drawing.Size(128, 33);
            this.radioLibrarian.TabIndex = 4;
            this.radioLibrarian.Text = "Librarian";
            this.radioLibrarian.UseVisualStyleBackColor = true;
            this.radioLibrarian.CheckedChanged += new System.EventHandler(this.radioLibrarian_CheckedChanged);
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Checked = true;
            this.radioStudent.Location = new System.Drawing.Point(6, 38);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(116, 33);
            this.radioStudent.TabIndex = 4;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            this.radioStudent.CheckedChanged += new System.EventHandler(this.radioStudent_CheckedChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(14, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(490, 38);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "WELCOME TO APU LIBRARY";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(636, 385);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 40);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.GroupUserType);
            this.Controls.Add(this.lblWelcome);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.GroupUserType.ResumeLayout(false);
            this.GroupUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox GroupUserType;
        private System.Windows.Forms.RadioButton radioLibrarian;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRegister;
    }
}