using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace academic
{
    class TEACHER_OBJ
    {
        /// <summary>
        /// Var teacher_name
        /// </summary>
        public static String name="";

        /// <summary>
        /// Var pass_name
        /// </summary>
        public static String pass = "";

        // teacher_vars
            public static String teacher_class;
            public static String teacher_class_pw;
            public static String teacher_school;
            public static String tid;

        /// <summary>
        /// Methode for getting teacher_class
        /// </summary>
        /// <returns></returns>
        public static String get_teacher_class()
        {
            teacher_class = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_class");
            Console.WriteLine(teacher_class);
            return teacher_class;
        }

        /// <summary>
        /// Methode for getting teacher_class_pw
        /// </summary>
        /// <returns></returns>
        public static String get_teacher_class_pw()
        {
            teacher_class_pw = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_class_pw");
            Console.WriteLine(teacher_class_pw);
            return teacher_class_pw;
        }

        /// <summary>
        /// Methode for getting teacher_school
        /// </summary>
        /// <returns></returns>
        public static String get_teacher_school()
        {
            teacher_school = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_school");
            Console.WriteLine(teacher_school);
            return teacher_school;
        }

        /// <summary>
        /// Methode for getting teacher_id
        /// </summary>
        /// <returns></returns>
        public static String get_tid()
        {
            tid = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "tid");
            Console.WriteLine(tid);
            return tid;
        }

        /// <summary>
        /// Methode for check if is teacher
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Methode for check if teacher has class
        /// </summary>
        /// <returns></returns>
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
