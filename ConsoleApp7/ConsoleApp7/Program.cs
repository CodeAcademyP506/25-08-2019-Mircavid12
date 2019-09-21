using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Group[] Qruplar = new Group[15];
            Group P506 = new Group("p506", "5");
            Group P507 = new Group("p507", "3");
            Group P508 = new Group("p508", "4");
            Qruplar[0] = P506;
            Qruplar[1] = P507;
            Qruplar[2] = P508;


            Teacher teacher1 = new Teacher("Ismayil", "Ismayilov");
            Teacher teacher2 = new Teacher("Samir", "Kerimov");
            Teacher teacher3 = new Teacher("Samir", "Dadaszadeh");
            Teacher[] Muellimler = new Teacher[20];

            Student student1 = new Student("Metin", "Quluzade");
            Student student2 = new Student("Ayxan", "Memmedov");
            Student student3 = new Student("Ali", "Asgarov");
            Student student4 = new Student("Nurlan", "Huseynov");
            Student student5 = new Student("Mircavid", "Elekberov");
            Student student6 = new Student("Sahib", "Elizade");
            Student student7 = new Student("Ayxan", "Eliyev");
            Student student8 = new Student("Sevinc", "Kerimova");
            Student student9 = new Student("Aysel", "Muradova");
            Student student10 = new Student("Vahid", "Quliyev");
            Student student11 = new Student("Miraga", "Agayev");
            Student student12 = new Student("Leman", "Melikova");

            teacher1.Groups = new Group[] { P506, P507 };
            teacher2.Groups = new Group[] { P508 };

            Console.WriteLine("Groups: ");
            ShowGroup(Qruplar);
            Console.WriteLine();

            P506.Students = new Student[] { student1,student2,student3,student4,student5 };
            P507.Students = new Student[] { student6, student7, student8 };
            P508.Students = new Student[] { student9, student10, student11, student12 };

            ShowStudent(P506);
            Console.WriteLine("-----------------------");
            ShowStudent(P507);
            Console.WriteLine("-----------------------");
            ShowStudent(P508);
            Console.WriteLine("-----------------------");


            Console.WriteLine("1)Add  Or  2)Remove  ?");
            string myinput = Console.ReadLine();

            if(myinput == "1")
            {
                
                    Console.WriteLine("Group adini ve Sagird sayini daxil edin: ");
                    Group newGroup = new Group(Console.ReadLine(), Console.ReadLine());
                    for (int i = 0; i < Qruplar.Length; i++)
                    {
                        if (Qruplar[i] == default(Group))
                        {
                            Qruplar[i] = newGroup;
                            Console.WriteLine("yaradilan grup " + Qruplar[i].GroupName);
                            break;
                        }
                    }

                    Console.WriteLine("Sagirdlerin adini ve soyadini daxil edin:");
                    for (int i = 0; i < newGroup.Students.Length; i++)
                    {
                        Console.WriteLine(i + 1 + ". Sagirdin adini ve Soyadini qeyd edin:");
                        addStudent(newGroup);
                    }
                    Console.WriteLine("Group adi: " + newGroup.GroupName);
                    Console.WriteLine("Sagirdler:");

            }
            if (myinput == "2")
            {

            }
        
        }
        public static void ShowGroup(Group[] group)
        {

            for (int i = 0; i < group.Length; i++)
            {
                if (group[i] != default(Group))
                {
                    Console.WriteLine(group[i].GroupName);


                }

            }
        }

        public static void ShowStudent(Group group)
        {

            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i] != default(Student))
                {
                    Console.WriteLine(i + 1 + ". " + group.Students[i].Name + " " + group.Students[i].Surname);


                }

            }
        }

        public static void addStudent(Group group)
        {
            Student student = new Student(Console.ReadLine(), Console.ReadLine());
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i] == default(Student))
                {
                    group.Students[i] = student;
                    break;
                }
            }
        }




    }

    class Group
    {
        public string GroupName { get; set; }

        public Student[] Students;

        public Group(string groupname, string count)
        {
            this.GroupName = groupname;

            Students = new Student[Convert.ToInt32(count)];
        }

    }

    class Teacher
    {
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public Group[] Groups;
        public Teacher(string name, string surname)
        {
            this.TeacherName = name;
            this.TeacherSurname = surname;
        }
        Teacher() { }
    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

    }

}
