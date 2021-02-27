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
    public partial class Form3 : Form
    {
        public string cafe01 = "";
        public int lotCafe01;
        public string cafe02 = "";
        public int lotCafe02;

        public List<string> alunosSala01 = new List<string>();// LISTA DE ALUNOS SALA-01
        public List<string> alunosSala02 = new List<string>();// LISTA DE ALUNOS SALA-02

        public Form3()
        {
            InitializeComponent();
        }

        private void btnCadastrarCafes_Click(object sender, EventArgs e)
        {
            cafe01 = txtNomeCafe01.Text;
            lotCafe01 = int.Parse(txtLotacaoCafe01.Text);
            cafe02 = txtNomeCafé02.Text;
            lotCafe02 = int.Parse(txtLotacaoCafe02.Text);
            TratamentoDeDados();
            
            MessageBox.Show("Salas de Café Cadastradas!","Feito");

            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        public void TratamentoDeDados()
        {
            // TRATAMENTO DE DADOS | Método que será feita toda a divsao de alunos por sala de treinamento e cafe nas suas etapas.           
        }
    }
}
