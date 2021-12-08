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
    public partial class FormSubdivision : Form
    {
        public FormSubdivision()
        {
            InitializeComponent();
            ShowSub();
        }

        void ShowSub()
        {
            listViewSub.Items.Clear();

            foreach (subdivision_table subdivision in Program.kv.subdivision_table)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        subdivision.id_subdivision.ToString(), subdivision.name
                });
                item.Tag = subdivision;
                listViewSub.Items.Add(item);
            }
            listViewSub.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSub.SelectedItems.Count == 1)
            {
                subdivision_table subdivision = listViewSub.SelectedItems[0].Tag as subdivision_table;

                textBoxName.Text = subdivision.name;

            }
            else
            {
                textBoxName.Text = "";

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                subdivision_table subdivision = new subdivision_table();


                subdivision.name = textBoxName.Text;

                if (subdivision.name == "" )
                {
                    throw new Exception("Поля не заполнены!");
                }

                Program.kv.subdivision_table.Add(subdivision);
                Program.kv.SaveChanges();
                ShowSub();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSub.SelectedItems.Count == 1)
            {
                try
                {
                    subdivision_table subdivision = listViewSub.SelectedItems[0].Tag as subdivision_table;
                    subdivision.name = Convert.ToString(textBoxName.Text);
                  

                    if (textBoxName.Text == "" )
                    {
                        throw new Exception("Название не заполнено!");
                    }
                    Program.kv.SaveChanges();
                    ShowSub();

                }
                catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSub.SelectedItems.Count == 1)
                {
                    subdivision_table subdivision = listViewSub.SelectedItems[0].Tag as subdivision_table;
                    Program.kv.subdivision_table.Remove(subdivision);
                    Program.kv.SaveChanges();
                    ShowSub();
                }

                textBoxName.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
    }
    

