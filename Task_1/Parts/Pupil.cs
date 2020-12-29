using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Pupil
    {
        private string studentState;
        private string studentName;

        public string StudentState
        {
            get => studentState;
            set => studentState = value;
        }

        public string StudentName
        {
            get => studentName;
            set => studentName = value;
        }

        
        public Pupil(string status, string name = "indefinite student")
        {
            StudentState = status;
            StudentName = name;
        }

        /* or:
        public Pupil(string status, string name)
        {
            StudentState = status;
            StudentName = name;
        }
        public Pupil(string name)
            : this(name, "indefinite student") { }
        */
        

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
