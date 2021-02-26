using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recrutamento
{
    public partial class Form4 : Form
    {

        public Form4(string parametro) : this()
        {
            string var = parametro;
        }

        public Form4()
        {
            InitializeComponent();


        }

        

        private void btnConsultarAluno_Click(object sender, EventArgs e)
        {
            Form1 cadastroAluno = new Form1();
            Form2 salaTreinamento = new Form2();
            Form3 salasCafe = new Form3();

           
           
            var procurar = txtNomeConsulta.Text;
           
            foreach (var aluno in cadastroAluno.aluno)
            {

            }

        

            //for (int i = 0; i < cadastroAluno.aluno.Length; i++)
            //{
            //    if (txtNomeConsulta.Text == cadastroAluno.aluno[i])
            //    {
            //        resultadoConsultaAluno.Text = cadastroAluno.aluno[i].ToString();
            //    }
            //}
        }

        private void btnConsultarSala_Click(object sender, EventArgs e)
        {
            Form1 cadastroAluno = new Form1();
            Form2 salaTreinamento = new Form2();
            Form3 salasCafe = new Form3();


            //int qtdPrimmeiraSala = cadastroAluno.alunos.Length / 2;

            //int qtdSegundaaSala = cadastroAluno.alunos.Length;
            //for (int i = 0; i < qtdPrimmeiraSala; i++)
            //{
            //    alunosSala01[i] = cadastroAluno.alunos[i];
            //}
            //for (int i = qtdPrimmeiraSala; i >= 0; i--)
            //{
            //    alunosSala02[i] = cadastroAluno.alunos[i];
            //}


            //for (int r = 0; r < alunosSala01.Length; r++)
            //{
            //    if (alunosSala01[r] != null)
            //    {
            //        listaDaSala.Items.Add(Environment.NewLine + alunosSala01.ElementAt(r));
            //    }
            //}
        }
    }
}
