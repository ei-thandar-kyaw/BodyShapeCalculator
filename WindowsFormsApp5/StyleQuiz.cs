using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class StyleQuiz : Form
    {
        private int questionIndex = 0;
        private int score = 0;
        private string imagePath = Path.Combine(Application.StartupPath, "QuizImages");
        private List<QuizQuestion> quizQuestions;

        public StyleQuiz()
        {
            InitializeComponent();
            LoadQuizQuestions();
            DisplayQuizQuestion();
        }

        public class QuizQuestion
        {
            public string BodyType { get; set; }
            public string CorrectOutfit { get; set; }
            public List<string> OutfitChoices { get; set; }

            public QuizQuestion(string bodyType, string correctOutfit, List<string> outfitChoices)
            {
                BodyType = bodyType;
                CorrectOutfit = correctOutfit;
                OutfitChoices = outfitChoices;
            }
        }

        private void LoadQuizQuestions()
        {
            quizQuestions = new List<QuizQuestion>
            {
                new QuizQuestion("Apple", "Asymmetrical Hem.jpg", new List<string> { "Layer Skirt.jpg", "Asymmetrical Hem.jpg", "Straight Cut Denim.jpg" }),
                new QuizQuestion("Inverted Triangle", "Asymmetrical One Shoulder Top.jpg", new List<string> { "Puff Top.jpg", "Belted Top.jpg", "Asymmetrical One Shoulder Top.jpg" }),
                new QuizQuestion("Pear", "Off Shoulder Top Long Sleeve.jpg", new List<string> { "Bell Sleeve Top.jpg", "Off Shoulder Top Long Sleeve.jpg", "Wrap Top Short Sleeve.jpg" }),
                new QuizQuestion("Hourglass", "Blouse with shoulder pad.jpg", new List<string> { "Blouse with shoulder pad.jpg", "V Neck Top.jpg", "Belted Top.jpg" }),
                new QuizQuestion("Rectangle", "Bootcup Pant.jpg", new List<string> {"Bootcup Pant.jpg", "Pleated Pant.jpg", "Wide Leg Pant.jpg" }),
                new QuizQuestion("Rectangle", "Peplum Top.jpg", new List<string>{ "Sweetheart Neck.jpg", "Peplum Top.jpg", "Empire Waist Dress.jpg"}),
                new QuizQuestion("Hourglass", "Puff Top.jpg", new List<string>{"Puff Top.jpg", "Brightly Colored Top.jpg", "Bell Sleeve Top.jpg" }),
                new QuizQuestion("Pear", "Structured Top.jpg", new List<string>{"Asymmetrical One Shoulder Top.jpg", "Off Shoulder Top Short Sleeve.jpg", "Structured Top.jpg"}),
                new QuizQuestion("Inverted Triangle", "Bell Sleeve Top.jpg", new List<string>{"Bell Sleeve Top.jpg", "Wrap Top Short Sleeve.jpg", "V Neck Top.jpg" }),
                new QuizQuestion("Apple", "Off Shoulder Top Short Sleeve.jpg", new List<string>{"Off Shoulder Top Short Sleeve.jpg", "Off Shoulder Top Long Sleeve.jpg", "Asymmetrical One Shoulder Top.jpg"}),
                new QuizQuestion("Hourglass", "Vertical stripe Pant.jpg", new List<string> {"Wide Waistband Pant.jpg", "Straightleg Pant.jpg", "Vertical Stripe Pant.jpg"}),
                new QuizQuestion("Rectangle", "Wide Waistband Pant.jpg", new List<string> {"Straight Leg Jeans.jpg", "Wide Waistband Pant.jpg", "Dark Pant.jpg"}),
            };
        }

        private void DisplayQuizQuestion()
        {
            if (questionIndex > quizQuestions.Count)
            {
                MessageBox.Show($"Quiz completed! Your final score is {score}", "Quiz Completed");
            }

            QuizQuestion currentQuestion = quizQuestions[questionIndex];
            lbCurrentQuestion.Text = $"Which outfit is best for a {currentQuestion.BodyType} body type?";

            string imagePath1 = Path.Combine(imagePath, currentQuestion.OutfitChoices[0]);
            string imagePath2 = Path.Combine(imagePath, currentQuestion.OutfitChoices[1]);
            string imagePath3 = Path.Combine(imagePath, currentQuestion.OutfitChoices[2]);

            if (File.Exists(imagePath1))
                pictureBox1.ImageLocation = imagePath1;
            else
                MessageBox.Show($"Image not found: {currentQuestion.OutfitChoices[0]}");

            if (File.Exists(imagePath2))
                pictureBox2.ImageLocation = imagePath2;
            else
                MessageBox.Show($"Image not found: {currentQuestion.OutfitChoices[1]}");

            if (File.Exists(imagePath3))
                pictureBox3.ImageLocation = imagePath3;
            else
                MessageBox.Show($"Image not found: {currentQuestion.OutfitChoices[2]}");

            pictureBox1.Tag = currentQuestion.OutfitChoices[0];
            pictureBox2.Tag = currentQuestion.OutfitChoices[1];
            pictureBox3.Tag = currentQuestion.OutfitChoices[2];
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPicture = sender as PictureBox;
            if (clickedPicture != null)
            {
                QuizQuestion currentQuestion = quizQuestions[questionIndex];

                if ((string)clickedPicture.Tag == currentQuestion.CorrectOutfit)
                {
                    score += 10;
                    MessageBox.Show("✅ Correct!");
                }
                else
                {
                    MessageBox.Show("❌ Incorrect. Try again!");
                }

                questionIndex++;
                if (questionIndex < quizQuestions.Count)
                {
                    DisplayQuizQuestion();
                }
                else
                {
                    MessageBox.Show($"🎉 Quiz completed! Your final score is {score}");
                }
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            questionIndex++;
            if (questionIndex < quizQuestions.Count)
            {
                DisplayQuizQuestion();
            }
            else
            {
                MessageBox.Show($"🎉 Quiz completed! Your final score is {score}");
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox_Click(sender,e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox_Click(sender, e);
        }

        private void btnEndQuiz_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Quiz ended! Your final score is {score}. Hope you find out the style that matches best with you. Good Luck!!", "Quiz Ended");
            this.Close();
        }
    }
}
