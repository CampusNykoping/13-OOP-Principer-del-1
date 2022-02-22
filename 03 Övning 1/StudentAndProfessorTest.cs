using System;

namespace _03_Övning_1
{
    class StudentAndProfessorTest
    {
        public static void Main()
        {
            Person myPerson = new Person();
            myPerson.Greet();

            Person myPerson2 = new Person(60);
            myPerson2.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Professor myProfessor = new Professor(55, "Claes");
            myProfessor.SetAge(30);
            myProfessor.Age = 40;
            myProfessor.Greet();
            myProfessor.Teach();
        }

    }
}
