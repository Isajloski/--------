using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Милионер
{
    public class Level
    {
        // Сите прашања ги чуваме во една листа
        public List <Question> questions { get; set; }

        // Моменталниот левел започнува од 1 и крајниот е 15. 
        public int currentLevel { get; set; } = 1;

        // Повикај пријател
        public bool callAFriend { get; set; } = false;

        // Прашај ја публиката
        public bool askTheCrowd { get; set; } = false;

        // Пола од прашањата ќе ги отстрани
        public bool fiftyFifty { get; set; } = false;

        public Level()
        {
            questions = new List <Question>();
            generateQuestions();
              
        }

        private void generateQuestions()
        {
            
        }
    }
}

