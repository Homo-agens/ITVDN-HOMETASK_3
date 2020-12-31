using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class BadPupil : Pupil
    {
        public BadPupil()
            : base("bad") { }

        public BadPupil(string name)
            : base("bad", name) { }

        public override void Write()
        {
            Console.WriteLine($"Write is very {StudentState}");
        }
        public override void Relax()
        {
            Console.WriteLine($"Relax is not {StudentState}");
        }
    }
}
