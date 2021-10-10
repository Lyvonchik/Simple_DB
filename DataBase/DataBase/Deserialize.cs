using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    class Deserialize
    {
        public static List<FullName> DeserializeTxt(string path)
        {
            try
            {
                List<FullName> students = new List<FullName>();
                using(StreamReader sr = new StreamReader(path))
                {
                    int i = 0;
                    string[] fields = new string[3];
                    while(sr.Peek() >= 0)
                    {
                        fields[i] = sr.ReadLine();
                        if (i==2)
                        {
                            students.Add(new FullName(fields[0], fields[1], fields[2]));
                            i = 0;
                            continue;
                        }
                        i++;
                    }
                }
                return students;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении txt");
                return null;
            }
        }
    }
}
