namespace HostelManagement
{
    partial class hostel_btn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hostel_btn));
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.txtBoxRoomNo = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtBoxNoBeds = new System.Windows.Forms.TextBox();
            this.lblNoBeds = new System.Windows.Forms.Label();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRoom_id = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Navy;
            this.lbl_roomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.Color.Snow;
            this.lbl_roomNo.Location = new System.Drawing.Point(49, 114);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(133, 20);
            this.lbl_roomNo.TabIndex = 0;
            this.lbl_roomNo.Text = "Room Number: ";
            this.lbl_roomNo.Click += new System.EventHandler(this.lbl_roomNo_Click);
            // 
            // txtBoxRoomNo
            // 
            this.txtBoxRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRoomNo.Location = new System.Drawing.Point(200, 108);
            this.txtBoxRoomNo.Name = "txtBoxRoomNo";
            this.txtBoxRoomNo.Size = new System.Drawing.Size(193, 26);
            this.txtBoxRoomNo.TabIndex = 1;
            this.txtBoxRoomNo.TextChanged += new System.EventHandler(this.txtBoxRoomNo_TextChanged);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Navy;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.White;
            this.lblRoomType.Location = new System.Drawing.Point(49, 167);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(105, 20);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Room type: ";
            this.lblRoomType.Click += new System.EventHandler(this.lblRoomType_Click);
            // 
            // txtBoxNoBeds
            // 
            this.txtBoxNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNoBeds.Location = new System.Drawing.Point(200, 214);
            this.txtBoxNoBeds.Name = "txtBoxNoBeds";
            this.txtBoxNoBeds.Size = new System.Drawing.Size(193, 26);
            this.txtBoxNoBeds.TabIndex = 5;
            this.txtBoxNoBeds.TextChanged += new System.EventHandler(this.txtBoxNoBeds_TextChanged);
            // 
            // lblNoBeds
            // 
            this.lblNoBeds.AutoSize = true;
            this.lblNoBeds.BackColor = System.Drawing.Color.Navy;
            this.lblNoBeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBeds.ForeColor = System.Drawing.Color.White;
            this.lblNoBeds.Location = new System.Drawing.Point(49, 220);
            this.lblNoBeds.Name = "lblNoBeds";
            this.lblNoBeds.Size = new System.Drawing.Size(148, 20);
            this.lblNoBeds.TabIndex = 4;
            this.lblNoBeds.Text = "Number of Beds: ";
            this.lblNoBeds.Click += new System.EventHandler(this.lblNoBeds_Click);
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDesc.Location = new System.Drawing.Point(200, 317);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(193, 105);
            this.txtBoxDesc.TabIndex = 9;
            this.txtBoxDesc.TextChanged += new System.EventHandler(this.txtBoxDesc_TextChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Navy;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(49, 323);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(110, 20);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Description: ";
            this.lblDesc.Click += new System.EventHandler(this.lblDesc_Click);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrice.Location = new System.Drawing.Point(200, 264);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(193, 26);
            this.txtBoxPrice.TabIndex = 7;
            this.txtBoxPrice.TextChanged += new System.EventHandler(this.txtBoxPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Navy;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(49, 270);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price: ";
            this.lblPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Non - AC",
            "AC"});
            this.cmbRoomType.Location = new System.Drawing.Point(200, 164);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(193, 28);
            this.cmbRoomType.TabIndex = 12;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 570);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(487, 90);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.Size = new System.Drawing.Size(475, 441);
            this.dgvRoomList.TabIndex = 14;
            this.dgvRoomList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomList_CellContentClick);
            this.dgvRoomList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRoomList_RowHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Navy;
            this.lblSearch.Location = new System.Drawing.Point(484, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(51, 16);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(487, 52);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(475, 26);
            this.txtBoxSearch.TabIndex = 16;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(-1, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 99);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(116, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 99);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDelete.Location = new System.Drawing.Point(232, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 99);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Navy;
            this.btnClear.Location = new System.Drawing.Point(348, 467);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 99);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-1, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 10);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxRoom_id
            // 
            this.txtBoxRoom_id.BackColor = System.Drawing.Color.Navy;
            this.txtBoxRoom_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRoom_id.ForeColor = System.Drawing.Color.Navy;
            this.txtBoxRoom_id.HideSelection = false;
            this.txtBoxRoom_id.Location = new System.Drawing.Point(216, 90);
            this.txtBoxRoom_id.Name = "txtBoxRoom_id";
            this.txtBoxRoom_id.ReadOnly = true;
            this.txtBoxRoom_id.Size = new System.Drawing.Size(10, 13);
            this.txtBoxRoom_id.TabIndex = 23;
            this.txtBoxRoom_id.TextChanged += new System.EventHandler(this.txtBoxRoom_id_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(329, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // hostel_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvRoomList);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBoxNoBeds);
            this.Controls.Add(this.lblNoBeds);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtBoxRoomNo);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxRoom_id);
            this.MaximizeBox = false;
            this.Name = "hostel_btn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hostel Management";
            this.Load += new System.EventHandler(this.hostel_btn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.TextBox txtBoxRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtBoxNoBeds;
        private System.Windows.Forms.Label lblNoBeds;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRoom_id;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}