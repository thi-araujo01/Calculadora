using System;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Calc : Form {
        public bool Adicao { get; set; }
        public bool Subtracao { get; set; }
        public bool Multip { get; set; }
        public bool Divisao { get; set; }
        public decimal Calculo { get; set; }

        public Calc() {
            InitializeComponent();
            btnadc.Enabled = false;                   //inicia o programa com os botões de operação desativados
            btnsubt.Enabled = false;
            btnmult.Enabled = false;
            btndiv.Enabled = false;
            btnigual.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {

        }

        //abaixo foi criado o comando 'clique' para todos os botões

        private void Btn1_Click(object sender, EventArgs e) {

            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;               //desativa as operações para que seja possível utilizar números com mais de 1 dígito
                Subtracao = false;
                Multip = false;
                Divisao = false;
                btnadc.Enabled = true;

                txtResult.Text = "1";
            }
            else {
                btnadc.Enabled = true;            //habilita os botões de operação caso seja o primeiro número digitado
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e) {

            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "2";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "3";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "4";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "5";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "6";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "7";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "8";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "9";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "9";
            }
        }

        private void Btn0_Click(object sender, EventArgs e) {
            if (Adicao == true || Subtracao == true || Multip == true || Divisao == true) {
                Adicao = false;
                Subtracao = false;
                Multip = false;
                Divisao = false;
                txtResult.Text = "0";
            }
            else {
                btnadc.Enabled = true;
                btnsubt.Enabled = true;
                btnmult.Enabled = true;
                btndiv.Enabled = true;
                btnigual.Enabled = true;
                txtResult.Text += "0";
            }
        }

        private void Btnadc_Click(object sender, EventArgs e) {
            Adicao = true;                                       //habilita a adição
            Calculo = decimal.Parse(txtResult.Text);             //converte o tipo de dado para decimal
            txtOperacao.Text = txtResult.Text + " + ";           //adiciona o caractere no campo txtOperacao juntamente com o que estiver no campo txtResult
        }

        private void Btnsubt_Click(object sender, EventArgs e) {
            Subtracao = true;
            Calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text = txtResult.Text + " - ";
        }

        private void Btnmult_Click(object sender, EventArgs e) {
            Multip = true;
            Calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text = txtResult.Text + " * ";
        }

        private void Btndiv_Click(object sender, EventArgs e) {
            Divisao = true;
            Calculo = decimal.Parse(txtResult.Text);
            txtOperacao.Text = txtResult.Text + " ÷ ";
        }

        private void Btnigual_Click(object sender, EventArgs e) {
            if (txtOperacao.Text.Contains("=")) {                     //verifica se o campo contém o caractere '=' para não adicionar infinitamente
                txtOperacao.Text = txtOperacao.Text;
            }
            else {
                txtOperacao.Text += txtResult.Text + " = ";
            }

            if (txtOperacao.Text.Contains("+")) {
                txtResult.Text = Convert.ToString(decimal.Parse(txtResult.Text) + Calculo);    //busca o valor no campo 'resultado' e soma com o valor seguinte inserido no mesmo campo
            }
            else if (txtOperacao.Text.Contains("-")) {
                decimal result = Calculo - decimal.Parse(txtResult.Text);
                txtResult.Text = Convert.ToString(result);
            }
            else if (txtOperacao.Text.Contains("*")) {
                txtResult.Text = Convert.ToString(decimal.Parse(txtResult.Text) * Calculo);
            }
            else {
                decimal result = Calculo / decimal.Parse(txtResult.Text);
                txtResult.Text = Convert.ToString(result);
            }
        }
    }
}