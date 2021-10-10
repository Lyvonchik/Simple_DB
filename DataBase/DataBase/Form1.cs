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
    public partial class Form1 : Form
    {
        List<FullName> fullNames;
        Form2 newForm = new Form2();
        const string PATH_TO_TXT = "fullname.txt";
        public Form1()
        {
            InitializeComponent();
            fullNames = new List<FullName>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myTextBoxes = {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text
            };

            bool isCorrect = true;
            foreach (var field in myTextBoxes)
            {
                if (field == "")
                {
                    MessageBox.Show("Заполните все поля для добавления");
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                fullNames.Add(new FullName(myTextBoxes[0], myTextBoxes[1], myTextBoxes[2]));

                UpdateListBoxes();
                ClearFields();

            }
        }

        void ClearFields()
        {
            newForm.listBox1.Text = "";
            newForm.listBox2.Text = "";
            newForm.listBox3.Text = "";
        }
        void UpdateListBoxes()
        {
            newForm.listBox1.Items.Clear();
            newForm.listBox2.Items.Clear();
            newForm.listBox3.Items.Clear();

            foreach (var fullName in fullNames)
            {
                newForm.listBox1.Items.Add(fullName.Name);
                newForm.listBox2.Items.Add(fullName.SurName);
                newForm.listBox3.Items.Add(fullName.SecondName);
            }
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm.Show();
        }

        private void спрятатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fullNames.RemoveAt(newForm.listBox1.SelectedIndex);
                UpdateListBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Serialize.SerializeToTxt(fullNames, PATH_TO_TXT);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = Deserialize.DeserializeTxt(PATH_TO_TXT);
            if (result != null)
            {
                fullNames.Clear();
                fullNames.AddRange(result);
            }
            UpdateListBoxes();
        }
    }
}
