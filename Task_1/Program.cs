using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var class = new Class(new BadPupil("igor"), new ExcelentPupil());
            class.Show("study");
        }
    }
}
