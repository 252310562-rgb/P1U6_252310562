namespace P1U6_252310562
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(openFileDialog1.FileName);
                txtArchivo.Text = leer.ReadToEnd();
                leer.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1 == null)
                saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                FileStream archivo = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter archivoEscribir = new StreamWriter(archivo);
                archivoEscribir.Write(txtArchivo.Text);
                archivoEscribir.Close();
            }
            else
            {
                MessageBox.Show("Algo no esta bien");
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtArchivo.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Font = fontDialog1.Font;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.BackColor = colorDialog1.Color;
            }
        }

        private void colorDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.ForeColor = colorDialog1.Color;
            }
        }
    }
}
