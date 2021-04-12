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
    public partial class TakeTest : Form
    {
        public TakeTest()
        {
            InitializeComponent();
        }

        public Applicant Applicant { get; set; }
        public FormMode Mode { get; set; }

        public void TestTake(Applicant applicant)
        {
            Applicant = applicant;
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
            lblName.Text = Applicant.Name;
            var allTests = new TestManager().GetAllNames();
            cbxTest.DataSource = allTests;
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {

        }

        private void cbxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chosenTest = cbxTest.SelectedItem.ToString();
            var test = new TestManager().GetByName(Convert.ToInt32(chosenTest));
            lblQuestion.Text = test.Quest1;
            lblQuestion2.Text = test.Quest2;
            lblQuestion3.Text = test.Quest3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var score = 0;
                var chosenTest = cbxTest.SelectedItem.ToString();
                var test = new TestManager().GetByName(Convert.ToInt32(chosenTest));
                if (tbxQ1Answer.Text == test.Answer1)
                {
                    score = score + 1;
                }
                if (tbxQ2Answer.Text == test.Answer2)
                {
                    score = score + 1;
                }
                if (tbxQ3Answer.Text == test.Answer3)
                {
                    score = score + 1;
                }
                Applicant.Score += score;
                Applicant.Test = Applicant.Test + $",{chosenTest}";
                var manager = new ApplicantManager();
                manager.Update(Applicant);
                MyForms.GetForm<ApplicantListForm>().LoadData();
                Close();
                MessageBox.Show($"{lblName.Text} got {score} right answers, his/her score is improved by {score} marks", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

