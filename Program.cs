// Subjects:
using Lab1Homework;

Subject subject1 = new Subject();
subject1.Title = "Romanian";
subject1.Duration = "1h";

Subject subject2 = new Subject();
subject2.Title = "Maths";
subject2.Duration = "2h 30m";

Subject subject3 = new Subject();
subject3.Title = "Art";
subject3.Duration = "1h";

Subject subject4 = new Subject();
subject4.Title = "Computer Science";
subject4.Duration = "4h";

Subject subject5 = new Subject();
subject5.Title = "Physical Education";
subject5.Duration = "1h 30m";

Subject subject6 = new Subject();
subject6.Title = "Break";
subject6.Duration = "10h";

// Students:

Student student1 = new Student();
student1.First = "Edward";
student1.Last = "Ghiuzan";
student1.Year = 3;
student1.Subjects = new List<Subject>() { subject2, subject4, subject5 };

Student student2 = new Student();
student2.First = "Bula";
student2.Last = "Bula";
student2.Year = 0;
student2.Subjects = new List<Subject>() { subject6 };

Student student3 = new Student();
student3.First = "Dwayne";
student3.Last = "Johnson";
student3.Year = 2;
student3.Subjects = new List<Subject>() { subject5, subject5, subject5, subject5, subject5 };

Student student4 = new Student();
student4.First = "Mihai";
student4.Last = "Eminescu";
student4.Year = 3;
student4.Subjects = new List<Subject>() { subject1, subject3, subject6 };

student1.printSubjects();
student2.printSubjects();
student3.printSubjects();
student4.printSubjects();