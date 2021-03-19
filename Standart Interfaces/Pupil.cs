using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Standart_Interfaces
{
    class Pupil : ICloneable, IComparable<Pupil>
    {
        public string Name { get; set; } = "NoName";
        public int Age { get; set; } = 0;
        public List<int> marks;
        public Pupil(string name, int age, params int [] marks)
        {
            Name = name;
            Age = age;
            this.marks = new List<int>(marks);
        }
        public double AvgMark => marks[0];
        public override string ToString()
        {
            return $"Pupil : Name: {Name}, Age: {Age}, Marks: {String.Join(' ',marks )}";
        }
        public void ChangeMark(int index, int mark)
        {
            if (index >= 0 && index < marks.Count)
            {

                marks[index] = mark;
            }
        }
        public object Clone()
        {
            Pupil pupil = new Pupil(Name, Age, marks.ToArray());
            return pupil;
        }

        public int CompareTo(object obj) // by name asc
        {
            if (!(obj is Pupil))
            {
                throw new FormatException("Bad Compare Type, (Oobj isn`t Pupil)");
            }
            return this.Name.CompareTo((obj as Pupil).Name);
        }

        public int CompareTo([AllowNull] Pupil other)
        {
            return 0;
        }
    }
    class CmpAvgScorePupil : IComparer<Pupil>
    {
        public int Compare([AllowNull] Pupil x, [AllowNull] Pupil y) {
            return x.AvgMark.CompareTo(y.AvgMark);
        }
    }
}
