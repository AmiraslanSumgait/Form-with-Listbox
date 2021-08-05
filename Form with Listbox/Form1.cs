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
           
            //lstbox_User.DataSource = users;
           // lstbox_User.SelectionMode = SelectionMode.MultiSimple;
            lstbox_User.DisplayMember = "Name";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           
            if (btn_Add.Text == "Add")
            {
                User user = new User();
                //if (!Regex.IsMatch(txtBox_Email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                //{
                //    MessageBox.Show("Valid Email");
                //    txtBox_Email.Text = "";
                //}
                if (string.IsNullOrWhiteSpace(txtBox_Name.Text) || string.IsNullOrWhiteSpace(txtBox_Surname.Text) ||
                    string.IsNullOrWhiteSpace(txtBox_Email.Text) || string.IsNullOrWhiteSpace(txtBox_Phone.Text))
                {
                    MessageBox.Show("Please fill all of the cridentials!!!");
                }
                else
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
            else if (btn_Add.Text == "Change")
            {
                MessageBox.Show("Aa");
                int index = lstbox_User.SelectedIndex;
                    (lstbox_User.SelectedItem as User).Name = txtBox_Name.Text;
                    (lstbox_User.SelectedItem as User).Surname = txtBox_Surname.Text;
                    (lstbox_User.SelectedItem as User).Email = txtBox_Email.Text;
                    (lstbox_User.SelectedItem as User).Phone = txtBox_Phone.Text;
                MessageBox.Show(lstbox_User.Items[0].ToString());
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

            
        }

        ///private void txtBox_Name_MouseClick(object sender, MouseEventArgs e)
        //{

        //}

        //private void txtBox_Name_Click(object sender, EventArgs e)
        //{
        //    btn_Add.Text = "Add";
        //}

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
                }
                else
                {
                    MessageBox.Show("File is not found");
                }
            }
            else
            {
                MessageBox.Show("Please write file name whicg file you want loaded");
            }
        }
    }
}
