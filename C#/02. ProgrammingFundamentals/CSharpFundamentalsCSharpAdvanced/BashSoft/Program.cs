using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
   public static class Program
    {
       public static void Main()
        {
             IOManager.TraverseDirectory(@"C:\Users\Ivan\Documents\Visual Studio 2015");
            StudentsRepository.InitializeData();
            StudentsRepository.GetAllStudentsFromCourse("Java_fundamentals");
            //StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}
