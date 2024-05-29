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
    public partial class RPS : Form
    {
        private Random random;
        private int playerScore;
        private int botScore;
        public RPS()
        {
            InitializeComponent();
            random = new Random();
            playerScore = 0;
            botScore = 0;
        }

        private void RPS_Load(object sender, EventArgs e)
        {
            pbPlayerChoice.Image = Properties.Resources.question;
            pbBotChoice.Image = Properties.Resources.question;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            pbBotChoice.Image = Properties.Resources.question;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Change the interval for a faster/slower rotation
            timer.Tick += (s, ev) =>
            {
                int botChoice = random.Next(3);
                switch (botChoice)
                {
                    case 0:
                        pbBotChoice.Image = Properties.Resources.rock;
                        break;
                    case 1:
                        pbBotChoice.Image = Properties.Resources.paper;
                        break;
                    case 2:
                        pbBotChoice.Image = Properties.Resources.scissors;
                        break;
                }
            };
            timer.Start();

            System.Windows.Forms.Timer stopTimer = new System.Windows.Forms.Timer();
            stopTimer.Interval = 2000; // Stop after 2 seconds
            stopTimer.Tick += (s, ev) =>
            {
                timer.Stop();
                stopTimer.Stop();
                DetermineWinner();
            };
            stopTimer.Start();
        }

        private void DetermineWinner()
        {
            // Assuming pbPlayerChoice.Image.Tag and pbBotChoice.Image.Tag are set
            if (pbPlayerChoice.Image.Tag == null || pbBotChoice.Image.Tag == null) return;

            string playerChoice = pbPlayerChoice.Image.Tag.ToString();
            string botChoice = pbBotChoice.Image.Tag.ToString();

            if (playerChoice == botChoice)
            {
                MessageBox.Show("It's a tie!");
                return;
            }

            bool playerWins = (playerChoice == "rock" && botChoice == "scissors") ||
                              (playerChoice == "paper" && botChoice == "rock") ||
                              (playerChoice == "scissors" && botChoice == "paper");

            if (playerWins)
            {
                playerScore++;
                lblPlayerScore.Text = $"Player Score: {playerScore}";
                MessageBox.Show("You win!");
            }
            else
            {
                botScore++;
                lblBotScore.Text = $"Bot Score: {botScore}";
                MessageBox.Show("Bot wins!");
            }
        }

        private void pbPlayerChoice_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // Change the interval for a faster/slower rotation
            int choiceIndex = 0;
            timer.Tick += (s, ev) =>
            {
                choiceIndex = (choiceIndex + 1) % 3;
                switch (choiceIndex)
                {
                    case 0:
                        pbPlayerChoice.Image = Properties.Resources.rock;
                        pbPlayerChoice.Image.Tag = "rock";
                        break;
                    case 1:
                        pbPlayerChoice.Image = Properties.Resources.paper;
                        pbPlayerChoice.Image.Tag = "paper";
                        break;
                    case 2:
                        pbPlayerChoice.Image = Properties.Resources.scissors;
                        pbPlayerChoice.Image.Tag = "scissors";
                        break;
                }
            };
            timer.Start();

            pbPlayerChoice.Click += (s, ev) => timer.Stop(); // Stop rotation on click
        }
    }
}