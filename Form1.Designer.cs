namespace Calcxu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEquals = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnPoint = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            button30 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            button33 = new Button();
            btnLog = new Button();
            btn10BaseExponent = new Button();
            btnTimes = new Button();
            btnDivide = new Button();
            btnMod = new Button();
            btnBackspace = new Button();
            btn9 = new Button();
            button10 = new Button();
            btnExp = new Button();
            btnClear = new Button();
            btn8 = new Button();
            button14 = new Button();
            button15 = new Button();
            btnexponential = new Button();
            btn7 = new Button();
            button6 = new Button();
            button7 = new Button();
            btnpi = new Button();
            btnPower = new Button();
            btnSqrt = new Button();
            btnPower2 = new Button();
            btnPercent = new Button();
            panel2 = new Panel();
            txtSumdesc = new Label();
            txtBoxScreen = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEquals);
            panel1.Controls.Add(btnPlus);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(btnPoint);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(button30);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(button33);
            panel1.Controls.Add(btnLog);
            panel1.Controls.Add(btn10BaseExponent);
            panel1.Controls.Add(btnTimes);
            panel1.Controls.Add(btnDivide);
            panel1.Controls.Add(btnMod);
            panel1.Controls.Add(btnBackspace);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(btnExp);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(btnexponential);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(btnpi);
            panel1.Controls.Add(btnPower);
            panel1.Controls.Add(btnSqrt);
            panel1.Controls.Add(btnPower2);
            panel1.Controls.Add(btnPercent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 605);
            panel1.TabIndex = 0;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(414, 542);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(94, 52);
            btnEquals.TabIndex = 34;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(414, 486);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 52);
            btnPlus.TabIndex = 33;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Operator_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(414, 430);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 52);
            btnMinus.TabIndex = 32;
            btnMinus.Text = "−";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += Operator_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(316, 542);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(94, 52);
            btnPoint.TabIndex = 31;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(316, 486);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 52);
            btn3.TabIndex = 30;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(316, 430);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 52);
            btn6.TabIndex = 29;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(220, 542);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 52);
            btn0.TabIndex = 28;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(220, 486);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 52);
            btn2.TabIndex = 27;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(220, 430);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 52);
            btn5.TabIndex = 26;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // button30
            // 
            button30.Location = new Point(122, 542);
            button30.Name = "button30";
            button30.Size = new Size(94, 52);
            button30.TabIndex = 25;
            button30.Text = "±";
            button30.UseVisualStyleBackColor = true;
            button30.Click += Scientific_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(122, 486);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 52);
            btn1.TabIndex = 24;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(122, 430);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 52);
            btn4.TabIndex = 23;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // button33
            // 
            button33.Location = new Point(26, 542);
            button33.Name = "button33";
            button33.Size = new Size(94, 52);
            button33.TabIndex = 22;
            button33.Text = "In";
            button33.UseVisualStyleBackColor = true;
            button33.Click += Scientific_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(26, 486);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(94, 52);
            btnLog.TabIndex = 21;
            btnLog.Text = "log₁₀";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += Scientific_Click;
            // 
            // btn10BaseExponent
            // 
            btn10BaseExponent.Location = new Point(26, 430);
            btn10BaseExponent.Name = "btn10BaseExponent";
            btn10BaseExponent.Size = new Size(94, 52);
            btn10BaseExponent.TabIndex = 20;
            btn10BaseExponent.Text = "10ˣ";
            btn10BaseExponent.UseVisualStyleBackColor = true;
            btn10BaseExponent.Click += Scientific_Click;
            // 
            // btnTimes
            // 
            btnTimes.Location = new Point(414, 374);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(94, 52);
            btnTimes.TabIndex = 19;
            btnTimes.Text = "×";
            btnTimes.UseVisualStyleBackColor = true;
            btnTimes.Click += Operator_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(414, 318);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(94, 52);
            btnDivide.TabIndex = 18;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operator_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(414, 262);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(94, 52);
            btnMod.TabIndex = 17;
            btnMod.Text = "mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += Scientific_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Location = new Point(414, 208);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(94, 52);
            btnBackspace.TabIndex = 16;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(316, 374);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 52);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // button10
            // 
            button10.Location = new Point(316, 318);
            button10.Name = "button10";
            button10.Size = new Size(94, 52);
            button10.TabIndex = 14;
            button10.Text = "n!";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Scientific_Click;
            // 
            // btnExp
            // 
            btnExp.Location = new Point(316, 262);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(94, 52);
            btnExp.TabIndex = 13;
            btnExp.Text = "exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += Scientific_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(316, 208);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 52);
            btnClear.TabIndex = 12;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(220, 374);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 52);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // button14
            // 
            button14.Location = new Point(220, 318);
            button14.Name = "button14";
            button14.Size = new Size(94, 52);
            button14.TabIndex = 10;
            button14.Text = ")";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(220, 262);
            button15.Name = "button15";
            button15.Size = new Size(94, 52);
            button15.TabIndex = 9;
            button15.Text = "∣x∣";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Scientific_Click;
            // 
            // btnexponential
            // 
            btnexponential.Location = new Point(220, 208);
            btnexponential.Name = "btnexponential";
            btnexponential.Size = new Size(94, 52);
            btnexponential.TabIndex = 8;
            btnexponential.Text = "e";
            btnexponential.UseVisualStyleBackColor = true;
            btnexponential.Click += Constant_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(122, 374);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 52);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // button6
            // 
            button6.Location = new Point(122, 318);
            button6.Name = "button6";
            button6.Size = new Size(94, 52);
            button6.TabIndex = 6;
            button6.Text = "(";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(122, 262);
            button7.Name = "button7";
            button7.Size = new Size(94, 52);
            button7.TabIndex = 5;
            button7.Text = "1/x";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Scientific_Click;
            // 
            // btnpi
            // 
            btnpi.Location = new Point(122, 208);
            btnpi.Name = "btnpi";
            btnpi.Size = new Size(94, 52);
            btnpi.TabIndex = 4;
            btnpi.Text = "π";
            btnpi.UseVisualStyleBackColor = true;
            btnpi.Click += Constant_Click;
            // 
            // btnPower
            // 
            btnPower.Location = new Point(26, 374);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(94, 52);
            btnPower.TabIndex = 3;
            btnPower.Text = "xʸ";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += Operator_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(26, 318);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(94, 52);
            btnSqrt.TabIndex = 2;
            btnSqrt.Text = "√x";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += Scientific_Click;
            // 
            // btnPower2
            // 
            btnPower2.Location = new Point(26, 262);
            btnPower2.Name = "btnPower2";
            btnPower2.Size = new Size(94, 52);
            btnPower2.TabIndex = 1;
            btnPower2.Text = "x²";
            btnPower2.UseVisualStyleBackColor = true;
            btnPower2.Click += Scientific_Click;
            // 
            // btnPercent
            // 
            btnPercent.Location = new Point(26, 208);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(94, 52);
            btnPercent.TabIndex = 0;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += Operator_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSumdesc);
            panel2.Controls.Add(txtBoxScreen);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 193);
            panel2.TabIndex = 1;
            // 
            // txtSumdesc
            // 
            txtSumdesc.AutoSize = true;
            txtSumdesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtSumdesc.Location = new Point(406, 49);
            txtSumdesc.Name = "txtSumdesc";
            txtSumdesc.Size = new Size(0, 28);
            txtSumdesc.TabIndex = 1;
            // 
            // txtBoxScreen
            // 
            txtBoxScreen.BorderStyle = BorderStyle.None;
            txtBoxScreen.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            txtBoxScreen.Location = new Point(18, 80);
            txtBoxScreen.Name = "txtBoxScreen";
            txtBoxScreen.ReadOnly = true;
            txtBoxScreen.Size = new Size(501, 43);
            txtBoxScreen.TabIndex = 0;
            txtBoxScreen.Text = "0";
            txtBoxScreen.TextAlign = HorizontalAlignment.Right;
            txtBoxScreen.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 605);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Scienca";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnPercent;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnPoint;
        private Button btn3;
        private Button btn6;
        private Button btn0;
        private Button btn2;
        private Button btn5;
        private Button button30;
        private Button btn1;
        private Button btn4;
        private Button button33;
        private Button btnLog;
        private Button btn10BaseExponent;
        private Button btnTimes;
        private Button btnDivide;
        private Button btnMod;
        private Button btnBackspace;
        private Button btn9;
        private Button button10;
        private Button btnExp;
        private Button btnClear;
        private Button btn8;
        private Button button14;
        private Button button15;
        private Button btnexponential;
        private Button btn7;
        private Button button6;
        private Button button7;
        private Button btnpi;
        private Button btnPower;
        private Button btnSqrt;
        private Button btnPower2;
        private TextBox txtBoxScreen;
        private Label txtSumdesc;
    }
}
