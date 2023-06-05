using Advancedpro;
using System;
using System.Collections.Generic;
namespace advanceprog
{
    class management
    {
        private static School school = new School();
        public void launchApp()
        {
            int choice = 0;
            string schoolName = "";
            Console.Write("Set your School name : -> ");
            schoolName = Console.ReadLine();
            do
            {
                Console.Clear(); // Clear screen to start new working session.
                Menu.showMenu(schoolName);
                try
                {

                    Console.WriteLine("Enter your choice : -> ");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear(); // Clear all screen after choose the selection.
                    switch (choice)
                    {
                        case 1:
                            addNewStudent();
                            break;
                        case 2:
                            addTeacher();
                            break;
                        case 3:
                            Console.WriteLine("Enter teacher ID to search:");
                            int idTeacher = int.Parse(Console.ReadLine());
                            school.SearchTeacherById(idTeacher);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Enter student Id to search: ");
                            int idStudent = int.Parse(Console.ReadLine());
                            school.SearchStudentById(idStudent);
                            Console.ReadKey();
                            break;
                        case 5:
                            showStudent();
                            break;
                        case 6:
                            showTeacher();
                            break;
                        case 7:
                            removeTeacher();
                            break;
                        case 8:
                            removeStudent();
                            break;

                        default:

                            continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid");
                }

            } while (choice < 10);
        }


        private static void addNewStudent()
        {
            Console.Write("How many student do you want to add : -> ");
            int amount = int.Parse(Console.ReadLine());
            for (int index = 0; index < amount; index++)
            {
                Console.Write("\n\nPlease enter the student name: -> ");
                string name = Console.ReadLine();
                Console.Write("Pleaser enter the student age: -> ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Please enter the student ID: -> ");
                int id = int.Parse(Console.ReadLine());
                Student student = new Student(name, age, id);
                school.addStudent(student);
            }
            Console.WriteLine("Done ! Press any key to return the Menu. ");
            Console.ReadKey();
        }

        private static void addTeacher()
        {
            Console.Write("How many Teacher do you want to add : -> ");
            int amount = int.Parse(Console.ReadLine());
            for (int index = 0; index < amount; index++)
            {
                Console.Write("\n\nPlease enter the teacher name : -> ");
                string name = Console.ReadLine();
                Console.Write("Please enter the teacher age : -> ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Please enter the teacher id : -> ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Please enter the teacher experience year : -> ");
                int experienceYear = int.Parse(Console.ReadLine());
                Teacher teacher = new Teacher(id, experienceYear, name, age);
                school.addTeacher(teacher);
            }
            Console.WriteLine("Done ! Press any key to return the Menu. ");
            Console.ReadKey();
        }

        private static void removeTeacher()
        {
            Console.Write("Enter the teacher ID to remove: -> ");
            int id = int.Parse(Console.ReadLine());

            // Find the teacher in the school's teachers list
            Teacher teacherToRemove = school.Teachers.FirstOrDefault(teacher => teacher.TeacherId == id);

            if (teacherToRemove != null)
            {
                // Remove the teacher from the school
                school.RemoveTeacher(teacherToRemove);
                Console.WriteLine("Teacher removed successfully!");
            }
            else
            {
                Console.WriteLine("Teacher not found!");
            }

            Console.ReadKey();
        }
        private static void removeStudent()
        {
            Console.Write("Enter the student ID to remove: -> ");
            int id = int.Parse(Console.ReadLine());

            // Find the student in the school's students list
            Student studentToRemove = school.Students.FirstOrDefault(student => student.StudentID == id);

            if (studentToRemove != null)
            {
                // Remove the student from the school
                school.RemoveStudent(studentToRemove);
                Console.WriteLine("Student removed successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }

            Console.ReadKey();
        }

        private static void showStudent()
        {
            Console.WriteLine("List of students");
            foreach (Student student in school.Students)
            {
                student.showInformation();
            }
            Console.ReadKey();
        }

        private static void showTeacher()
        {
            Console.WriteLine("List of teachers");
            foreach (Teacher teacher in school.Teachers)
            {
                teacher.showInformation();
            }
            Console.ReadKey();
        }

    }
}
//private static void addClass()
//{
//	Console.Write("Set Class Name : ->\n(Class name is unique and do not duplicated) ");
//	string nameClass = Console.ReadLine();
//	Console.Write("Set the Main Teacher () : -> ");
//	int id = int.Parse(Console.ReadLine());
//	var resultTeacher = from teacher in school.Teachers
//						where teacher.TeacherId == id
//						select teacher;
//	Classroom classroom = new Classroom(nameClass, resultTeacher.FirstOrDefault());
//	school.addClass(classroom);
//}

//private static void findStudent()
//{
//    Console.Write("Please enter the Student ID : -> ");
//    int id = int.Parse(Console.ReadLine());
//    Student student = school.SearchingById();
//    student.showInformation();
//    Console.ReadKey();
//}