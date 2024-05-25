using System;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {

        decimal calculo;
        bool adicao, subtracao, multip, divisao, result;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void btn1_Click(object sender, EventArgs e) {
            txtOperacao.Text += "1";
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e) {
            txtOperacao.Text += "2";
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtOperacao.Text += "3";
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtOperacao.Text += "4";
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtOperacao.Text += "5";
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtOperacao.Text += "6";
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtOperacao.Text += "7";
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtOperacao.Text += "8";
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtOperacao.Text += "9";
            txtResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e) {
            txtOperacao.Text += "0";
            txtResult.Text += "0";
        }

        private void btnadc_Click(object sender, EventArgs e) {
            txtOperacao.Text += " + ";
            txtResult.Text = "";
        }

        private void btnsubt_Click(object sender, EventArgs e) {
            txtOperacao.Text += " - ";
            txtResult.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e) {
            txtOperacao.Text += " x ";
            txtResult.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e) {
            txtOperacao.Text += " ÷ ";
            txtResult.Text = "";
        }
    }
}
