using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Veiculos : Form
    {
        F_Principal fp;
        public F_Veiculos(String v,F_Principal f)
        {
            InitializeComponent();
            
            tb_listaVeiculos.Text = v;

            f.num = 10;
            fp = f;
            
        }
        private void F_Veiculos_FormClosed(object sender, EventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
