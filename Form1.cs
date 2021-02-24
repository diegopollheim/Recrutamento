using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public List<string> aluno = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            listaCadastrados.Items.Clear();
             
            aluno.Add($"{txtNome.Text} {txtSobrenome.Text}");
            
            for (int i = 0; i < aluno.Count; i++)
            {
                if (aluno[i] != null)
                {
                    listaCadastrados.Items.Add(Environment.NewLine + aluno.ElementAt(i));
                }
            }

            txtNome.Clear();
            txtSobrenome.Clear();
            txtNome.Focus();
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
