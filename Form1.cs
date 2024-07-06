using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Милионер()
        {
            InitializeComponent();
            level = new Level();
            hoverAnswer = imgAnswer.answer_hover;
            correctAnswer = imgAnswer.correct;
            incorrectAnswer = imgAnswer.incorrect;
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
            Console.WriteLine("A: Leave");

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
