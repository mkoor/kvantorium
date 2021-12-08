using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvantorium
{
    public partial class FormFiltr : Form
    {
        public FormFiltr()
        {
            InitializeComponent();
            
        }

        

        private void award_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.award_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kvantorium_dostizheniyaDataSet);

        }

        private void FormFiltr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.participant_table". При необходимости она может быть перемещена или удалена.
            this.participant_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.participant_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.level_table". При необходимости она может быть перемещена или удалена.
            this.level_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.level_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.mentor_table". При необходимости она может быть перемещена или удалена.
            this.mentor_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.mentor_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.direction_table". При необходимости она может быть перемещена или удалена.
            this.direction_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.direction_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.subdivision_table". При необходимости она может быть перемещена или удалена.
            this.subdivision_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.subdivision_table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kvantorium_dostizheniyaDataSet.award_table". При необходимости она может быть перемещена или удалена.
            this.award_tableTableAdapter.Fill(this.kvantorium_dostizheniyaDataSet.award_table);

        }

        private void buttonParticipant_Click(object sender, EventArgs e)
        {
            award_tableBindingSource.Filter = "[year] LIKE'" + textBox1.Text + "%'";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*award_tableBindingSource.Filter = "[id_subdivision] LIKE'" + comboBoxSubd.SelectedValue.ToString() + "%'";*/
        }

        private void award_tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                award_tableBindingSource.Filter = "id_subdivision = " + comboBoxSubd.SelectedValue.ToString();
            }
            else
            {
                award_tableBindingSource.Filter = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                award_tableBindingSource.Filter = "id_direction = " + comboBoxDir.SelectedValue.ToString();
            }
            else
            {
                award_tableBindingSource.Filter = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                award_tableBindingSource.Filter = "id_mentor = " + comboBoxMen.SelectedValue.ToString();
            }
            else
            {
                award_tableBindingSource.Filter = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                award_tableBindingSource.Filter = "id_level_ev = " + comboBoxLev.SelectedValue.ToString();
            }
            else
            {
                award_tableBindingSource.Filter = "";
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                award_tableBindingSource.Filter = "id_participant = " + comboBoxPar.SelectedValue.ToString();
            }
            else
            {
                award_tableBindingSource.Filter = "";
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.award_tableTableAdapter.FillBy(this.kvantorium_dostizheniyaDataSet.award_table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.award_tableTableAdapter.FillBy(this.kvantorium_dostizheniyaDataSet.award_table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.award_tableTableAdapter.FillBy(this.kvantorium_dostizheniyaDataSet.award_table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.award_tableTableAdapter.FillBy(this.kvantorium_dostizheniyaDataSet.award_table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
