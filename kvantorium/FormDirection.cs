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
    public partial class FormDirection : Form
    {
        public FormDirection()
        {
            InitializeComponent();
            ShowDir();
        }

        void ShowDir()
        {
            listViewDir.Items.Clear();

            foreach (direction_table direction in Program.kv.direction_table)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        direction.id_direction.ToString(), direction.title
                });
                item.Tag = direction;
                listViewDir.Items.Add(item);
            }
            listViewDir.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDir.SelectedItems.Count == 1)
            {
                direction_table direction = listViewDir.SelectedItems[0].Tag as direction_table;

                textBoxTitle.Text = direction.title;
            }
            else
            {
                textBoxTitle.Text = "";

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                direction_table direction = new direction_table();


                direction.title = textBoxTitle.Text;

                if (direction.title == "")
                {
                    throw new Exception("Поля не заполнены!");
                }

                Program.kv.direction_table.Add(direction);
                Program.kv.SaveChanges();
                ShowDir();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDir.SelectedItems.Count == 1)
            {
                try
                {
                    direction_table direction = listViewDir.SelectedItems[0].Tag as direction_table;
                    direction.title = Convert.ToString(textBoxTitle.Text);


                    if (textBoxTitle.Text == "")
                    {
                        throw new Exception("Название не заполнено!");
                    }
                    Program.kv.SaveChanges();
                    ShowDir();

                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDir.SelectedItems.Count == 1)
                {
                    direction_table direction = listViewDir.SelectedItems[0].Tag as direction_table;
                    Program.kv.direction_table.Remove(direction);
                    Program.kv.SaveChanges();
                    ShowDir();
                }

                textBoxTitle.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
    }
    
