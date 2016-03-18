using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP_125
{
    public partial class Form1 : Form
    {
        LoadSave<UserInfo> loadSave = new LoadSave<UserInfo>();

        public Form1()
        {
            InitializeComponent();
            Load();
        }

        // reference of current user
        UserInfo currentUser;

        // When playerButton is pressed, set values of currentUser
        // pass info into serialize function we created
        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            currentUser = new UserInfo(UserName.Text, AnimalBox.SelectedItem.ToString());
            loadSave.Serialize("UserInfo", currentUser);

            var gameForm = new Form2();
            this.Hide();
            gameForm.Show();
        }

        private void Load()
        {
            currentUser = loadSave.Deserialization("UserInfo");
            UserName.Text = currentUser.Name;
            AnimalBox.Text = currentUser.Animal;
        }
    }
}
