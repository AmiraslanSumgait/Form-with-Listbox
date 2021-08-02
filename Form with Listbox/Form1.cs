using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            lstbox_User.SelectionMode = SelectionMode.MultiExtended;
            lstbox_User.DisplayMember = "Name";

            Button buttonDynamic = new Button
            {
                Text = "Dynamic",
                Visible = true,
                BackColor = Color.Red
            };

           
            buttonDynamic.Location = new Point(220,300);

            this.Controls.Add(buttonDynamic);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            User user = new User();
            if(string.IsNullOrWhiteSpace(txtBox_Name.Text)|| string.IsNullOrWhiteSpace(txtBox_Surname.Text)||
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
        
        private void lstbox_User_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            btn_Add.Text = "Change";
            btn_Add.Dispose();
            Button buttonDynamic = new Button
            {
                Text = "Dynamic",
                Visible = true,
                Enabled=true,
                BackColor = Color.Red,
               
            };
            buttonDynamic.Location = new Point(1, 1);
            this.Controls.Add(buttonDynamic);

            //Button btn_Change = 
            btn_Add.Click += Btn_Add_Click;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (lstbox_User.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please change one user cridentials");
            }
            else
            {
                MessageBox.Show("Aqqq abe");
            }
        }
    }
}
