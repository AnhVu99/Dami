using De4_Vu.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace De4_Vu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TestDe5Context context = new TestDe5Context();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            SlTblCustomerList customer = new SlTblCustomerList();
            customer.CustomerId = txtId.Text.Trim();
            var tmp = context.SlTblCustomerLists.Find(customer.CustomerId);
            if (tmp == null)
            {
                customer.CustomerName = txtName.Text;
                customer.TaxCode = txtTax.Text.Trim();
                customer.IsCustomer = ckbCus.Checked;
                customer.IsPersonal = ckbPer.Checked;
                customer.IsVendor = ckbSup.Checked;
                customer.Mobile = txtPhone.Text;
                customer.Email = txtMail.Text;
                customer.Address = txtAddress.Text;
                customer.ContactPerson = txtContactPerson.Text;
                customer.DebtLimit = decimal.Parse(txtLimMoney.Text);
                customer.NumberDayLimit = int.Parse(txtLimDay.Text);
                context.Add(customer);
                context.SaveChanges();
                MessageBox.Show("Tạo mới thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Khách hàng với mã '" + txtId.Text.ToString() + "' đã tồn tại");
                return;
            }
        }
        bool checkInput()
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return false;
            }
            if (txtLimDay.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập giới hạn số ngày nợ cho phép");
                return false;
            }
            if (txtLimMoney.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập giới hạn số tiền nợ cho phép");
                return false;
            }
            return true;
        }

        private void txtLimMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtLimDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var customer = context.SlTblCustomerLists.Find(txtId.Text.Trim());
            if (customer != null)
            {
                context.Remove(customer);
                context.SaveChanges();
                MessageBox.Show("Xoá thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Khách hàng với mã '" + txtId.Text.ToString() + "' không tồn tại");
                return;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData ()
        {
            List<SlTblCustomerList> customers = context.SlTblCustomerLists.ToList();
            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            foreach (var part in customers)
            {
                dataTable.Rows.Add(part.CustomerId, part.CustomerName);
            }
            dgvCus.DataSource = dataTable;
            dgvCus.RowHeadersVisible = false;
            dgvCus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCus.ClearSelection();
            dgvCus.ReadOnly = true;
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPhone.Text.Trim() == "") return;
            string pattern = @"^\d{10}$";

            if (!Regex.IsMatch(txtPhone.Text, pattern))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại gồm 10 chữ số.");
                e.Cancel = true;
            }
        }

        private void dgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dgvCus.Rows[e.RowIndex].Cells[0].Value.ToString();
                var customer = context.SlTblCustomerLists.Find(cellValue);
                if (customer != null)
                {
                    txtId.Text = customer.CustomerId;
                    txtName.Text = customer.CustomerName;
                    txtTax.Text = customer.TaxCode;
                    ckbCus.Checked = customer.IsCustomer;
                    ckbPer.Checked = customer.IsPersonal;
                    ckbSup.Checked = customer.IsVendor;
                    txtPhone.Text = customer.Mobile;
                    txtMail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    txtContactPerson.Text = customer.ContactPerson;
                    txtLimMoney.Text = customer.DebtLimit.ToString();
                    txtLimDay.Text = customer.NumberDayLimit.ToString();
                }
            }
        }

        private void txtMail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtMail.Text.Trim() == "") return;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtMail.Text, emailPattern))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ. Vui lòng nhập địa chỉ email hợp lệ.");
                e.Cancel = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = context.SlTblCustomerLists.Find(txtId.Text.Trim());
            if (customer != null)
            {
                customer.CustomerName = txtName.Text;
                customer.TaxCode = txtTax.Text.Trim();
                customer.IsCustomer = ckbCus.Checked;
                customer.IsPersonal = ckbPer.Checked;
                customer.IsVendor = ckbSup.Checked;
                customer.Mobile = txtPhone.Text;
                customer.Email = txtMail.Text;
                customer.Address = txtAddress.Text;
                customer.ContactPerson = txtContactPerson.Text;
                customer.DebtLimit = decimal.Parse(txtLimMoney.Text);
                customer.NumberDayLimit = int.Parse(txtLimDay.Text);
                context.Update(customer);
                context.SaveChanges();
                MessageBox.Show("Update thành công");
            }
            else
            {
                MessageBox.Show("Khách hàng với mã '" + txtId.Text.ToString() + "' không tồn tại");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.KeyDown += new KeyEventHandler(TextBox_KeyDown);
                }
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
    }
}
