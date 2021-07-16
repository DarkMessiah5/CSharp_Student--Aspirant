/*
 Создайте пример наследования, реализуйте класс Student и класс Aspirant, аспирант отличается от студента наличием некой научной работы.
    а) Класс Student содержит переменные: String firstName, lastName, group. А также, double averageMark, содержащую среднюю оценку.
    б) Создать переменную типа Student, которая ссылается на объект типа Aspirant.
    в) Создать метод getScholarship() для класса Student, который возвращает сумму стипендии. Если средняя оценка студента равна 5, 
       то сумма 100 грн, иначе 80. Переопределить этот метод в классе Aspirant.  Если средняя оценка аспиранта равна 5, то сумма 200 грн, иначе 180.
    г) Создать массив типа Student, содержащий объекты класса Student и Aspirant. Вызвать метод getScholarship() для каждого элемента массива.
 */

using System;

namespace StudentAspirantClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new();

            Student student2 = new("Pavel", "Kuminov", "430-4", 4.8);

            Student student3 = new Aspirant();

            Student student4 = new Aspirant("Pan", "Huilovski", "129-3", 3.5, "About something");

            student1.GetInfo();
            
            student2.GetInfo();

            student3.GetInfo();
            
            student4.GetInfo();
        }
    }
}
