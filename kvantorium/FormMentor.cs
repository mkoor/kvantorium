using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvantorium
{
    public partial class FormMentor : Form
    {
        public FormMentor()
        {
            InitializeComponent();
            ShowMentor();
        }

        void ShowMentor()
        {
            listViewMentor.Items.Clear();

            foreach (mentor_table mentor in Program.kv.mentor_table)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        mentor.id_mentor.ToString(), mentor.firstname, mentor.lastname, mentor.middlename
                });
                item.Tag = mentor;
                listViewMentor.Items.Add(item);
            }
            listViewMentor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                mentor_table mentor = new mentor_table();


                mentor.firstname = textBoxFirstName.Text;
                mentor.lastname = textBoxLastName.Text;
                mentor.middlename = textBoxMiddlename.Text;

                if (mentor.firstname == "" || mentor.lastname == "" || mentor.middlename =="")
                {
                    throw new Exception("Поля не заполнены!");
                }

                Program.kv.mentor_table.Add(mentor);
                Program.kv.SaveChanges();
                ShowMentor();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMentor.SelectedItems.Count == 1)
            {
                try
                {
                    mentor_table mentor = listViewMentor.SelectedItems[0].Tag as mentor_table;
                    mentor.firstname = Convert.ToString(textBoxFirstName.Text);
                    mentor.lastname = Convert.ToString(textBoxLastName.Text);
                    mentor.middlename = Convert.ToString(textBoxMiddlename.Text);

                    if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxMiddlename.Text =="")
                    {
                        throw new Exception("ФИО не заполнено!");
                    }

                    Program.kv.SaveChanges();
                    ShowMentor();

                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMentor.SelectedItems.Count == 1)
                {
                    mentor_table mentor = listViewMentor.SelectedItems[0].Tag as mentor_table;
                    Program.kv.mentor_table.Remove(mentor);
                    Program.kv.SaveChanges();
                    ShowMentor();
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddlename.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void listViewMentor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (listViewMentor.SelectedItems.Count == 1)
                {
                    mentor_table mentor = listViewMentor.SelectedItems[0].Tag as mentor_table;

                    textBoxLastName.Text = mentor.lastname;
                textBoxFirstName.Text = mentor.firstname;
                textBoxMiddlename.Text = mentor.middlename;
                }
                else
                {
                    textBoxLastName.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxMiddlename.Text = "";
                }
            
        }
    }
    }

    

