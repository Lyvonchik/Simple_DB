using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DataBase
{
    class Serialize
    {
        public static void SerializeToTxt(List<FullName> fullNames, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (var fullName in fullNames)
                    {
                        sw.WriteLine(fullName.Name);
                        sw.WriteLine(fullName.SurName);
                        sw.WriteLine(fullName.SecondName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в txt");
            }
        }
    }
}
