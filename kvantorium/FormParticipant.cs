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
    public partial class FormParticipant : Form
    {
        public FormParticipant()
        {
            InitializeComponent();
            ShowParticipant();
        }

        private void pictureBoxEsoft_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                participant_table participant = new participant_table();


                participant.firstname = textBoxFirstName.Text;
                participant.lastname = textBoxLastName.Text;

                if (participant.firstname == "" || participant.lastname == "")
                {
                    throw new Exception("Поля не заполнены!");
                }

                Program.kv.participant_table.Add(participant);
                Program.kv.SaveChanges();
                ShowParticipant();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    

        private void listViewParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewParticipant.SelectedItems.Count == 1)
            {
                participant_table participant = listViewParticipant.SelectedItems[0].Tag as participant_table;
                textBoxFirstName.Text = participant.firstname;
                textBoxLastName.Text = participant.lastname;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";              
            }
        }

        void ShowParticipant()
        {
            listViewParticipant.Items.Clear();

            foreach (participant_table participant in Program.kv.participant_table)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        participant.id_participant.ToString(), participant.firstname, participant.lastname
                });
                item.Tag = participant;
                listViewParticipant.Items.Add(item);
            }
            listViewParticipant.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewParticipant.SelectedItems.Count == 1)
            {
                try
                {
                    participant_table participant = listViewParticipant.SelectedItems[0].Tag as participant_table;
                    participant.firstname = Convert.ToString(textBoxFirstName.Text);
                    participant.lastname = Convert.ToString(textBoxLastName.Text);
                    
                    if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
                    {
                        throw new Exception("ФИ не заполнено!");
                    }

                    Program.kv.SaveChanges();
                    ShowParticipant();

                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewParticipant.SelectedItems.Count == 1)
                {
                    participant_table participant = listViewParticipant.SelectedItems[0].Tag as participant_table;
                    Program.kv.participant_table.Remove(participant);
                    Program.kv.SaveChanges();
                    ShowParticipant();
                }

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void listViewParticipant_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewParticipant.SelectedItems.Count == 1)
            {
                participant_table participant = listViewParticipant.SelectedItems[0].Tag as participant_table;

                textBoxLastName.Text = participant.lastname;
                textBoxFirstName.Text = participant.firstname;
                
            }
            else
            {
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
               
            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
