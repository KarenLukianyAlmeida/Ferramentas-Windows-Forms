using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transportes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            transportes.Add(cb_carro);
            transportes.Add(cb_aviao);
            transportes.Add(cb_navio);
            transportes.Add(cb_onibus);
        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(CheckBox t in transportes)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcada ^_^");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox filhoCheckBox = new F_filhoCheckBox();
            filhoCheckBox.ShowDialog();
        }
    }
}
