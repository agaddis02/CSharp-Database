namespace Lab_Assignment_5_4
{
    partial class frmPublishers
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
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPubAddress = new System.Windows.Forms.TextBox();
            this.txtPubCity = new System.Windows.Forms.TextBox();
            this.txtPubState = new System.Windows.Forms.TextBox();
            this.txtPubZip = new System.Windows.Forms.TextBox();
            this.txtPubTelephone = new System.Windows.Forms.TextBox();
            this.txtPubFAX = new System.Windows.Forms.TextBox();
            this.txtPubComments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(573, 415);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 41;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Do&ne";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(474, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(372, 415);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 39;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(573, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(474, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(372, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 35;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(280, 364);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 34;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Publisher ID";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(280, 94);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 30;
            // 
            // txtPubName
            // 
            this.txtPubName.BackColor = System.Drawing.Color.White;
            this.txtPubName.Location = new System.Drawing.Point(280, 45);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.ReadOnly = true;
            this.txtPubName.Size = new System.Drawing.Size(100, 20);
            this.txtPubName.TabIndex = 29;
            // 
            // txtPubID
            // 
            this.txtPubID.BackColor = System.Drawing.Color.White;
            this.txtPubID.Location = new System.Drawing.Point(280, 2);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.ReadOnly = true;
            this.txtPubID.Size = new System.Drawing.Size(100, 20);
            this.txtPubID.TabIndex = 28;
            this.txtPubID.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Zip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "FAX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Comments";
            // 
            // txtPubAddress
            // 
            this.txtPubAddress.BackColor = System.Drawing.Color.White;
            this.txtPubAddress.Location = new System.Drawing.Point(280, 131);
            this.txtPubAddress.Name = "txtPubAddress";
            this.txtPubAddress.ReadOnly = true;
            this.txtPubAddress.Size = new System.Drawing.Size(100, 20);
            this.txtPubAddress.TabIndex = 3;
            // 
            // txtPubCity
            // 
            this.txtPubCity.BackColor = System.Drawing.Color.White;
            this.txtPubCity.Location = new System.Drawing.Point(280, 161);
            this.txtPubCity.Name = "txtPubCity";
            this.txtPubCity.ReadOnly = true;
            this.txtPubCity.Size = new System.Drawing.Size(100, 20);
            this.txtPubCity.TabIndex = 4;
            // 
            // txtPubState
            // 
            this.txtPubState.BackColor = System.Drawing.Color.White;
            this.txtPubState.Location = new System.Drawing.Point(280, 193);
            this.txtPubState.Name = "txtPubState";
            this.txtPubState.ReadOnly = true;
            this.txtPubState.Size = new System.Drawing.Size(100, 20);
            this.txtPubState.TabIndex = 5;
            // 
            // txtPubZip
            // 
            this.txtPubZip.BackColor = System.Drawing.Color.White;
            this.txtPubZip.Location = new System.Drawing.Point(280, 223);
            this.txtPubZip.Name = "txtPubZip";
            this.txtPubZip.ReadOnly = true;
            this.txtPubZip.Size = new System.Drawing.Size(100, 20);
            this.txtPubZip.TabIndex = 6;
            // 
            // txtPubTelephone
            // 
            this.txtPubTelephone.BackColor = System.Drawing.Color.White;
            this.txtPubTelephone.Location = new System.Drawing.Point(280, 253);
            this.txtPubTelephone.Name = "txtPubTelephone";
            this.txtPubTelephone.ReadOnly = true;
            this.txtPubTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtPubTelephone.TabIndex = 7;
            // 
            // txtPubFAX
            // 
            this.txtPubFAX.BackColor = System.Drawing.Color.White;
            this.txtPubFAX.Location = new System.Drawing.Point(280, 287);
            this.txtPubFAX.Name = "txtPubFAX";
            this.txtPubFAX.ReadOnly = true;
            this.txtPubFAX.Size = new System.Drawing.Size(100, 20);
            this.txtPubFAX.TabIndex = 8;
            // 
            // txtPubComments
            // 
            this.txtPubComments.BackColor = System.Drawing.Color.White;
            this.txtPubComments.Location = new System.Drawing.Point(280, 319);
            this.txtPubComments.Name = "txtPubComments";
            this.txtPubComments.ReadOnly = true;
            this.txtPubComments.Size = new System.Drawing.Size(100, 20);
            this.txtPubComments.TabIndex = 9;
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPubComments);
            this.Controls.Add(this.txtPubFAX);
            this.Controls.Add(this.txtPubTelephone);
            this.Controls.Add(this.txtPubZip);
            this.Controls.Add(this.txtPubState);
            this.Controls.Add(this.txtPubCity);
            this.Controls.Add(this.txtPubAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.txtPubID);
            this.Name = "frmPublishers";
            this.Text = "Publishers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPublishers_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPubAddress;
        private System.Windows.Forms.TextBox txtPubCity;
        private System.Windows.Forms.TextBox txtPubState;
        private System.Windows.Forms.TextBox txtPubZip;
        private System.Windows.Forms.TextBox txtPubTelephone;
        private System.Windows.Forms.TextBox txtPubFAX;
        private System.Windows.Forms.TextBox txtPubComments;
    }
}

