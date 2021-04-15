using System;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        Matrix A;
        Matrix B;
        Matrix Rez;

        public Form1()
        {
            InitializeComponent();
        }

        public void PrintA()
        {
            MatrixA.Text = "";
            for(int i = 0; i < A.N; i++)
            {
                for(int j = 0; j < A.N; j++)
                {
                    MatrixA.Text += A.Mat[i, j] + " ";
                }
                MatrixA.Text += "\n";
            }
        }

        public void PrintB()
        {
            MatrixB.Text = "";
            for (int i = 0; i < B.N; i++)
            {
                for (int j = 0; j < B.N; j++)
                {
                    MatrixB.Text += B.Mat[i, j] + " ";
                }
                MatrixB.Text += "\n";
            }
        }

        public void PrintRez()
        {
            MatrixRez.Text = "";
            for (int i = 0; i < Rez.N; i++)
            {
                for (int j = 0; j < Rez.N; j++)
                {
                    MatrixRez.Text += Rez.Mat[i, j] + " ";
                }
                MatrixRez.Text += "\n";
            }
        }

        private void numericUpDownA1_ValueChanged(object sender, EventArgs e)
        {
            textBoxSizeA2.Text = numericUpDownA1.Value.ToString();
            buttonClearA.Enabled = false;
            buttonProA.Enabled = false;
            buttonRangA.Enabled = false;
            buttonTransA.Enabled = false;
            buttonChange.Enabled = false;
            buttonPro.Enabled = false;
            buttonRaz.Enabled = false;
            buttonSum.Enabled = false;
        }

        private void numericUpDownB2_ValueChanged(object sender, EventArgs e)
        {
            textBoxSizeB2.Text = numericUpDownB2.Value.ToString();
            buttonClearB.Enabled = false;
            buttonProB.Enabled = false;
            buttonRangB.Enabled = false;
            buttonTransB.Enabled = false;
            buttonChange.Enabled = false;
            buttonPro.Enabled = false;
            buttonRaz.Enabled = false;
            buttonSum.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                A = new Matrix(MatrixA.Text, (uint)numericUpDownA1.Value);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
                buttonClearA.Enabled = false;
                buttonProA.Enabled = false;
                buttonRangA.Enabled = false;
                buttonTransA.Enabled = false;
                buttonChange.Enabled = false;
                buttonPro.Enabled = false;
                buttonRaz.Enabled = false;
                buttonSum.Enabled = false;
                textBoxRangA.Text = "";
                return;
            }
            toolStripStatusLabel1.Text = "";
            buttonClearA.Enabled = true;
            buttonProA.Enabled = true;
            buttonRangA.Enabled = true;
            buttonTransA.Enabled = true;
            textBoxRangA.Text = "";
            if (buttonTransB.Enabled == true)
            {
                buttonChange.Enabled = true;
                buttonPro.Enabled = true;
                buttonRaz.Enabled = true;
                buttonSum.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                B = new Matrix(MatrixB.Text, (uint)numericUpDownB2.Value);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
                buttonClearA.Enabled = false;
                buttonProA.Enabled = false;
                buttonRangA.Enabled = false;
                buttonTransA.Enabled = false;
                buttonChange.Enabled = false;
                buttonPro.Enabled = false;
                buttonRaz.Enabled = false;
                buttonSum.Enabled = false;
                textBoxRangB.Text = "";
                return;
            }
            toolStripStatusLabel1.Text = "";
            buttonClearB.Enabled = true;
            buttonProB.Enabled = true;
            buttonRangB.Enabled = true;
            buttonTransB.Enabled = true;
            textBoxRangB.Text = "";
            if (buttonTransA.Enabled == true)
            {
                buttonChange.Enabled = true;
                buttonPro.Enabled = true;
                buttonRaz.Enabled = true;
                buttonSum.Enabled = true;
            }
        }

        private void buttonClearA_Click(object sender, EventArgs e)
        {
            MatrixA.Text = "";
            textBoxRangA.Text = "";
            A.Clear();
            buttonClearA.Enabled = false;
            buttonProA.Enabled = false;
            buttonRangA.Enabled = false;
            buttonTransA.Enabled = false;
            buttonChange.Enabled = false;
            buttonPro.Enabled = false;
            buttonRaz.Enabled = false;
            buttonSum.Enabled = false;
        }

        private void buttonClearB_Click(object sender, EventArgs e)
        {
            MatrixB.Text = "";
            textBoxRangB.Text = "";
            B.Clear();
            buttonClearB.Enabled = false;
            buttonProB.Enabled = false;
            buttonRangB.Enabled = false;
            buttonTransB.Enabled = false;
            buttonChange.Enabled = false;
            buttonPro.Enabled = false;
            buttonRaz.Enabled = false;
            buttonSum.Enabled = false;
        }

        private void buttonClearRez_Click(object sender, EventArgs e)
        {
            MatrixRez.Text = "";
            textBoxRangRez.Text = "";
            Rez.Clear();
            buttonClearRez.Enabled = false;
            buttonProRez.Enabled = false;
            buttonRangRez.Enabled = false;
            buttonTransRez.Enabled = false;
        }

        private void buttonTransA_Click(object sender, EventArgs e)
        {
            A.Transpon();
            PrintA();
        }

        private void buttonTransB_Click(object sender, EventArgs e)
        {
            B.Transpon();
            PrintB();
        }

        private void buttonTransRez_Click(object sender, EventArgs e)
        {
            Rez.Transpon();
            PrintRez();
        }

        private void buttonProA_Click(object sender, EventArgs e)
        {
            A.Pro_num((double)numericUpDownProA.Value);
            PrintA();
        }

        private void buttonProB_Click(object sender, EventArgs e)
        {
            B.Pro_num((double)numericUpDownProB.Value);
            PrintB();
        }

        private void buttonProRez_Click(object sender, EventArgs e)
        {
            Rez.Pro_num((double)numericUpDownProRez.Value);
            PrintRez();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Matrix tmp = A;
            A = B;
            B = tmp;
            PrintA();
            numericUpDownA1.Value = A.N;
            textBoxSizeA2.Text = A.N + "";
            PrintB();
            numericUpDownB2.Value = B.N;
            textBoxSizeB2.Text = B.N + "";
            tmp = null;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if(A.N == B.N)
            {
                Rez = A + B;
                PrintRez();
            }
            else
            {
                toolStripStatusLabel1.Text = "Матрицы разного размера";
            }
        }

        private void buttonPro_Click(object sender, EventArgs e)
        {
            if (A.N == B.N)
            {
                Rez = A * B;
                PrintRez();
            }
            else
            {
                toolStripStatusLabel1.Text = "Матрицы разного размера";
            }
        }

        private void buttonRaz_Click(object sender, EventArgs e)
        {
            if (A.N == B.N)
            {
                Rez = A - B;
                PrintRez();
            }
            else
            {
                toolStripStatusLabel1.Text = "Матрицы разного размера";
            }
        }

        private void MatrixRez_TextChanged(object sender, EventArgs e)
        {
            textBoxSizeRez1.Text = textBoxSizeRez2.Text = Rez.N.ToString();
            buttonClearRez.Enabled = true;
            buttonProRez.Enabled = true;
            buttonRangRez.Enabled = true;
            buttonTransRez.Enabled = true;
        }

        private void buttonRangA_Click(object sender, EventArgs e)
        {
            textBoxRangA.Text = "";
            Matrix A_copy = new Matrix(A.Mat, A.N);
            textBoxRangA.Text = A_copy.Rang().ToString();
        }

        private void buttonRangB_Click(object sender, EventArgs e)
        {
            textBoxRangB.Text = "";
            Matrix B_copy = new Matrix(B.Mat, B.N);
            textBoxRangB.Text = B_copy.Rang().ToString();
        }

        private void buttonRangRez_Click(object sender, EventArgs e)
        {
            textBoxRangRez.Text = "";
            Matrix Rez_copy = new Matrix(Rez.Mat, Rez.N);
            textBoxRangRez.Text = Rez_copy.Rang().ToString();
        }

        private void MatrixA_TextChanged(object sender, EventArgs e)
        {
            buttonClearA.Enabled = false;
            buttonProA.Enabled = false;
            buttonRangA.Enabled = false;
            buttonTransA.Enabled = false;
            buttonChange.Enabled = false;
            buttonPro.Enabled = false;
            buttonRaz.Enabled = false;
            buttonSum.Enabled = false;
        }

        private void MatrixB_TextChanged(object sender, EventArgs e)
        {
            buttonClearB.Enabled = false;
            buttonProB.Enabled = false;
            buttonRangB.Enabled = false;
            buttonTransB.Enabled = false;
            buttonChange.Enabled = false;
            buttonPro.Enabled = false;
            buttonRaz.Enabled = false;
            buttonSum.Enabled = false;
        }
    }
}
