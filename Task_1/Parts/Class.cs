using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Class
    {
        Pupil[] _pupils = new Pupil[4];

        public Class(Pupil first, Pupil second, Pupil third= null, Pupil fourth = null)
        {
            this._pupils[0] = first;
            this._pupils[1] = second;
            if (third == null)
                this._pupils[2] = GeneratePuple();
            else
                this._pupils[2] = third;
            if (fourth == null)
                this._pupils[3] = GeneratePuple();
            else
                this._pupils[3] = fourth;
        }

        Random rand = new Random();

        private Pupil GeneratePuple()
        {
            int r = rand.Next(1, 4);
            switch (r)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                default: return new BadPupil();
            }
        }


        public void Show(string c)
        {
            switch (c)
            {
                case "study":
                    foreach (Pupil p in _pupils)
                    {
                        p.PresentStudent();
                        p.Study();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
                case "read":
                    foreach (Pupil p in _pupils)
                    {
                        p.PresentStudent();
                        p.Read();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
                case "write":
                    foreach (Pupil p in _pupils)
                    {
                        p.PresentStudent();
                        p.Write();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
                case "relax":
                    foreach (Pupil p in _pupils)
                    {
                        p.PresentStudent();
                        p.Relax();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
            }
        }
    }
}
