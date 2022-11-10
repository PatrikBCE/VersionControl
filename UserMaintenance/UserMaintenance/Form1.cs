using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName;
            lblFirstName.Text = Resource1.FirstName;
            btnAdd.Text = Resource1.Add;
            btnSave.Text = Resource1.Save;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()

            {
                FullName = txtLastName.Text,
                //FirstnName = txtFirstName.Text,
            };
            users.Add(u);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var SaveFileDialog = new SaveFileDialog();

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var FileName = SaveFileDialog.FileName;

                using (var sw = new StreamWriter(FileName))
                {
                    foreach (var item in users)
                    {
                        sw.Write(item.ID.ToString());
                        sw.Write(" - ");
                        sw.WriteLine(item.FullName);
                    }
                    sw.Close();
                }
            }
        }
    }
}
