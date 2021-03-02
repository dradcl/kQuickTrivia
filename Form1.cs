using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace kQuickTrivia
{
    public partial class Form1 : Form
    {
        // Answer choices are saved as emojis rather than numbers so that it is easy to send as an embed and so the ReactionCollector recognizes it
        private string[] answerOptions = { "1⃣", "2⃣", "3⃣", "4⃣" };

        private List<Question> questionEntries = new List<Question>();
        private string[] answers;
        private int currentAnswerIndex = 0;

        // Used to initialize the options property of the JSON object, made specifically to match Kleiner trivia format.
        private string[] CreateOptionsWithAnswers()
        {
            string[] result = new string[4];
            answers = new string[4] { firstAnsListBox.Text, secondAnsListBox.Text, thirdAnsListBox.Text, fourthAnsListBox.Text };

            for (int i = 0; i < answerOptions.Length; i++)
            {
                result[i] = $"{answerOptions[i]} {answers[i]}";
            }

            return result;
        }

        // Create a new Question object based on the input, serialize it, and log it.
        private void createEntryBtn_Click(object sender, EventArgs e)
        {
            Question currentQuestion = new Question
            {
                Text = questionTextBox.Text,
                Options = CreateOptionsWithAnswers(),
                Answer = answerOptions[currentAnswerIndex]
            };

            // A check to make sure the answerOptions index stays in bounds, we can discard the result.
            _ = currentAnswerIndex >= 3 ? currentAnswerIndex = 0 : currentAnswerIndex++;

            createdListBox.Items.Add(JsonConvert.SerializeObject(currentQuestion));
            questionEntries.Add(currentQuestion);
        }

        // Writing the Question objects to a JSON file.
        private void createBtn_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("trivia.json"))
            {
                foreach (Question entry in questionEntries)
                    tw.WriteLine($"{JsonConvert.SerializeObject(entry)},");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}