
namespace IOOPAssignment
{
    partial class Modification2
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
            this.btnRef = new System.Windows.Forms.Button();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.DTPFinal = new System.Windows.Forms.DateTimePicker();
            this.cmboxR = new System.Windows.Forms.ComboBox();
            this.cmboxRT = new System.Windows.Forms.ComboBox();
            this.lblNRT = new System.Windows.Forms.Label();
            this.lblNR = new System.Windows.Forms.Label();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblND = new System.Windows.Forms.Label();
            this.grpboxNew = new System.Windows.Forms.GroupBox();
            this.DTPInitial = new System.Windows.Forms.DateTimePicker();
            this.lblNFT = new System.Windows.Forms.Label();
            this.lblORA = new System.Windows.Forms.Label();
            this.lblDtD = new System.Windows.Forms.Label();
            this.lblDtRA = new System.Windows.Forms.Label();
            this.lblDtFT = new System.Windows.Forms.Label();
            this.lblDtIT = new System.Windows.Forms.Label();
            this.lblDtR = new System.Windows.Forms.Label();
            this.lblDtRT = new System.Windows.Forms.Label();
            this.grpboxOld = new System.Windows.Forms.GroupBox();
            this.lblORT = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblOIT = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.lblOFT = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.lblMoR = new System.Windows.Forms.Label();
            this.dGVMoR = new System.Windows.Forms.DataGridView();
            this.grpboxNew.SuspendLayout();
            this.grpboxOld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMoR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRef
            // 
            this.btnRef.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.Location = new System.Drawing.Point(683, 12);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(73, 32);
            this.btnRef.TabIndex = 22;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // DTPDate
            // 
            this.DTPDate.CustomFormat = "dd/MM/yyyy";
            this.DTPDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDate.Location = new System.Drawing.Point(551, 30);
            this.DTPDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(115, 27);
            this.DTPDate.TabIndex = 14;
            this.DTPDate.ValueChanged += new System.EventHandler(this.DTPDate_ValueChanged);
            // 
            // DTPFinal
            // 
            this.DTPFinal.CustomFormat = "HH:mm";
            this.DTPFinal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFinal.Location = new System.Drawing.Point(367, 62);
            this.DTPFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPFinal.Name = "DTPFinal";
            this.DTPFinal.ShowUpDown = true;
            this.DTPFinal.Size = new System.Drawing.Size(115, 27);
            this.DTPFinal.TabIndex = 13;
            this.DTPFinal.ValueChanged += new System.EventHandler(this.DTPFinal_ValueChanged);
            // 
            // cmboxR
            // 
            this.cmboxR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxR.FormattingEnabled = true;
            this.cmboxR.Items.AddRange(new object[] {
            "Amber1",
            "Amber2",
            "Amber3",
            "Amber4",
            "Amber5",
            "Amber6",
            "BlackThorn1",
            "BlackThorn2",
            "BlackThorn3",
            "BlackThorn4",
            "Cedar1",
            "Daphne"});
            this.cmboxR.Location = new System.Drawing.Point(109, 66);
            this.cmboxR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxR.Name = "cmboxR";
            this.cmboxR.Size = new System.Drawing.Size(140, 27);
            this.cmboxR.TabIndex = 11;
            // 
            // cmboxRT
            // 
            this.cmboxRT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxRT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxRT.FormattingEnabled = true;
            this.cmboxRT.Items.AddRange(new object[] {
            "Amber",
            "BlackThorn",
            "Cedar",
            "Daphne"});
            this.cmboxRT.Location = new System.Drawing.Point(109, 31);
            this.cmboxRT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxRT.Name = "cmboxRT";
            this.cmboxRT.Size = new System.Drawing.Size(140, 27);
            this.cmboxRT.TabIndex = 10;
            this.cmboxRT.SelectedIndexChanged += new System.EventHandler(this.cmboxRT_SelectedIndexChanged);
            this.cmboxRT.TextChanged += new System.EventHandler(this.cmboxRT_TextChanged);
            // 
            // lblNRT
            // 
            this.lblNRT.AutoSize = true;
            this.lblNRT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRT.Location = new System.Drawing.Point(11, 33);
            this.lblNRT.Name = "lblNRT";
            this.lblNRT.Size = new System.Drawing.Size(92, 19);
            this.lblNRT.TabIndex = 0;
            this.lblNRT.Text = "Room Type:";
            // 
            // lblNR
            // 
            this.lblNR.AutoSize = true;
            this.lblNR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNR.Location = new System.Drawing.Point(11, 70);
            this.lblNR.Name = "lblNR";
            this.lblNR.Size = new System.Drawing.Size(56, 19);
            this.lblNR.TabIndex = 6;
            this.lblNR.Text = "Room:";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIT.Location = new System.Drawing.Point(270, 30);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(92, 19);
            this.lblNIT.TabIndex = 7;
            this.lblNIT.Text = "Initial Time:";
            // 
            // lblND
            // 
            this.lblND.AutoSize = true;
            this.lblND.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblND.Location = new System.Drawing.Point(499, 33);
            this.lblND.Name = "lblND";
            this.lblND.Size = new System.Drawing.Size(46, 19);
            this.lblND.TabIndex = 9;
            this.lblND.Text = "Date:";
            // 
            // grpboxNew
            // 
            this.grpboxNew.Controls.Add(this.DTPDate);
            this.grpboxNew.Controls.Add(this.DTPFinal);
            this.grpboxNew.Controls.Add(this.DTPInitial);
            this.grpboxNew.Controls.Add(this.cmboxR);
            this.grpboxNew.Controls.Add(this.cmboxRT);
            this.grpboxNew.Controls.Add(this.lblNRT);
            this.grpboxNew.Controls.Add(this.lblNR);
            this.grpboxNew.Controls.Add(this.lblNIT);
            this.grpboxNew.Controls.Add(this.lblND);
            this.grpboxNew.Controls.Add(this.lblNFT);
            this.grpboxNew.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxNew.Location = new System.Drawing.Point(73, 321);
            this.grpboxNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxNew.Name = "grpboxNew";
            this.grpboxNew.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxNew.Size = new System.Drawing.Size(683, 121);
            this.grpboxNew.TabIndex = 21;
            this.grpboxNew.TabStop = false;
            this.grpboxNew.Text = "New Room Details";
            this.grpboxNew.Enter += new System.EventHandler(this.grpboxNew_Enter);
            // 
            // DTPInitial
            // 
            this.DTPInitial.CustomFormat = "HH:mm";
            this.DTPInitial.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPInitial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPInitial.Location = new System.Drawing.Point(367, 27);
            this.DTPInitial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTPInitial.Name = "DTPInitial";
            this.DTPInitial.ShowUpDown = true;
            this.DTPInitial.Size = new System.Drawing.Size(115, 27);
            this.DTPInitial.TabIndex = 12;
            this.DTPInitial.ValueChanged += new System.EventHandler(this.DTPInitial_ValueChanged);
            // 
            // lblNFT
            // 
            this.lblNFT.AutoSize = true;
            this.lblNFT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFT.Location = new System.Drawing.Point(270, 65);
            this.lblNFT.Name = "lblNFT";
            this.lblNFT.Size = new System.Drawing.Size(86, 19);
            this.lblNFT.TabIndex = 8;
            this.lblNFT.Text = "Final Time:";
            // 
            // lblORA
            // 
            this.lblORA.AutoSize = true;
            this.lblORA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblORA.Location = new System.Drawing.Point(460, 70);
            this.lblORA.Name = "lblORA";
            this.lblORA.Size = new System.Drawing.Size(118, 19);
            this.lblORA.TabIndex = 15;
            this.lblORA.Text = "RoomAvailable:";
            // 
            // lblDtD
            // 
            this.lblDtD.AutoSize = true;
            this.lblDtD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtD.Location = new System.Drawing.Point(584, 33);
            this.lblDtD.Name = "lblDtD";
            this.lblDtD.Size = new System.Drawing.Size(12, 19);
            this.lblDtD.TabIndex = 14;
            this.lblDtD.Text = "|";
            // 
            // lblDtRA
            // 
            this.lblDtRA.AutoSize = true;
            this.lblDtRA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtRA.Location = new System.Drawing.Point(584, 70);
            this.lblDtRA.Name = "lblDtRA";
            this.lblDtRA.Size = new System.Drawing.Size(12, 19);
            this.lblDtRA.TabIndex = 14;
            this.lblDtRA.Text = "|";
            this.lblDtRA.Click += new System.EventHandler(this.lblDtRA_Click);
            // 
            // lblDtFT
            // 
            this.lblDtFT.AutoSize = true;
            this.lblDtFT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFT.Location = new System.Drawing.Point(366, 70);
            this.lblDtFT.Name = "lblDtFT";
            this.lblDtFT.Size = new System.Drawing.Size(12, 19);
            this.lblDtFT.TabIndex = 13;
            this.lblDtFT.Text = "|";
            // 
            // lblDtIT
            // 
            this.lblDtIT.AutoSize = true;
            this.lblDtIT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtIT.Location = new System.Drawing.Point(366, 33);
            this.lblDtIT.Name = "lblDtIT";
            this.lblDtIT.Size = new System.Drawing.Size(12, 19);
            this.lblDtIT.TabIndex = 12;
            this.lblDtIT.Text = "|";
            // 
            // lblDtR
            // 
            this.lblDtR.AutoSize = true;
            this.lblDtR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtR.Location = new System.Drawing.Point(108, 70);
            this.lblDtR.Name = "lblDtR";
            this.lblDtR.Size = new System.Drawing.Size(12, 19);
            this.lblDtR.TabIndex = 11;
            this.lblDtR.Text = "|";
            // 
            // lblDtRT
            // 
            this.lblDtRT.AutoSize = true;
            this.lblDtRT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtRT.Location = new System.Drawing.Point(108, 33);
            this.lblDtRT.Name = "lblDtRT";
            this.lblDtRT.Size = new System.Drawing.Size(12, 19);
            this.lblDtRT.TabIndex = 10;
            this.lblDtRT.Text = "|";
            // 
            // grpboxOld
            // 
            this.grpboxOld.Controls.Add(this.lblORA);
            this.grpboxOld.Controls.Add(this.lblDtD);
            this.grpboxOld.Controls.Add(this.lblDtRA);
            this.grpboxOld.Controls.Add(this.lblDtFT);
            this.grpboxOld.Controls.Add(this.lblDtIT);
            this.grpboxOld.Controls.Add(this.lblDtR);
            this.grpboxOld.Controls.Add(this.lblDtRT);
            this.grpboxOld.Controls.Add(this.lblORT);
            this.grpboxOld.Controls.Add(this.lblOR);
            this.grpboxOld.Controls.Add(this.lblOIT);
            this.grpboxOld.Controls.Add(this.lblOD);
            this.grpboxOld.Controls.Add(this.lblOFT);
            this.grpboxOld.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxOld.Location = new System.Drawing.Point(73, 192);
            this.grpboxOld.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxOld.Name = "grpboxOld";
            this.grpboxOld.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxOld.Size = new System.Drawing.Size(683, 121);
            this.grpboxOld.TabIndex = 20;
            this.grpboxOld.TabStop = false;
            this.grpboxOld.Text = "Old Room Details";
            this.grpboxOld.Enter += new System.EventHandler(this.grpboxOld_Enter);
            // 
            // lblORT
            // 
            this.lblORT.AutoSize = true;
            this.lblORT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblORT.Location = new System.Drawing.Point(10, 33);
            this.lblORT.Name = "lblORT";
            this.lblORT.Size = new System.Drawing.Size(92, 19);
            this.lblORT.TabIndex = 0;
            this.lblORT.Text = "Room Type:";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOR.Location = new System.Drawing.Point(10, 70);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(56, 19);
            this.lblOR.TabIndex = 6;
            this.lblOR.Text = "Room:";
            // 
            // lblOIT
            // 
            this.lblOIT.AutoSize = true;
            this.lblOIT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOIT.Location = new System.Drawing.Point(272, 33);
            this.lblOIT.Name = "lblOIT";
            this.lblOIT.Size = new System.Drawing.Size(92, 19);
            this.lblOIT.TabIndex = 7;
            this.lblOIT.Text = "Initial Time:";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOD.Location = new System.Drawing.Point(528, 33);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(46, 19);
            this.lblOD.TabIndex = 9;
            this.lblOD.Text = "Date:";
            // 
            // lblOFT
            // 
            this.lblOFT.AutoSize = true;
            this.lblOFT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOFT.Location = new System.Drawing.Point(271, 70);
            this.lblOFT.Name = "lblOFT";
            this.lblOFT.Size = new System.Drawing.Size(86, 19);
            this.lblOFT.TabIndex = 8;
            this.lblOFT.Text = "Final Time:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(571, 441);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 39);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(355, 441);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(91, 39);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.Location = new System.Drawing.Point(153, 441);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(83, 39);
            this.btnUpd.TabIndex = 17;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMoR
            // 
            this.lblMoR.AutoSize = true;
            this.lblMoR.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoR.Location = new System.Drawing.Point(235, 10);
            this.lblMoR.Name = "lblMoR";
            this.lblMoR.Size = new System.Drawing.Size(341, 37);
            this.lblMoR.TabIndex = 16;
            this.lblMoR.Text = "Modification of Rooms";
            // 
            // dGVMoR
            // 
            this.dGVMoR.AllowUserToAddRows = false;
            this.dGVMoR.AllowUserToDeleteRows = false;
            this.dGVMoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMoR.Location = new System.Drawing.Point(71, 51);
            this.dGVMoR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGVMoR.Name = "dGVMoR";
            this.dGVMoR.ReadOnly = true;
            this.dGVMoR.RowHeadersWidth = 51;
            this.dGVMoR.RowTemplate.Height = 24;
            this.dGVMoR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVMoR.Size = new System.Drawing.Size(685, 141);
            this.dGVMoR.TabIndex = 15;
            this.dGVMoR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMoR_CellClick);
            this.dGVMoR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMoR_CellContentClick);
            // 
            // Modification2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 489);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.grpboxNew);
            this.Controls.Add(this.grpboxOld);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.lblMoR);
            this.Controls.Add(this.dGVMoR);
            this.Name = "Modification2";
            this.Text = "Reservation2";
            this.Load += new System.EventHandler(this.Modification2_Load);
            this.grpboxNew.ResumeLayout(false);
            this.grpboxNew.PerformLayout();
            this.grpboxOld.ResumeLayout(false);
            this.grpboxOld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMoR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.DateTimePicker DTPFinal;
        private System.Windows.Forms.ComboBox cmboxR;
        private System.Windows.Forms.ComboBox cmboxRT;
        private System.Windows.Forms.Label lblNRT;
        private System.Windows.Forms.Label lblNR;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.Label lblND;
        private System.Windows.Forms.GroupBox grpboxNew;
        private System.Windows.Forms.DateTimePicker DTPInitial;
        private System.Windows.Forms.Label lblNFT;
        private System.Windows.Forms.Label lblORA;
        private System.Windows.Forms.Label lblDtD;
        private System.Windows.Forms.Label lblDtRA;
        private System.Windows.Forms.Label lblDtFT;
        private System.Windows.Forms.Label lblDtIT;
        private System.Windows.Forms.Label lblDtR;
        private System.Windows.Forms.Label lblDtRT;
        private System.Windows.Forms.GroupBox grpboxOld;
        private System.Windows.Forms.Label lblORT;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblOIT;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.Label lblOFT;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label lblMoR;
        private System.Windows.Forms.DataGridView dGVMoR;
    }
}