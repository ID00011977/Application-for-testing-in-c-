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
    public partial class TestEditForm : Form
    {
        public TestEditForm()
        {
            InitializeComponent();
        }

        public Test Test { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewTest()
        {
            Mode = FormMode.CreateNew;
            Test = new Test();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateTest(Test test)
        {
            Mode = FormMode.Update;
            Test = test;
            InitializeControls();
            ShowTestInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
            
        }

        private void ShowTestInControls()
        {
            tbxName.Text = Test.Name;
            tbxQ1.Text = Test.Quest1;
            tbxQ1Answer.Text = Test.Answer1;
            tbxQ2.Text = Test.Quest2;
            tbxQ2Answer.Text = Test.Answer2;
            tbxQ3.Text = Test.Quest3;
            tbxQ3Answer.Text = Test.Answer3;

        }

        private void GrabUserInput()
        {
            Test.Name = tbxName.Text;
            Test.Quest1 = tbxQ1.Text;
            Test.Answer1 = tbxQ1Answer.Text;
            Test.Quest2 = tbxQ2.Text;
            Test.Answer2 = tbxQ2Answer.Text;
            Test.Quest3 = tbxQ3.Text;
            Test.Answer3 = tbxQ3Answer.Text;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new TestManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Test);
                else
                    manager.Update(Test);

                MyForms.GetForm<TestlistForm>().LoadData();
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tbxQ3Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbxQ3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbxQ2Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbxQ2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxQ1Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxQ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TestEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
