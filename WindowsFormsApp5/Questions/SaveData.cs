using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Questions
{
    public class SaveData 
    {
        public string QuizName { get; set; } = string.Empty;
        public string Question { get; set; } = String.Empty;
        public string Option1 { get; set; } = String.Empty;
        public string Option2 { get; set; } = String.Empty;
        public string Option3 { get; set; } = String.Empty;
        public string Option4 { get; set; } = String.Empty;
        public string Answer { get; set; } = String.Empty;
        public int Order { get; set; }
    }
}
