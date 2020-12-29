using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class a = new Class(new BadPupil("igor"), new ExcelentPupil());
            a.Show("study");
        }
    }
}
