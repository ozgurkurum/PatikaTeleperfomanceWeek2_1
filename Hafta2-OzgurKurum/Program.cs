using System;
using System.Reflection;

namespace Hafta2_OzgurKurum
{
    public class Program
    {
        public static void Main(string[] args)
        {
        #region Extension   
        start:
            try
            {
                Console.WriteLine("Bir tarih giriniz (Format Yıl-Ay-Gün şeklinde olmalıdır)");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(date.DifferenceDate()); 
            }
            catch 
            {
                Console.WriteLine("Girilen format yanlış");
                goto start;
            }
            Console.ReadLine();
            #endregion

            #region Attribute
            Student s = new Student();
            s.Id = 1;
            s.Name = "Ozgur";
            Control(s);

            bool Control(Student student)
            {
                Type type = student.GetType();

                foreach (var item in type.GetFields())
                {
                   object[] attributes = item.GetCustomAttributes(typeof(ColumnAttribute),true);

                    if (attributes.Length != 0)
                    {
                        var value = item.GetValue(student);
                        if (value.GetType() == typeof(Int32))
                        {
                            if ((int)value == 0)
                            {
                                return false;
                            }
                        }

                        if (value == null)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            #endregion
        }
    }
}
