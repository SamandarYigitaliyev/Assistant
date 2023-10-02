using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Register
{
    public  class SignIn
    {
        
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string QuizName { get; set; } = String.Empty;
        public string Result { get; set; } = String.Empty; 
    }
}
