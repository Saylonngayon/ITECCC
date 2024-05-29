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
        private string playerChoice;
        private System.Windows.Forms.Timer playerTimer;
        private int choiceIndex;
        public RPS()
        {
            InitializeComponent();
            random = new Random();
            playerScore = 0;
            botScore = 0;
            playerChoice = "";
            choiceIndex = 0;
            InitializePlayerTimer();
        }

        private void RPS_Load(object sender, EventArgs e)
        {
            pbPlayerChoice.Image = Properties.Resources.question;
            pbBotChoice.Image = Properties.Resources.question;
        }
        private void InitializePlayerTimer()
        {
            playerTimer = new System.Windows.Forms.Timer();
            playerTimer.Interval = 100; // Change the interval for a faster/slower rotation
            playerTimer.Tick += (s, ev) =>
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
        }

        private void pbPlayerChoice_Click(object sender, EventArgs e)
        {
            if (!playerTimer.Enabled)
            {
                playerTimer.Start();
                pbPlayerChoice.Click += StopPlayerTimer; // Attach the stop timer event
            }
        }

        private void StopPlayerTimer(object sender, EventArgs e)
        {
            playerTimer.Stop();
            playerChoice = pbPlayerChoice.Image.Tag.ToString();
            pbPlayerChoice.Click -= StopPlayerTimer; // Detach the stop timer event
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(playerChoice))
            {
                MessageBox.Show("Please make your choice first by clicking on the image.");
                return;
            }

            pbBotChoice.Image = Properties.Resources.question;
            System.Windows.Forms.Timer botTimer = new System.Windows.Forms.Timer();
            botTimer.Interval = 100; // Change the interval for a faster/slower rotation
            botTimer.Tick += (s, ev) =>
            {
                int botChoice = random.Next(3);
                switch (botChoice)
                {
                    case 0:
                        pbBotChoice.Image = Properties.Resources.rock;
                        pbBotChoice.Image.Tag = "rock";
                        break;
                    case 1:
                        pbBotChoice.Image = Properties.Resources.paper;
                        pbBotChoice.Image.Tag = "paper";
                        break;
                    case 2:
                        pbBotChoice.Image = Properties.Resources.scissors;
                        pbBotChoice.Image.Tag = "scissors";
                        break;
                }
            };
            botTimer.Start();

            System.Windows.Forms.Timer stopBotTimer = new System.Windows.Forms.Timer();
            stopBotTimer.Interval = 2000; // Stop after 2 seconds
            stopBotTimer.Tick += (s, ev) =>
            {
                botTimer.Stop();
                stopBotTimer.Stop();
                DetermineWinner();
            };
            stopBotTimer.Start();
        }

        private void DetermineWinner()
        {
            // Assuming pbBotChoice.Image.Tag is set
            if (pbPlayerChoice.Image.Tag == null || pbBotChoice.Image.Tag == null) return;

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
    }
}