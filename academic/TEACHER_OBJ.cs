using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace academic
{
    class TEACHER_OBJ
    {
        public static String name="";
        public static String pass = "";


        public static String teacher_class;
        public static String teacher_class_pw;
        public static String teacher_school;
        public static String tid;


        public static String get_teacher_class()
        {
            teacher_class = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_class");
            Console.WriteLine(teacher_class);
            return teacher_class;
        }
        public static String get_teacher_class_pw()
        {
            teacher_class_pw = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_class_pw");
            Console.WriteLine(teacher_class_pw);
            return teacher_class_pw;
        }
        public static String get_teacher_school()
        {
            teacher_school = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_school");
            Console.WriteLine(teacher_school);
            return teacher_school;
        }
        public static String get_tid()
        {
            tid = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "tid");
            Console.WriteLine(tid);
            return tid;
        }




        public static bool checkIfIsTeacher()
        {
            bool b = false;
            if (TEACHER_OBJ.name == "")
            {
                b= false;
            }
            else
            {
                b = true;
            }
            return b;
        }

        public static bool checkHasClass()
        {
            bool b = false;
            if (TEACHER_OBJ.get_teacher_class() == "")
            {
                b = false;
            } else
            {
                b = true;
            }
            return b;
        }



    }
}
