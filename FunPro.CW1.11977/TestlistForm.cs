using CW.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW1._11977
{
    public partial class TestlistForm : Form
    {
        public TestlistForm()
        {
            InitializeComponent();
        }

        private void TestListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new TestList().GetAllTests();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a Test");
            else
            {
                var t = (Test)dgv.SelectedRows[0].DataBoundItem;
                new TestEditForm().UpdateTest(t);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.CreateNewTest();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a Test");
            else
            {
                var t = (Test)dgv.SelectedRows[0].DataBoundItem;
                new TestManager().Delete(t.Id);
                LoadData();
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
                var form = new TestEditForm();
            form.CreateNewTest();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a Test");
            else
            {
                var t = (Test)dgv.SelectedRows[0].DataBoundItem;
                new TestEditForm().UpdateTest(t);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a Test");
            else
            {
                var t = (Test)dgv.SelectedRows[0].DataBoundItem;
                new TestManager().Delete(t.Id);
                LoadData();
            }

        }

        private void TestlistForm_Load_1(object sender, EventArgs e)
        {
            
                MdiParent = MyForms.GetForm<ParentForm>();
                LoadData();
            
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
