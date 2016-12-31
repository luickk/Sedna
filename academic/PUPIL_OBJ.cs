using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace academic
{
    class PUPIL_OBJ
    {

        public static String name = "";
        public static String pass = "";


        public static String user_class;
        public static String user_class_pw;
        public static String user_school;
        public static String user_age;
        public static String user_email;

        public static String get_user_class()
        {
            user_class = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "user_class");
            Console.WriteLine(user_class);
            return user_class;
        }
        public static String get_user_class_pw()
        {
            user_class_pw = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "user_class_pw");
            Console.WriteLine(user_class_pw);

            return user_class_pw;
        }
        public static String get_user_school()
        {
            user_school = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "user_school");
            Console.WriteLine(user_school);
            return user_school;
        }
        public static String get_user_age()
        {
            user_age = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "user_age");
            Console.WriteLine(user_age);
            return user_age;
        }
        public static String get_user_email()
        {
            user_email = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "email");
            Console.WriteLine(user_email);
            return user_email;
        }




        public static bool checkIfIsPupil()
        {
            bool b = false;
            if (TEACHER_OBJ.name == "")
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }

        public static bool checkIsInClass()
        {
            bool b = false;
            if (PUPIL_OBJ.get_user_class() == "")
            {
                b = false;
            }
            else
            {
                b = true;
            }
            return b;
        }



    }
}
