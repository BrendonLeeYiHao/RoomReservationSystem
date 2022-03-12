
namespace IOOPAssignment
{
    partial class LibrarianPage
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnViewMonthly = new System.Windows.Forms.Button();
            this.btnViewDaily = new System.Windows.Forms.Button();
            this.lblFunctions = new System.Windows.Forms.Label();
            this.lblHelloLibrarian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(648, 48);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 40);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(178, 405);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(464, 74);
            this.btnRequest.TabIndex = 6;
            this.btnRequest.Text = "Approve / Reject Change Room Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnViewMonthly
            // 
            this.btnViewMonthly.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMonthly.Location = new System.Drawing.Point(178, 300);
            this.btnViewMonthly.Name = "btnViewMonthly";
            this.btnViewMonthly.Size = new System.Drawing.Size(464, 72);
            this.btnViewMonthly.TabIndex = 7;
            this.btnViewMonthly.Text = "View Monthly Room Utilization Report";
            this.btnViewMonthly.UseVisualStyleBackColor = true;
            this.btnViewMonthly.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnViewDaily
            // 
            this.btnViewDaily.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDaily.Location = new System.Drawing.Point(178, 196);
            this.btnViewDaily.Name = "btnViewDaily";
            this.btnViewDaily.Size = new System.Drawing.Size(464, 72);
            this.btnViewDaily.TabIndex = 8;
            this.btnViewDaily.Text = "View Daily Reservation Report";
            this.btnViewDaily.UseVisualStyleBackColor = true;
            this.btnViewDaily.Click += new System.EventHandler(this.btnViewDaily_Click);
            // 
            // lblFunctions
            // 
            this.lblFunctions.AutoSize = true;
            this.lblFunctions.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctions.Location = new System.Drawing.Point(124, 120);
            this.lblFunctions.Name = "lblFunctions";
            this.lblFunctions.Size = new System.Drawing.Size(582, 39);
            this.lblFunctions.TabIndex = 5;
            this.lblFunctions.Text = "Your Respective Functions are as below :";
            // 
            // lblHelloLibrarian
            // 
            this.lblHelloLibrarian.AutoSize = true;
            this.lblHelloLibrarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloLibrarian.Location = new System.Drawing.Point(236, 50);
            this.lblHelloLibrarian.Name = "lblHelloLibrarian";
            this.lblHelloLibrarian.Size = new System.Drawing.Size(0, 38);
            this.lblHelloLibrarian.TabIndex = 4;
            // 
            // LibrarianPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnViewMonthly);
            this.Controls.Add(this.btnViewDaily);
            this.Controls.Add(this.lblFunctions);
            this.Controls.Add(this.lblHelloLibrarian);
            this.Name = "LibrarianPage";
            this.Text = "LibrarianPage";
            this.Load += new System.EventHandler(this.LibrarianPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnViewMonthly;
        private System.Windows.Forms.Button btnViewDaily;
        private System.Windows.Forms.Label lblFunctions;
        private System.Windows.Forms.Label lblHelloLibrarian;
    }
}