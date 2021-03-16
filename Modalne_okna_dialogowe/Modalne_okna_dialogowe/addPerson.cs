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
    public partial class addPerson : Form
    {
        public addPerson()
        {
            InitializeComponent();
            Data = new string[4];
        }

        public string[] Data { get; set; }

        public string ButtonName
        {
            get
            {
                return OKButton.Text;
            }
            set
            {
                OKButton.Text = value;
            }
        }

        public void SetData(string name, string surname, string birthYear, string town)
        {
            nameTextBox.Text = name;
            surnameTextBox.Text = surname;
            birthYearTextBox.Text = birthYear;
            townTextBox.Text = town;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Data[0] = nameTextBox.Text;
            Data[1] = surnameTextBox.Text;
            Data[2] = birthYearTextBox.Text;
            Data[3] = townTextBox.Text;
        }
    }
}
