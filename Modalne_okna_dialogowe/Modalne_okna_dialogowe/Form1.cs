using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modalne_okna_dialogowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        List<Person> personList = new List<Person>();

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            addPerson myDialog = new addPerson();
            
            if (myDialog.ShowDialog(this) == DialogResult.OK)
            {
                personList.Add(new Person(myDialog.Data[0], myDialog.Data[1], myDialog.Data[2], myDialog.Data[3]));
                personListListBox.Items.Clear();
                foreach (var per in personList)
                {
                    personListListBox.Items.Add(per.Name + ", " + per.Surname + ", " + per.BirthYear + ", " + per.Town);
                }
                editButton.Enabled = true;
            }            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = personList[personListListBox.SelectedIndex].Name;
                string surname = personList[personListListBox.SelectedIndex].Surname;
                string birthYear = personList[personListListBox.SelectedIndex].BirthYear;
                string town = personList[personListListBox.SelectedIndex].Town;

                addPerson myDialog = new addPerson();

                myDialog.SetData(name, surname, birthYear, town);

                myDialog.Text = "Edytowanie osoby";
                myDialog.ButtonName = "Edytuj";

                if (myDialog.ShowDialog(this) == DialogResult.OK)
                {

                    personList[personListListBox.SelectedIndex].Name = myDialog.Data[0];
                    personList[personListListBox.SelectedIndex].Surname = myDialog.Data[1];
                    personList[personListListBox.SelectedIndex].BirthYear = myDialog.Data[2];
                    personList[personListListBox.SelectedIndex].Town = myDialog.Data[3];

                    personListListBox.Items.Clear();
                    foreach (var per in personList)
                    {
                        personListListBox.Items.Add(per.Name + ", " + per.Surname + ", " + per.BirthYear + ", " + per.Town);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nie wybrałeś danych osoby z listy, które chcesz edytować!");
            }
        }
    }
}
