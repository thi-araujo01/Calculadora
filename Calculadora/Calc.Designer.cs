
namespace Calculadora {
    partial class Calc {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnadc = new System.Windows.Forms.Button();
            this.btnsubt = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnvirg = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnmaismenos = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnperc = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(1, 39);
            this.txtResult.MaximumSize = new System.Drawing.Size(303, 71);
            this.txtResult.MinimumSize = new System.Drawing.Size(303, 71);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(303, 71);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(6, 366);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 56);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(81, 366);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 56);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(156, 366);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 56);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btnadc
            // 
            this.btnadc.BackColor = System.Drawing.Color.DimGray;
            this.btnadc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnadc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadc.Location = new System.Drawing.Point(231, 366);
            this.btnadc.Name = "btnadc";
            this.btnadc.Size = new System.Drawing.Size(69, 56);
            this.btnadc.TabIndex = 19;
            this.btnadc.Text = "+";
            this.btnadc.UseVisualStyleBackColor = false;
            this.btnadc.Click += new System.EventHandler(this.Btnadc_Click);
            // 
            // btnsubt
            // 
            this.btnsubt.BackColor = System.Drawing.Color.DimGray;
            this.btnsubt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsubt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubt.Location = new System.Drawing.Point(230, 304);
            this.btnsubt.Name = "btnsubt";
            this.btnsubt.Size = new System.Drawing.Size(69, 56);
            this.btnsubt.TabIndex = 20;
            this.btnsubt.Text = "-";
            this.btnsubt.UseVisualStyleBackColor = false;
            this.btnsubt.Click += new System.EventHandler(this.Btnsubt_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(155, 304);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 56);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.DimGray;
            this.btnmult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmult.Location = new System.Drawing.Point(230, 242);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(69, 56);
            this.btnmult.TabIndex = 22;
            this.btnmult.Text = "x";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.Btnmult_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(155, 242);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 56);
            this.btn9.TabIndex = 23;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(80, 304);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 56);
            this.btn5.TabIndex = 24;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(5, 304);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 56);
            this.btn4.TabIndex = 25;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(80, 242);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 56);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(5, 242);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 56);
            this.btn7.TabIndex = 27;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(80, 428);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 56);
            this.btn0.TabIndex = 28;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btnvirg
            // 
            this.btnvirg.BackColor = System.Drawing.Color.DimGray;
            this.btnvirg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnvirg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvirg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvirg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvirg.Location = new System.Drawing.Point(155, 428);
            this.btnvirg.Name = "btnvirg";
            this.btnvirg.Size = new System.Drawing.Size(69, 56);
            this.btnvirg.TabIndex = 29;
            this.btnvirg.Text = ",";
            this.btnvirg.UseVisualStyleBackColor = false;
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.DimGray;
            this.btnigual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnigual.Location = new System.Drawing.Point(230, 428);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(69, 56);
            this.btnigual.TabIndex = 30;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.Btnigual_Click);
            // 
            // btnmaismenos
            // 
            this.btnmaismenos.BackColor = System.Drawing.Color.DimGray;
            this.btnmaismenos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnmaismenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaismenos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaismenos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmaismenos.Location = new System.Drawing.Point(5, 428);
            this.btnmaismenos.Name = "btnmaismenos";
            this.btnmaismenos.Size = new System.Drawing.Size(69, 56);
            this.btnmaismenos.TabIndex = 31;
            this.btnmaismenos.Text = "±";
            this.btnmaismenos.UseVisualStyleBackColor = false;
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.DimGray;
            this.btndiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndiv.Location = new System.Drawing.Point(230, 180);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(69, 56);
            this.btndiv.TabIndex = 32;
            this.btndiv.Text = "÷";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.Btndiv_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DimGray;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnC.Location = new System.Drawing.Point(155, 180);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(69, 56);
            this.btnC.TabIndex = 33;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.DimGray;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCE.Location = new System.Drawing.Point(80, 180);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(69, 56);
            this.btnCE.TabIndex = 34;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnperc
            // 
            this.btnperc.BackColor = System.Drawing.Color.DimGray;
            this.btnperc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnperc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnperc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnperc.Location = new System.Drawing.Point(5, 180);
            this.btnperc.Name = "btnperc";
            this.btnperc.Size = new System.Drawing.Size(69, 56);
            this.btnperc.TabIndex = 35;
            this.btnperc.Text = "%";
            this.btnperc.UseVisualStyleBackColor = false;
            this.btnperc.Click += new System.EventHandler(this.btnperc_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.DimGray;
            this.btndel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndel.Location = new System.Drawing.Point(156, 117);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(143, 57);
            this.btndel.TabIndex = 36;
            this.btndel.Text = "⌫";
            this.btndel.UseVisualStyleBackColor = false;
            // 
            // txtOperacao
            // 
            this.txtOperacao.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtOperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperacao.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperacao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOperacao.Location = new System.Drawing.Point(1, 0);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.Size = new System.Drawing.Size(303, 36);
            this.txtOperacao.TabIndex = 37;
            this.txtOperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOperacao.TextChanged += new System.EventHandler(this.txtOperacao_TextChanged);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(305, 491);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnperc);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmaismenos);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnvirg);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnsubt);
            this.Controls.Add(this.btnadc);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 530);
            this.MinimumSize = new System.Drawing.Size(321, 530);
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnadc;
        private System.Windows.Forms.Button btnsubt;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnvirg;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnmaismenos;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnperc;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtOperacao;
    }
}

