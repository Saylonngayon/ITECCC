using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools.Ent
{
    public partial class tqIntro : Form
    {
        public tqIntro()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumQuestions.Text, out int totalQuestions) && totalQuestions > 0)
            {
                var tqIntroForm = new triviaQuiz(totalQuestions);
                this.Hide();
                tqIntroForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid number of questions.", "Invalid Input");
            }
        }
    }
}
