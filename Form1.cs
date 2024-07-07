using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Милионер
{
    public partial class Милионер : Form
    {

        // Hover over an answer image
        public Image hoverAnswer {  get; set; }
        // Correct answer image
        public Image correctAnswer { get; set; }
        // Incorrect answer image
        public Image incorrectAnswer { get; set; }
        public Level level { get; set; }

        public List<int> questions {  get; set; }
        public List<Question> easyQuestions { get; set; }
        public List<Question> hardQuestions { get; set; }

        public Милионер()
        {
            InitializeComponent();
            hoverAnswer = imgAnswer.answer_hover;
            correctAnswer = imgAnswer.correct;
            incorrectAnswer = imgAnswer.incorrect;
            easyQuestions = DataInit.easyQuestionsInitData();
            hardQuestions = DataInit.hardQuestionsInitData();
            generateLevels();
            displayLevel();
        }

        private void displayLevel()
        {
            if (level.currentLevel == 15)
            {
                Console.WriteLine("You won!");
                
                generateLevels();
                
            }
            else
            {
                labelQuestion.Text = level.questions[level.currentLevel].question;
                labelA.Text = level.questions[level.currentLevel].answers[0];
                labelB.Text = level.questions[level.currentLevel].answers[1];
                labelC.Text = level.questions[level.currentLevel].answers[2];
                labelD.Text = level.questions[level.currentLevel].answers[3];
                labelLevel.Text = (level.currentLevel + 1) + "";
            }
        }

        private void generateLevels()
        {
            Random random = new Random();

            level = new Level();
            
            for (int i = 0; i < 7; i++)
            {
                int randomNumber = random.Next(0, 50); // Generates random number between 0 and 49

                level.questions.Add(easyQuestions[randomNumber]);

            }
            for (int i = 7; i < 15; i++)
            {
                int randomNumber = random.Next(0, 50); 
                level.questions.Add(hardQuestions[randomNumber]);
            }
        }

        private void NextLevel()
        {
         
            level.currentLevel++;

            if (level.currentLevel == 15)
            {
                Console.WriteLine("You won!");
                level.currentLevel = 0; 
                generateLevels();

            }
            else
            {
                displayLevel();
            }
        }

        private void Милионер_Load(object sender, EventArgs e)
        {
        }

        private void changeHoverImage(System.Windows.Forms.Label label)
        {
            label.Image = hoverAnswer;
        }



        private void changeLeaveImage(System.Windows.Forms.Label label)
        {
            label.Image = null;
        }

        private void labelA_MouseHover(object sender, EventArgs e)
        {
            changeHoverImage(labelA);
        }

    
        private void labelA_MouseLeave(object sender, EventArgs e)
        {
            changeLeaveImage(labelA);
            NextLevel();
        }

        private void labelB_MouseHover(object sender, EventArgs e)
        {
            changeHoverImage(labelB);
        }

        private void labelB_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("B: Leave");
            changeLeaveImage(labelB);

        }

        private void labelC_MouseHover(object sender, EventArgs e)
        {
            changeHoverImage(labelC);

        }

        private void labelC_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("C: Leave");
            changeLeaveImage(labelC);

        }

        private void labelD_MouseHover(object sender, EventArgs e)
        {
            changeHoverImage(labelD);

        }

        private void labelD_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("D: Leave");
            changeLeaveImage(labelD);
        }
    }
}
