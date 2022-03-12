
namespace IOOPAssignment
{
    partial class StudentPage
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangeCancel = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblHelloUser = new System.Windows.Forms.Label();
            this.btnViewSelf = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(665, 37);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(106, 44);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChangeCancel
            // 
            this.btnChangeCancel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCancel.Location = new System.Drawing.Point(245, 345);
            this.btnChangeCancel.Name = "btnChangeCancel";
            this.btnChangeCancel.Size = new System.Drawing.Size(314, 75);
            this.btnChangeCancel.TabIndex = 8;
            this.btnChangeCancel.Text = "Change / Cancel Reserved Room";
            this.btnChangeCancel.UseVisualStyleBackColor = true;
            this.btnChangeCancel.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(245, 186);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(314, 44);
            this.btnReserve.TabIndex = 9;
            this.btnReserve.Text = "Reserve Room";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(164, 101);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(506, 39);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "Choose One from the Given Options";
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.AutoSize = true;
            this.lblHelloUser.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloUser.Location = new System.Drawing.Point(239, 37);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(0, 35);
            this.lblHelloUser.TabIndex = 4;
            this.lblHelloUser.Click += new System.EventHandler(this.lblHelloUser_Click);
            // 
            // btnViewSelf
            // 
            this.btnViewSelf.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSelf.Location = new System.Drawing.Point(245, 265);
            this.btnViewSelf.Name = "btnViewSelf";
            this.btnViewSelf.Size = new System.Drawing.Size(314, 46);
            this.btnViewSelf.TabIndex = 12;
            this.btnViewSelf.Text = "View Self Reserved Room";
            this.btnViewSelf.UseVisualStyleBackColor = true;
            this.btnViewSelf.Click += new System.EventHandler(this.btnViewOwn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(245, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(314, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Personal Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnViewSelf);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChangeCancel);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblHelloUser);
            this.Name = "StudentPage";
            this.Text = "StudentPage";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangeCancel;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblHelloUser;
        private System.Windows.Forms.Button btnViewSelf;
        private System.Windows.Forms.Button btnUpdate;
    }
}