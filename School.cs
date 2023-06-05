using System;
using System.Collections.Generic;
using System.Linq;

namespace advanceprog
{

    class School
    {
        private string nameSchool;
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        public string NameSchool { get => nameSchool; set => nameSchool = value; }
        internal List<Teacher> Teachers { get => teachers; set => teachers = value; }
        internal List<Student> Students { get => students; set => students = value; }
        public School()
        {
            teachers = new List<Teacher>();
            students = new List<Student>();
        }
        public void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void addStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }



        public void showStudent()
        {
            foreach (Student student in Students)
            {
                student.showInformation();
            }
        }

        public void showTeacher()
        {
            foreach (Teacher teacher in Teachers)
            {
                teacher.showInformation();
            }
        }


        //public static void SearchStudentById(int studentID, List<Student> students)
        //{
        //	Console.WriteLine("Seach the student by id: ");
        //	String searching = Console.ReadLine();
        //	for (int i = 0; i < students.Count; i++)
        //	{
        //		if (students[i].StudentID.Equals(searching))
        //		{
        //			students[i].showInformation();
        //		}

        //	}
        //}

        public void SearchStudentById(int id)
        {
            var student = Students.FirstOrDefault(s => s.StudentID == id);
            if (student == null)
            {
                Console.WriteLine("Student not found");
            }
            // else
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student Age: {student.Age}");
            Console.WriteLine($"Student ID: {student.StudentID}");

        }
        public void SearchTeacherById(int id)
        {
            var teacher = Teachers.FirstOrDefault(t => t.TeacherId == id);
            if (teacher == null)
            {
                Console.WriteLine("Teacher not found");
            }
            // else
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Student Name: {teacher.Name}");
            Console.WriteLine($"Student Age: {teacher.Age}");
            Console.WriteLine($"Student ID: {teacher.TeacherId}");
            Console.WriteLine($"Student Experience Year: {teacher.ExperienceYear}");

        }

    }
}

//public Teacher findTeacher(int teacherID)
//{
//	var resultTeacher = from teacher in teachers
//						where teacher.TeacherId == teacherID
//						select teacher;
//	return resultTeacher.FirstOrDefault();
//}

//public Student findStudent(int studentID)
//{
//    var resultStudent = from student in students
//                        where student.StudentID == studentID
//                        select student;
//    return resultStudent.FirstOrDefault();
//}