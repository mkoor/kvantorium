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
    public partial class FormAwards : Form
    {
        public FormAwards()
        {
            InitializeComponent();
            ShowParticipant();
            ShowDirection();
            ShowMentor();
            ShowSubdivision();
            ShowLevel_ev();
            ShowAwards();
        }

        void ShowAwards()
        {
            listViewAwards.Items.Clear();
            foreach (award_table award in Program.kv.award_table)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    award.id_award.ToString()+".",
                    award.participant_table.lastname+" "+award.participant_table.firstname,
                    award.direction_table.title,
                    award.mentor_table.lastname + " " + award.mentor_table.firstname.Remove(1) + ". "
                    + award.mentor_table.middlename.Remove(1) + ".",
                    award.subdivision_table.name,
                    award.level_table.level_ev,
                    award.name,
                    award.year,
                    award.result
                });
                item.Tag = award;
                listViewAwards.Items.Add(item);
            }
            listViewAwards.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowParticipant()
        {
            comboBoxParticipant.Items.Clear();
            foreach (participant_table participant in Program.kv.participant_table)
            {
                string[] item = {participant.id_participant.ToString() + ". " + participant.lastname+
                        " ", participant.firstname};
                comboBoxParticipant.Items.Add(string.Join(" ", item));
            }
        }

        void ShowDirection()
        {
            comboBoxDirection.Items.Clear();
            foreach (direction_table direction in Program.kv.direction_table)
            {
                string[] item = {direction.id_direction.ToString() + ". " + direction.title };
                comboBoxDirection.Items.Add(string.Join(" ", item));
            }
        }

        void ShowMentor()
        {
            comboBoxMentor.Items.Clear();
            foreach (mentor_table mentor in Program.kv.mentor_table)
            {
                string[] item = {mentor.id_mentor.ToString() + ". " + mentor.lastname + " " + mentor.firstname + " " + mentor.middlename };
                comboBoxMentor.Items.Add(string.Join(" ", item));
            }
        }

        void ShowSubdivision()
        {
            comboBoxSubdivision.Items.Clear();
            foreach (subdivision_table subdivision in Program.kv.subdivision_table)
            {
                string[] item = {subdivision.id_subdivision.ToString() + ". " + subdivision.name };
                comboBoxSubdivision.Items.Add(string.Join(" ", item));
            }
        }

        void ShowLevel_ev()
        {
            comboBoxLevelEv.Items.Clear();
            foreach (level_table level in Program.kv.level_table)
            {
                string[] item = {level.id_level_ev.ToString() + ". " + level.level_ev };
                comboBoxLevelEv.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                award_table award = new award_table();

                if (comboBoxDirection.SelectedItem == null || comboBoxLevelEv.SelectedItem == null || comboBoxMentor.SelectedItem 
                    == null || comboBoxParticipant.SelectedItem == null || comboBoxSubdivision.SelectedItem == null
                    || textBoxName.Text == "" || textBoxYear.Text == "")
                {
                    throw new Exception("Обязательные данные не заполнены");
                }
                else
                {
                    award.id_direction = Convert.ToInt32(comboBoxDirection.SelectedItem.ToString().Split('.')[0]);
                    award.id_level_ev = Convert.ToInt32(comboBoxLevelEv.SelectedItem.ToString().Split('.')[0]);
                    award.id_mentor = Convert.ToInt32(comboBoxMentor.SelectedItem.ToString().Split('.')[0]);
                    award.id_participant = Convert.ToInt32(comboBoxParticipant.SelectedItem.ToString().Split('.')[0]);
                    award.id_subdivision = Convert.ToInt32(comboBoxSubdivision.SelectedItem.ToString().Split('.')[0]);
                    award.name = textBoxName.Text;
                    award.year = textBoxYear.Text;
                    award.result = textBoxResult.Text;
                }

                Program.kv.award_table.Add(award);
                Program.kv.SaveChanges();
                ShowAwards();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAwards.SelectedItems.Count == 1)
                {
                    award_table award = listViewAwards.SelectedItems[0].Tag as award_table;

                    if (comboBoxDirection.SelectedItem == null || comboBoxLevelEv.SelectedItem == null || comboBoxMentor.SelectedItem
                    == null || comboBoxParticipant.SelectedItem == null || comboBoxSubdivision.SelectedItem == null
                    || textBoxName.Text == "" || textBoxYear.Text == "")
                    {
                        throw new Exception("Обязательные данные не заполнены");
                    }
                    else
                    {
                        award.id_direction = Convert.ToInt32(comboBoxDirection.SelectedItem.ToString().Split('.')[0]);
                        award.id_level_ev = Convert.ToInt32(comboBoxLevelEv.SelectedItem.ToString().Split('.')[0]);
                        award.id_mentor = Convert.ToInt32(comboBoxMentor.SelectedItem.ToString().Split('.')[0]);
                        award.id_participant = Convert.ToInt32(comboBoxParticipant.SelectedItem.ToString().Split('.')[0]);
                        award.id_subdivision = Convert.ToInt32(comboBoxSubdivision.SelectedItem.ToString().Split('.')[0]);
                        award.name = textBoxName.Text;
                        award.year = textBoxYear.Text;
                        award.result = textBoxResult.Text;
                    }
                    Program.kv.SaveChanges();
                    ShowAwards();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAwards.SelectedItems.Count == 1)
                {
                    award_table award = listViewAwards.SelectedItems[0].Tag as award_table;

                    Program.kv.award_table.Remove(award);
                    Program.kv.SaveChanges();
                    ShowAwards();
                }
                comboBoxDirection.SelectedItem = null;
                comboBoxLevelEv.SelectedItem = null;
                comboBoxMentor.SelectedItem = null;
                comboBoxParticipant.SelectedItem = null;
                comboBoxSubdivision.SelectedItem = null;
                textBoxName.Text = "";
                textBoxResult.Text = "";
                textBoxYear.Text = "";   
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAwards_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewAwards.SelectedItems.Count == 1)
            {
                award_table award = listViewAwards.SelectedItems[0].Tag as award_table;

                comboBoxParticipant.Text = award.participant_table.id_participant.ToString()
                    + ". " + award.participant_table.lastname + " " + award.participant_table.firstname;
                comboBoxDirection.Text = award.direction_table.id_direction.ToString() +
                    ". " + award.direction_table.title;
                comboBoxMentor.Text = award.mentor_table.id_mentor.ToString()
                    + ". " + award.mentor_table.lastname + " " + award.mentor_table.firstname.Remove(1)
                    + ". " + award.mentor_table.middlename.Remove(1);
                comboBoxSubdivision.Text = award.subdivision_table.id_subdivision.ToString() +
                    ". " + award.subdivision_table.name;
                comboBoxLevelEv.Text = award.level_table.id_level_ev.ToString() +
                    ". " + award.level_table.level_ev;
                textBoxName.Text = award.name;
                textBoxYear.Text = award.year.ToString();
                textBoxResult.Text = award.result;

            }
            else
            {
                comboBoxDirection.SelectedItem = null;
                comboBoxLevelEv.SelectedItem = null;
                comboBoxMentor.SelectedItem = null;
                comboBoxParticipant.SelectedItem = null;
                comboBoxSubdivision.SelectedItem = null;
                textBoxName.Text = "";
                textBoxResult.Text = "";
                textBoxYear.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
               
        private void awardbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void award_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.award_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kvantorium_dostizheniyaDataSet);

        }

        private void FormAwards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.award_table". При необходимости она может быть перемещена или удалена.
            this.award_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.award_table);

        }

    
        private void comboBoxSubdivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            Form filtrForm = new FormFiltr();
            filtrForm.Show();
        }
    }
}

