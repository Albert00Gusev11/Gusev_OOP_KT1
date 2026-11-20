using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gusev_OOP_KT1
{
    public partial class AG_Main : Form
    {
        public AG_Main()
        {
            InitializeComponent();
        }
        AG_tervitus lause = new AG_tervitus();

        private void AG_Main_Load(object sender, EventArgs e)
        {
            lause.nimi = AG_txt1.Text;
            AG_out1.Text = lause.tere();
            AG_txt1.Focus();
        }

        private void AG_btn1_Click(object sender, EventArgs e)
        {
            lause.nimi = AG_txt1.Text;
            AG_out1.Text = lause.tere();
            AG_txt1.Text = "";
            AG_txt1.Focus();
        }

        private void AG_btn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want exit this project?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void AG_btn3_Click(object sender, EventArgs e)
        {
            AG_summa arvu = new AG_summa();

            try
            {
                arvu.Arv1 = Convert.ToSingle(AG_txt2.Text);
                arvu.Arv2 = Convert.ToSingle(AG_txt3.Text);

                if (AG_chk1.Checked)
                {
                    arvu.tehing = "+";
                }
                else
                {
                    arvu.tehing = "-";
                }

                Single tulemused = arvu.arvutus();
                AG_out2.Text = Convert.ToSingle(arvu.Arv1) + arvu.tehing + Convert.ToSingle(arvu.Arv2) + " = " + Convert.ToString(tulemused);
            }
            catch
            {
                AG_out2.Text = "";
                MessageBox.Show("Sissege arvud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AG_chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (AG_chk1.Checked == true)
                AG_chk1.Text = "Summa";
            else
                AG_chk1.Text = "Erinevus";
        }

        private void AG_btn4_Click(object sender, EventArgs e)
        {
            if (AG_rbt1.Checked)
            {
                this.BackColor = Color.FromArgb(55, 30, 30);

                AG_grb1.BackColor = Color.FromArgb(55, 30, 30);
                AG_grb2.BackColor = Color.FromArgb(55, 30, 30);
                AG_grb3.BackColor = Color.FromArgb(55, 30, 30);
                AG_out1.BackColor = Color.FromArgb(55, 30, 30);
                AG_out2.BackColor = Color.FromArgb(55, 30, 30);
                AG_btn1.BackColor = Color.FromArgb(55, 30, 30);
                AG_btn2.BackColor = Color.FromArgb(55, 30, 30);
                AG_btn3.BackColor = Color.FromArgb(55, 30, 30);
                AG_btn4.BackColor = Color.FromArgb(55, 30, 30);
                AG_btn5.BackColor = Color.FromArgb(55, 30, 30);
                AG_txt1.BackColor = Color.FromArgb(120, 34, 34);
                AG_txt2.BackColor = Color.FromArgb(120, 34, 34);
                AG_txt3.BackColor = Color.FromArgb(120, 34, 34);
            }
            else if (AG_rbt2.Checked)
            {
                this.BackColor = Color.FromArgb(30, 45, 65);

                AG_grb1.BackColor = Color.FromArgb(30, 45, 65);
                AG_grb2.BackColor = Color.FromArgb(30, 45, 65);
                AG_grb3.BackColor = Color.FromArgb(30, 45, 65);
                AG_out1.BackColor = Color.FromArgb(30, 45, 65);
                AG_out2.BackColor = Color.FromArgb(30, 45, 65);
                AG_btn1.BackColor = Color.FromArgb(30, 45, 65);
                AG_btn2.BackColor = Color.FromArgb(30, 45, 65);
                AG_btn3.BackColor = Color.FromArgb(30, 45, 65);
                AG_btn4.BackColor = Color.FromArgb(30, 45, 65);
                AG_btn5.BackColor = Color.FromArgb(30, 45, 65);
                AG_txt1.BackColor = Color.FromArgb(55, 100, 145);
                AG_txt2.BackColor = Color.FromArgb(55, 100, 145);
                AG_txt3.BackColor = Color.FromArgb(55, 100, 145);
            }
            else
            {
                MessageBox.Show("Vali värv!", "Form Color", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void AG_btn5_Click(object sender, EventArgs e)
        {
            AG_rbt1.Checked = false;
            AG_rbt2.Checked = false;

            this.BackColor = SystemColors.ControlDarkDark;

            AG_grb1.BackColor = SystemColors.ControlDarkDark;
            AG_grb2.BackColor = SystemColors.ControlDarkDark;
            AG_grb3.BackColor = SystemColors.ControlDarkDark;
            AG_out1.BackColor = SystemColors.ControlDarkDark;
            AG_out2.BackColor = SystemColors.ControlDarkDark;
            AG_btn1.BackColor = SystemColors.ControlDarkDark;
            AG_btn2.BackColor = SystemColors.ControlDarkDark;
            AG_btn3.BackColor = SystemColors.ControlDarkDark;
            AG_btn4.BackColor = SystemColors.ControlDarkDark;
            AG_btn5.BackColor = SystemColors.ControlDarkDark;
            AG_txt1.BackColor = SystemColors.ControlDark;
            AG_txt2.BackColor = SystemColors.ControlDark;
            AG_txt3.BackColor = SystemColors.ControlDark;
        }
    }
}
