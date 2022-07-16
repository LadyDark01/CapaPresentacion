using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if(guardar == DialogResult.OK)
            {
                using(var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                        guardar_archivo.WriteLine(richTextBox1);
                }
            }
           
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Seleccionartodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Eliminartodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Formato_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if(frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
              

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
