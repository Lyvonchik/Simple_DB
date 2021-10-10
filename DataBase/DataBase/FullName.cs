using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    [Serializable]
    class FullName
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string SecondName { get; set; }

        public FullName() { }
        public FullName(string name, string surname, string secondName)
        {
            this.Name = name;
            this.SurName = surname;
            this.SecondName = secondName;
        }
    }
}
