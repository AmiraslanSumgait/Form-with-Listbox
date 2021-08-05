using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Form_with_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>
            {
                new User("Kamal","Eliyev","kamaleliyev@gmail.com","+99455123213",DateTime.Now),
                new User("Nebi","Nebili","nebili@gmail.com","994552555432",new DateTime(2002,10,20))

            };
        private void Form1_Load(object sender, EventArgs e)
        {
            lstbox_User.DisplayMember = "Name";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           
            if (btn_Add.Text == "Add")
            {
                User user = new User();
                int check = 0;
                if (!Regex.IsMatch(txtBox_Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    MessageBox.Show("Valid Email");
                    txtBox_Email.Text = "";
                }
                if (dtPicker_BirthDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Birthdate is incorrect!!");
                    ++check;
                }
                if (string.IsNullOrWhiteSpace(txtBox_Name.Text) || string.IsNullOrWhiteSpace(txtBox_Surname.Text) ||
                    string.IsNullOrWhiteSpace(txtBox_Email.Text) || string.IsNullOrWhiteSpace(txtBox_Phone.Text))
                {
                    MessageBox.Show("Please fill all of the cridentials!!!" ,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (check == 0)
                    {
                        user.Name = txtBox_Name.Text;
                        user.Surname = txtBox_Surname.Text;
                        user.Email = txtBox_Email.Text;
                        user.Phone = txtBox_Phone.Text;
                        user.BirthDate = dtPicker_BirthDate.Value;
                        lstbox_User.Items.Add(user);
                        users.Add(user);
                    }
                   
                }
            }
            else if (btn_Add.Text == "Change")
            {
                var changeUSer = lstbox_User.SelectedItem as User;
                changeUSer.Name = txtBox_Name.Text;
                changeUSer.Surname = txtBox_Surname.Text;
                changeUSer.Email = txtBox_Email.Text;
                changeUSer.Phone = txtBox_Phone.Text;
                changeUSer.BirthDate = dtPicker_BirthDate.Value;
                lstbox_User.DisplayMember = "Name";
                MessageBox.Show("Changed succesfully");
                btn_Add.Text = "Add";
            }
        }
        
        private void lstbox_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Add.Text = "Change";
            User user = lstbox_User.SelectedItem as User;
            txtBox_Name.Text = user.Name;
            txtBox_Surname.Text = user.Surname;
            txtBox_Email.Text = user.Email;
            txtBox_Phone.Text = user.Phone;
            dtPicker_BirthDate.Value = user.BirthDate;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            btn_Add.Text = "Add";
            
            if (!string.IsNullOrWhiteSpace(txtBox_FileName.Text))
            {
                List<User> users = new List<User>();
                foreach (var item in lstbox_User.Items)
                {
                    users.Add(item as User);
                }
                var fileName = txtBox_FileName.Text + ".json";
                File.WriteAllText(fileName, JsonConvert.SerializeObject(users, Formatting.Indented));
                MessageBox.Show("Succesfull saved");
            }
            else
            {
                MessageBox.Show("Please write file name before saved");
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_FileName.Text))
            {
                if (File.Exists(txtBox_FileName.Text + ".json"))
                {
                    var userText = File.ReadAllText(txtBox_FileName.Text+".json");
                    List<User> loadUsers = JsonConvert.DeserializeObject<List<User>>(userText);
                    foreach (var user in loadUsers)
                    {
                        lstbox_User.Items.Add(user);
                    }
                    MessageBox.Show("Succesfully loaded", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("File is not found", "Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please write file name which file you want loaded","Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBox_Name_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtBox_Name.Text, @"^[\p{L} \.\-]+$"))
            {
                txtBox_Name.Text = "";
            }
        }
        private void txtBox_Surname_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtBox_Surname.Text, @"^[\p{L} \.\-]+$"))
            {
                txtBox_Surname.Text = "";
            }
        }
    }
}
