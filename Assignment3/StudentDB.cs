using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public static class StudentDB
    {
        private static string studenttxt = "C:\\Users\\hp\\Desktop\\Assignment3\\Assignment3\\students.txt";
        private static string usertxt = "C:\\Users\\hp\\Desktop\\Assignment3\\Assignment3\\user.txt";
        public static List<Student> students = StudentDB.ReadStudent();
        public static List<Admin> admins = StudentDB.ReadAdmin();

        public static List<Admin> ReadAdmin()
        {
            List<Admin> admins = new List<Admin>();
            try
            {
                using (StreamReader reader = new(new FileStream(usertxt, FileMode.Open, FileAccess.Read)))
                {
                    while(reader.Peek() != -1)
                    {
                        string line = reader.ReadLine();
                        string[] column = line.Split("|");
                        admins.Add(new Admin(column[0], column[1]));
                    }
                    return admins;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return admins;
            }
        }


        public static List<Student> ReadStudent()
        {
            List<Student> list = new List<Student>();
            try
            {
                using (StreamReader reader = new(new FileStream(studenttxt, FileMode.Open, FileAccess.Read)))
                {
                    while (reader.Peek() != -1)
                    {
                        string line = reader.ReadLine();
                        string[] column = line.Split("|");
                        if (column.Length == 7)
                        {
                            Student s = new Student(
                                int.Parse(column[0]),
                                column[1],
                                column[2],
                                int.Parse(column[3]),
                                column[4],
                                column[5],
                                float.Parse(column[6]));
                            list.Add(s);
                        }
                        else
                        {
                            MessageBox.Show("Fail to load Student.");
                        }
                    }
                    return list;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }
        }

        public static void WriteStudent()
        {
            try
            {
                using (StreamWriter writer = new(new FileStream(studenttxt, FileMode.Create, FileAccess.Write)))
                {
                    foreach (Student s in students)
                    {
                        writer.WriteLine(s.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public  class Admin
        {
            public  string UserName { get; }
            public  string Password { get; }
            public Admin(string userName, string password)
            {
                UserName = userName;
                Password = password;
            }
        }
    }
}
