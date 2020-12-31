using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Pupil
    {
    public string StudentState {get;set}
    public string StudentName {get;set;}

        
        public Pupil(string status, string name = "indefinite student")
        {
            StudentState = status;
            StudentName = name;
        }
        

        public void PresentStudent()
        {
            Console.WriteLine($"Student name: {StudentName}, student achivement: {studentState};");

        }

        public virtual void Study()
        {
            Console.WriteLine($"Stydy is {StudentState}");
        }
        public virtual void Read()
        {
            Console.WriteLine($"Read is {StudentState}");
        }
        public virtual void Write()
        {
            Console.WriteLine($"Write is {StudentState}");
        }
        public virtual void Relax()
        {
            Console.WriteLine($"Relax is {StudentState}");
        }

    }
}
