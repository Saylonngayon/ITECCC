using Multi_Tool_Project.Tools.Ent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_Project.Tools
{
    public partial class Entertainment : Form
    {
        public Entertainment()
        {
            InitializeComponent();
        }

        private void btnRPS_Click(object sender, EventArgs e)
        {

        }

        private void btnTQ_Click(object sender, EventArgs e)
        {
            triviaQuiz tqForm = new triviaQuiz();
            tqForm.Show();
            this.Hide();
        }





        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            mainHub mainHubForm = new mainHub();
            mainHubForm.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the System, Goodbye!");
            Thread.Sleep(50);
            Application.Exit();

        }

        private void Entertainment_Load(object sender, EventArgs e)
        {

        }
    }
}
