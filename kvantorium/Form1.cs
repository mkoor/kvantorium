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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formMentor = new FormMentor();
            formMentor.Show();
        }

        private void buttonParticipant_Click(object sender, EventArgs e)
        {
            Form formParticipant = new FormParticipant();
            formParticipant.Show();
        }

        private void buttonAwards_Click(object sender, EventArgs e)
        {
            Form formAwards = new FormAwards();
            formAwards.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formSubdivision = new FormSubdivision();
            formSubdivision.Show();
        }

        private void buttonDirection_Click(object sender, EventArgs e)
        {
            Form formDirection = new FormDirection();
            formDirection.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formfilter = new FormFiltr();
            formfilter.Show();
        }
    }
    }

