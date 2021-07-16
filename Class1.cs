using System;

namespace StudentAspirantClasses
{
    class Student
    {
        private string _firstName, _lastName, _group;
        public readonly double _averageMark;

        const double STUDENT_SCOLARSHIP_COEFF = 1.25;

        public Student()
        {
            Console.Write("Введите имя студента: ");
            _firstName = Console.ReadLine();

            Console.Write("Введите фамилию студента: ");
            _lastName = Console.ReadLine();

            Console.Write("Введите группу студента: ");
            _group = Console.ReadLine();

            Console.Write("Введите среднюю оценку студента: ");
            _averageMark = System.Convert.ToDouble(Console.ReadLine());
        }
        public Student(string firstName, string lastName, string group, double averageMark)
        {
            _firstName = firstName;
            _lastName = lastName;
            _group = group;
            _averageMark = averageMark;
        }

        public virtual int GetScolarship()
        {
            int x = 80;

            if (_averageMark == 5.0)
                return (int)(STUDENT_SCOLARSHIP_COEFF * x);
            else if (_averageMark >= 4.0)
                return x;
            else
                return 0;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("\nИмя: " + _firstName +
                              "\nФамилия: " + _lastName +
                              "\nГруппа: " + _group +
                              "\nСредняя оценка: " + _averageMark);
        }
    }

    class Aspirant : Student
    {
        private string _scientificWork;

        const double ASPIRANT_SCOLARSHIP_COEFF = 2.25;

        public Aspirant() : base()
        {
            Console.Write("Введите название научной работы: ");
            _scientificWork = Console.ReadLine();
        }
        public Aspirant(string firstName, string lastName, string group, double averageMark, string scientificWork)
               : base(firstName, lastName, group, averageMark)
        {
            _scientificWork = scientificWork;
        }

        public override int GetScolarship()
        {
            return (int)(base.GetScolarship() * ASPIRANT_SCOLARSHIP_COEFF);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Научная работа: " + _scientificWork);
        }
    }
}
