namespace De4_Vu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvCus = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtTax = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtMail = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            ckbCus = new CheckBox();
            ckbSup = new CheckBox();
            ckbPer = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            txtLimMoney = new TextBox();
            txtLimDay = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            txtContactPerson = new TextBox();
            label9 = new Label();
            btnLoad = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCus).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 27);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCus);
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 352);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgvCus
            // 
            dgvCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCus.Dock = DockStyle.Fill;
            dgvCus.Location = new Point(3, 23);
            dgvCus.Name = "dgvCus";
            dgvCus.RowHeadersWidth = 51;
            dgvCus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCus.Size = new Size(377, 326);
            dgvCus.TabIndex = 0;
            dgvCus.CellClick += dgvCus_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(517, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(271, 27);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(517, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 27);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 60);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên khách hàng";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(517, 90);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(271, 27);
            txtTax.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 93);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã số thuế";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(517, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(271, 27);
            txtPhone.TabIndex = 8;
            txtPhone.KeyPress += txtPhone_KeyPress;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 126);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Điện thoại ";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(517, 156);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(271, 27);
            txtMail.TabIndex = 10;
            txtMail.Validating += txtMail_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 159);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Email ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(517, 189);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(271, 27);
            txtAddress.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 192);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 11;
            label6.Text = "Địa chỉ ";
            // 
            // ckbCus
            // 
            ckbCus.AutoSize = true;
            ckbCus.Location = new Point(402, 248);
            ckbCus.Name = "ckbCus";
            ckbCus.Size = new Size(125, 24);
            ckbCus.TabIndex = 14;
            ckbCus.Text = "Là khách hàng";
            ckbCus.UseVisualStyleBackColor = true;
            // 
            // ckbSup
            // 
            ckbSup.AutoSize = true;
            ckbSup.Location = new Point(533, 249);
            ckbSup.Name = "ckbSup";
            ckbSup.Size = new Size(138, 24);
            ckbSup.TabIndex = 15;
            ckbSup.Text = "Là nhà cung cấp";
            ckbSup.UseVisualStyleBackColor = true;
            // 
            // ckbPer
            // 
            ckbPer.AutoSize = true;
            ckbPer.Location = new Point(677, 249);
            ckbPer.Name = "ckbPer";
            ckbPer.Size = new Size(105, 24);
            ckbPer.TabIndex = 16;
            ckbPer.Text = "Là cá nhân ";
            ckbPer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(402, 277);
            label7.Name = "label7";
            label7.Size = new Size(199, 20);
            label7.TabIndex = 16;
            label7.Text = "Giới hạn số tiền nợ cho phép";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(402, 310);
            label8.Name = "label8";
            label8.Size = new Size(206, 20);
            label8.TabIndex = 17;
            label8.Text = "Giới hạn số ngày nợ cho phép";
            // 
            // txtLimMoney
            // 
            txtLimMoney.Location = new Point(614, 274);
            txtLimMoney.Name = "txtLimMoney";
            txtLimMoney.Size = new Size(174, 27);
            txtLimMoney.TabIndex = 17;
            txtLimMoney.TextAlign = HorizontalAlignment.Right;
            txtLimMoney.KeyPress += txtLimMoney_KeyPress;
            // 
            // txtLimDay
            // 
            txtLimDay.Location = new Point(614, 307);
            txtLimDay.Name = "txtLimDay";
            txtLimDay.Size = new Size(174, 27);
            txtLimDay.TabIndex = 19;
            txtLimDay.TextAlign = HorizontalAlignment.Right;
            txtLimDay.KeyPress += txtLimDay_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(494, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(594, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(694, 340);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 22;
            btnDel.Text = "Xoá";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(517, 222);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(271, 27);
            txtContactPerson.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(402, 225);
            label9.Name = "label9";
            label9.Size = new Size(99, 20);
            label9.TabIndex = 23;
            label9.Text = "Người liên hệ";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(394, 340);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 25;
            btnLoad.Text = "Load lại";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 377);
            Controls.Add(btnLoad);
            Controls.Add(txtContactPerson);
            Controls.Add(label9);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtLimDay);
            Controls.Add(txtLimMoney);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ckbPer);
            Controls.Add(ckbSup);
            Controls.Add(ckbCus);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtTax);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtTax;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtMail;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private CheckBox ckbCus;
        private CheckBox ckbSup;
        private CheckBox ckbPer;
        private Label label7;
        private Label label8;
        private TextBox txtLimMoney;
        private TextBox txtLimDay;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDel;
        private TextBox txtContactPerson;
        private Label label9;
        private DataGridView dgvCus;
        private Button btnLoad;
    }
}
