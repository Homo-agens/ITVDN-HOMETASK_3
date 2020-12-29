using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class class1 = new Class(new BadPupil("igor"), new ExcelentPupil());
            class1.Show("study");
        }
    }
}
