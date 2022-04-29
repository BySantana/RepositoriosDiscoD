using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15_1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string pastaCriada = $@"D:\\{txtArquivo1.Text}";
            if (!System.IO.Directory.Exists(pastaCriada))
            {
                System.IO.Directory.CreateDirectory(pastaCriada);
            }
            else
            {
                MessageBox.Show("Pasta já existe", "Erro", MessageBoxButtons.OKCancel);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string pastaCriada = $@"D:\\{txtArquivo2.Text}";
            if (System.IO.Directory.Exists(pastaCriada))
            {
                System.IO.Directory.Delete(pastaCriada);
            }
            else
            {
                MessageBox.Show("Essa pasta não existe", "Erro", MessageBoxButtons.OKCancel);
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            string nomeArquivo = txtArquivo.Text;
            string pastaOrigem = $@"D:\\{txtPastaOrigem.Text}";
            string pastaDestino = $@"D:\\{txtPastaDestino.Text}";

            string arquivoOrigem = System.IO.Path.Combine(pastaOrigem, nomeArquivo);
            string arquivoDestino = System.IO.Path.Combine(pastaDestino, nomeArquivo);

            System.IO.File.Move(arquivoOrigem, arquivoDestino);
        }
    }
}
