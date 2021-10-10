using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form2 : Form
    {
        List<FullName> fullNames;
        const string PATH_TO_TXT = "fullname.txt";
        public Form2()
        {
            InitializeComponent();
            fullNames = new List<FullName>();
        }
    }
}