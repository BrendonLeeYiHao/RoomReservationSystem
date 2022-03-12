
namespace IOOPAssignment
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.lblROR = new System.Windows.Forms.Label();
            this.DTPInitial = new System.Windows.Forms.DateTimePicker();
            this.DTPFinal = new System.Windows.Forms.DateTimePicker();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DTPsearchdate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblsearchdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(540, 424);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 20);
            this.lblDate.TabIndex = 75;
            this.lblDate.Text = "Date:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(678, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 36);
            this.btnBack.TabIndex = 74;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(655, 470);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 36);
            this.btnConfirm.TabIndex = 72;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(499, 361);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(92, 20);
            this.lblFinal.TabIndex = 69;
            this.lblFinal.Text = "Final Time:";
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitial.Location = new System.Drawing.Point(498, 307);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(95, 20);
            this.lblInitial.TabIndex = 68;
            this.lblInitial.Text = "Initial Time:";
            // 
            // DTPDate
            // 
            this.DTPDate.CustomFormat = "dd/MM/yyyy";
            this.DTPDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPDate.Location = new System.Drawing.Point(608, 418);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(154, 27);
            this.DTPDate.TabIndex = 67;
            this.DTPDate.ValueChanged += new System.EventHandler(this.DTPDate_ValueChanged);
            // 
            // lblROR
            // 
            this.lblROR.AutoSize = true;
            this.lblROR.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROR.Location = new System.Drawing.Point(248, 12);
            this.lblROR.Name = "lblROR";
            this.lblROR.Size = new System.Drawing.Size(280, 37);
            this.lblROR.TabIndex = 65;
            this.lblROR.Text = "Room Reservation";
            // 
            // DTPInitial
            // 
            this.DTPInitial.CustomFormat = "HH:mm";
            this.DTPInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPInitial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPInitial.Location = new System.Drawing.Point(608, 305);
            this.DTPInitial.Name = "DTPInitial";
            this.DTPInitial.ShowUpDown = true;
            this.DTPInitial.Size = new System.Drawing.Size(154, 27);
            this.DTPInitial.TabIndex = 77;
            this.DTPInitial.ValueChanged += new System.EventHandler(this.DTPInitial_ValueChanged);
            // 
            // DTPFinal
            // 
            this.DTPFinal.CustomFormat = "HH:mm";
            this.DTPFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFinal.Location = new System.Drawing.Point(608, 361);
            this.DTPFinal.Name = "DTPFinal";
            this.DTPFinal.ShowUpDown = true;
            this.DTPFinal.Size = new System.Drawing.Size(154, 27);
            this.DTPFinal.TabIndex = 78;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "Amber1",
            "Amber2",
            "Amber3",
            "Amber4",
            "Amber5",
            "BlackThorn1",
            "BlackThorn2",
            "BlackThorn3",
            "BlackThorn4",
            "Cedar1",
            "Cedar2",
            "Cedar3",
            "Cedar4",
            "Cedar5",
            "Cedar6",
            "Daphne1",
            "Daphne2",
            "Daphne3",
            "Daphne4",
            "Daphne5"});
            this.cmbRoom.Location = new System.Drawing.Point(608, 252);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(154, 28);
            this.cmbRoom.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Room:";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Amber",
            "BlackThorn",
            "Cedar",
            "Daphne"});
            this.cmbRoomType.Location = new System.Drawing.Point(608, 195);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(154, 28);
            this.cmbRoomType.TabIndex = 80;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "RoomType:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 112);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DTPsearchdate
            // 
            this.DTPsearchdate.CustomFormat = "dd/MM/yyyy";
            this.DTPsearchdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPsearchdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPsearchdate.Location = new System.Drawing.Point(262, 193);
            this.DTPsearchdate.Name = "DTPsearchdate";
            this.DTPsearchdate.Size = new System.Drawing.Size(151, 27);
            this.DTPsearchdate.TabIndex = 91;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(173, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 33);
            this.btnSearch.TabIndex = 90;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblsearchdate
            // 
            this.lblsearchdate.AutoSize = true;
            this.lblsearchdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchdate.Location = new System.Drawing.Point(38, 195);
            this.lblsearchdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearchdate.Name = "lblsearchdate";
            this.lblsearchdate.Size = new System.Drawing.Size(200, 20);
            this.lblsearchdate.TabIndex = 89;
            this.lblsearchdate.Text = "Enter Date (dd/mm/yyyy):";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 518);
            this.Controls.Add(this.DTPsearchdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblsearchdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPFinal);
            this.Controls.Add(this.DTPInitial);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.lblROR);
            this.Name = "Reservation";
            this.Text = "Student Room Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.Label lblROR;
        private System.Windows.Forms.DateTimePicker DTPInitial;
        private System.Windows.Forms.DateTimePicker DTPFinal;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTPsearchdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblsearchdate;
    }
}