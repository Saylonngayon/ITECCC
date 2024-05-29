using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Multi_Tool_Project.Tools.Ent
{
    public partial class triviaQuiz : Form
    {
        private int score = 0;
        private int questionCount = 0;
        private int totalQuestions = 0;
        private string correctAnswer;

        public triviaQuiz(int totalQuestions)
        {
            InitializeComponent();
            this.totalQuestions = totalQuestions;
            lblScore.Text = "Score: 0";
            LoadNextQuestion();
        }

        private async void LoadNextQuestion()
        {
            if (questionCount < totalQuestions)
            {
                var question = await FetchTriviaQuestion();
                if (question != null)
                {
                    lblQuestion.Text = WebUtility.HtmlDecode(question["question"].ToString());
                    var incorrectAnswers = question["incorrect_answers"].ToObject<string[]>();
                    correctAnswer = WebUtility.HtmlDecode(question["correct_answer"].ToString());
                    var allAnswers = incorrectAnswers.Append(correctAnswer).OrderBy(a => Guid.NewGuid()).ToArray();

                    rbOption1.Text = WebUtility.HtmlDecode(allAnswers[0]);
                    rbOption2.Text = WebUtility.HtmlDecode(allAnswers[1]);
                    rbOption3.Text = WebUtility.HtmlDecode(allAnswers[2]);
                    rbOption4.Text = WebUtility.HtmlDecode(allAnswers[3]);
                }
            }
            else
            {
                MessageBox.Show($"Quiz over! Your score is {score} out of {totalQuestions}.", "Quiz Completed");
                ShowEndQuizControls();
            }
        }

        private async Task<JObject> FetchTriviaQuestion()
        {
            using (HttpClient client = new HttpClient())
            {
                int retryCount = 3;
                int delay = 2000; // 2 seconds delay

                for (int i = 0; i < retryCount; i++)
                {
                    try
                    {
                        var response = await client.GetStringAsync("https://opentdb.com/api.php?amount=1&type=multiple");
                        var data = JObject.Parse(response);
                        return (JObject)data["results"][0];
                    }
                    catch (HttpRequestException ex) when ((int)ex.StatusCode == 429)
                    {
                        if (i == retryCount - 1)
                        {
                            MessageBox.Show("Too many requests. Please try again later.", "Error");
                            return null;
                        }

                        await Task.Delay(delay);
                    }
                }

                return null;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "";
            if (rbOption1.Checked) selectedAnswer = rbOption1.Text;
            if (rbOption2.Checked) selectedAnswer = rbOption2.Text;
            if (rbOption3.Checked) selectedAnswer = rbOption3.Text;
            if (rbOption4.Checked) selectedAnswer = rbOption4.Text;

            if (selectedAnswer == correctAnswer)
            {
                score++;
                lblScore.Text = $"Score: {score}";
                MessageBox.Show("Correct!", "Result");
            }
            else
            {
                MessageBox.Show($"Wrong! The correct answer was: {correctAnswer}", "Result");
            }

            questionCount++;
            LoadNextQuestion();
        }

        private void ShowEndQuizControls()
        {
            lblQuestion.Visible = false;
            rbOption1.Visible = false;
            rbOption2.Visible = false;
            rbOption3.Visible = false;
            rbOption4.Visible = false;
            btnSubmit.Visible = false;

            btnRestart.Visible = true;
            btnEndQuiz.Visible = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEndQuiz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {

        }
    }
}