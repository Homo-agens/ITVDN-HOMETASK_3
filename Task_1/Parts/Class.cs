using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Class
    {
        Pupil[] pupils = new Pupil[4];

        //почему нельзя вставить new GoodPupil() в значения по умолчанию?
        public Class(Pupil one, Pupil two, Pupil three = null, Pupil four = null)
        {
            this.pupils[0] = one;
            this.pupils[1] = two;
            if (three == null)
                this.pupils[2] = GeneratePuple();
            else
                this.pupils[2] = three;
            if (four == null)
                this.pupils[3] = GeneratePuple();
            else
                this.pupils[3] = four;
        }

        /*
        public Class(Pupil one, Pupil two, Pupil three)
            :this(one, two, three, new GoodPupil()) {}

        public Class(Pupil one, Pupil two)
            : this(one, two, new GoodPupil(), new GoodPupil()) { }
        */

        Random rand = new Random();

        private Pupil GeneratePuple()
        {
            int r = rand.Next(1, 4);
            switch (r)
            {
                case 1: return new ExcelentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
            }
            return new BadPupil();
        }


        public void Show(string c)
        {

            switch (c)
            {
                case "study":
                    foreach (Pupil p in pupils)
                    {
                        p.Present();
                        p.Study();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
                case "read":
                    foreach (Pupil p in pupils)
                    {
                        p.Present();
                        p.Read();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
                case "write":
                    foreach (Pupil p in pupils)
                    {
                        p.Present();
                        p.Write();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
                case "relax":
                    foreach (Pupil p in pupils)
                    {
                        p.Present();
                        p.Relax();
                        Console.WriteLine(new string('_', 25));
                    }
                    break;
            }
        }

        //public void ShowStudy()
        //{
        //    foreach (Pupil p in pupils)
        //    {
        //        p.Study();
        //    }
        //}

    }
}
