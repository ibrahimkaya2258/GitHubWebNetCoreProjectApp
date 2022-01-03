using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreProjectApp.Models
{
    public class GeneratePasswordViewModel
    {
        public int PasswordLenght { get; set; }
        public int NumericCharLenght { get; set; }
        public int LowerCaseLenght { get; set; }
        public int UpperCaseLenght { get; set; }
        public int SpecialCharLenght { get; set; }
    }
}
