using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recrutamento
{
    public partial class Form2 : Form
    {
        public string nomeSala01 = "";
        public string nomeSala02 = "";
        public int lotSala01;
        public int lotSala02;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastrarSalas_Click(object sender, EventArgs e)
        {

            nomeSala01 = txtNomeSala01.Text;
            lotSala01 = int.Parse(txtLotacaoSala01.Text);
            nomeSala02 = txtNoomeSala02.Text;
            lotSala02 = int.Parse(txtLotacaoSala02.Text);


            MessageBox.Show("Salas de Treinamento Cadastradas com sucesso!","Feito");

            Form3 form3 = new Form3();
            form3.Hide();
            form3.ShowDialog();
            this.Close();
            
        }
    }
}
