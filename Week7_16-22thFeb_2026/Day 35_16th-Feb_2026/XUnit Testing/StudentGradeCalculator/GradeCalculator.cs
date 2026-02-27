using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    public class GradeCalculator
    {
        public string GetGrade(int score)
        {
            if (score >= 90) return "A";
            if (score >= 75) return "B";
            if (score >= 50) return "C";
            return "F";
        }
    }

}
