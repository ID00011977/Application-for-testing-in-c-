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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new AboutForm();
            a.ShowDialog();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            {   
                
            }
        }

        private void allApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<ApplicantListForm>().Show();
            // The MDI parent form of applicantlist form is ParentForm
            //When I click on the All applicants and I will be redirected to this all applicant form
        }

        private void newTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TestEditForm();
            form.CreateNewTest();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void allTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<TestlistForm>().Show();
        }

        private void newApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ApplicantEditForm();
            form.CreateNewApplicant();
        }

        private void applicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
