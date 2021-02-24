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

        public List<string> alunosSala01 = new List<string>();
        public List<string> alunosSala02 = new List<string>();

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

            Form4 form4 = new Form4();
            form4.Hide();
            form4.ShowDialog();
            this.Close();
        }

        public void TratamentoDeDados()
        {
            // fazer a divisao dos alunos e salas aqui...
            Form1 pegarAlunos = new Form1();

            var qtdalunos = pegarAlunos.aluno.Count;

            foreach (var i in pegarAlunos.aluno)
            {
                alunosSala01 = pegarAlunos.aluno;
            }
        }
    }
}
