using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEventos
{
    public partial class Form1 : Form
    {
        private GerenciadorLatidos latidos;
        public Form1()
        {
            InitializeComponent();
            latidos = new GerenciadorLatidos();
            latidos.ExcDecibeisEvent += QndExcDecibeis;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          progressBar1.Value = latidos.Latir(); 
        }

        private void QndExcDecibeis(object sender, CustomEvent e)
        {
            MessageBox.Show(string.Format("O cachorro tá latindo muito, com {0} decibeis", e.IntensidadeLatido, "Excesso Decibies", MessageBoxButtons.OK, MessageBoxIcon.Warning));
        }
    }
}
