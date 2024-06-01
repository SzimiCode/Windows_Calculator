
namespace Kalkulator_SM
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.btnprocent = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnroot = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplusminus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnleave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnequals1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btndot1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(-4, 64);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 30);
            this.TxtDisplay2.TabIndex = 0;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay2.TextChanged += new System.EventHandler(this.s_TextChanged);
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay1.ForeColor = System.Drawing.Color.Silver;
            this.txtDisplay1.Location = new System.Drawing.Point(-4, 94);
            this.txtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(350, 45);
            this.txtDisplay1.TabIndex = 1;
            this.txtDisplay1.Text = "0";
            this.txtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnprocent
            // 
            this.btnprocent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnprocent.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnprocent.FlatAppearance.BorderSize = 0;
            this.btnprocent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprocent.ForeColor = System.Drawing.Color.White;
            this.btnprocent.Location = new System.Drawing.Point(6, 212);
            this.btnprocent.Margin = new System.Windows.Forms.Padding(0);
            this.btnprocent.Name = "btnprocent";
            this.btnprocent.Size = new System.Drawing.Size(85, 50);
            this.btnprocent.TabIndex = 2;
            this.btnprocent.Text = "%";
            this.btnprocent.UseVisualStyleBackColor = false;
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnce.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnce.FlatAppearance.BorderSize = 0;
            this.btnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnce.ForeColor = System.Drawing.Color.White;
            this.btnce.Location = new System.Drawing.Point(91, 162);
            this.btnce.Margin = new System.Windows.Forms.Padding(0);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(85, 50);
            this.btnce.TabIndex = 3;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnc.FlatAppearance.BorderSize = 0;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnc.ForeColor = System.Drawing.Color.White;
            this.btnc.Location = new System.Drawing.Point(173, 162);
            this.btnc.Margin = new System.Windows.Forms.Padding(0);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(85, 50);
            this.btnc.TabIndex = 4;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnbackspace
            // 
            this.btnbackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnbackspace.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnbackspace.FlatAppearance.BorderSize = 0;
            this.btnbackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackspace.ForeColor = System.Drawing.Color.White;
            this.btnbackspace.Location = new System.Drawing.Point(258, 162);
            this.btnbackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(85, 50);
            this.btnbackspace.TabIndex = 5;
            this.btnbackspace.Text = "⌫";
            this.btnbackspace.UseVisualStyleBackColor = false;
            this.btnbackspace.Click += new System.EventHandler(this.btnbackspace_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btndivide.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndivide.FlatAppearance.BorderSize = 0;
            this.btndivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndivide.ForeColor = System.Drawing.Color.White;
            this.btndivide.Location = new System.Drawing.Point(258, 212);
            this.btndivide.Margin = new System.Windows.Forms.Padding(0);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(85, 50);
            this.btndivide.TabIndex = 6;
            this.btndivide.Text = "➗";
            this.btndivide.UseVisualStyleBackColor = false;
            // 
            // btnroot
            // 
            this.btnroot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnroot.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnroot.FlatAppearance.BorderSize = 0;
            this.btnroot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroot.ForeColor = System.Drawing.Color.White;
            this.btnroot.Location = new System.Drawing.Point(173, 212);
            this.btnroot.Margin = new System.Windows.Forms.Padding(0);
            this.btnroot.Name = "btnroot";
            this.btnroot.Size = new System.Drawing.Size(85, 50);
            this.btnroot.TabIndex = 7;
            this.btnroot.Text = "√";
            this.btnroot.UseVisualStyleBackColor = false;
            this.btnroot.Click += new System.EventHandler(this.btnroot_Click);
            // 
            // btnpower
            // 
            this.btnpower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnpower.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnpower.FlatAppearance.BorderSize = 0;
            this.btnpower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpower.ForeColor = System.Drawing.Color.White;
            this.btnpower.Location = new System.Drawing.Point(88, 212);
            this.btnpower.Margin = new System.Windows.Forms.Padding(0);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(85, 50);
            this.btnpower.TabIndex = 8;
            this.btnpower.Text = "x²";
            this.btnpower.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(6, 262);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 50);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(91, 262);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 50);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(173, 262);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 50);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnmultiply.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnmultiply.FlatAppearance.BorderSize = 0;
            this.btnmultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmultiply.ForeColor = System.Drawing.Color.White;
            this.btnmultiply.Location = new System.Drawing.Point(258, 262);
            this.btnmultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(85, 50);
            this.btnmultiply.TabIndex = 13;
            this.btnmultiply.Text = "✖️";
            this.btnmultiply.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(6, 312);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 50);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(91, 312);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 50);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(176, 312);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 50);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnminus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnminus.FlatAppearance.BorderSize = 0;
            this.btnminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminus.ForeColor = System.Drawing.Color.White;
            this.btnminus.Location = new System.Drawing.Point(258, 312);
            this.btnminus.Margin = new System.Windows.Forms.Padding(0);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(85, 50);
            this.btnminus.TabIndex = 17;
            this.btnminus.Text = "➖";
            this.btnminus.UseVisualStyleBackColor = false;
            // 
            // btnplusminus
            // 
            this.btnplusminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnplusminus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnplusminus.FlatAppearance.BorderSize = 0;
            this.btnplusminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplusminus.ForeColor = System.Drawing.Color.White;
            this.btnplusminus.Location = new System.Drawing.Point(6, 412);
            this.btnplusminus.Margin = new System.Windows.Forms.Padding(0);
            this.btnplusminus.Name = "btnplusminus";
            this.btnplusminus.Size = new System.Drawing.Size(85, 50);
            this.btnplusminus.TabIndex = 18;
            this.btnplusminus.Text = "±";
            this.btnplusminus.UseVisualStyleBackColor = false;
            this.btnplusminus.Click += new System.EventHandler(this.btnplusminus_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(91, 412);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 50);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnplus.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnplus.FlatAppearance.BorderSize = 0;
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus.ForeColor = System.Drawing.Color.White;
            this.btnplus.Location = new System.Drawing.Point(258, 362);
            this.btnplus.Margin = new System.Windows.Forms.Padding(0);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(85, 50);
            this.btnplus.TabIndex = 21;
            this.btnplus.Text = "➕";
            this.btnplus.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(6, 362);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 50);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(91, 362);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 50);
            this.btn2.TabIndex = 23;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(176, 362);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 50);
            this.btn3.TabIndex = 24;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btnleave
            // 
            this.btnleave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnleave.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnleave.FlatAppearance.BorderSize = 0;
            this.btnleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleave.ForeColor = System.Drawing.Color.White;
            this.btnleave.Location = new System.Drawing.Point(301, 0);
            this.btnleave.Margin = new System.Windows.Forms.Padding(0);
            this.btnleave.Name = "btnleave";
            this.btnleave.Size = new System.Drawing.Size(46, 34);
            this.btnleave.TabIndex = 26;
            this.btnleave.Text = "X";
            this.btnleave.UseVisualStyleBackColor = false;
            this.btnleave.Click += new System.EventHandler(this.btnleave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "🗕";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "🖩 Calculator Szymon Molitorys";
            // 
            // btnequals1
            // 
            this.btnequals1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnequals1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnequals1.FlatAppearance.BorderSize = 0;
            this.btnequals1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnequals1.ForeColor = System.Drawing.Color.White;
            this.btnequals1.Location = new System.Drawing.Point(258, 412);
            this.btnequals1.Margin = new System.Windows.Forms.Padding(0);
            this.btnequals1.Name = "btnequals1";
            this.btnequals1.Size = new System.Drawing.Size(85, 50);
            this.btnequals1.TabIndex = 29;
            this.btnequals1.Text = "=";
            this.btnequals1.UseVisualStyleBackColor = false;
            this.btnequals1.Click += new System.EventHandler(this.btnequals1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 50);
            this.button2.TabIndex = 30;
            this.button2.Text = "🧮";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btndot1
            // 
            this.btndot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btndot1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndot1.FlatAppearance.BorderSize = 0;
            this.btndot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndot1.ForeColor = System.Drawing.Color.White;
            this.btndot1.Location = new System.Drawing.Point(176, 412);
            this.btndot1.Margin = new System.Windows.Forms.Padding(0);
            this.btndot1.Name = "btndot1";
            this.btndot1.Size = new System.Drawing.Size(85, 50);
            this.btndot1.TabIndex = 31;
            this.btndot1.Text = ".";
            this.btndot1.UseVisualStyleBackColor = false;
            this.btndot1.Click += new System.EventHandler(this.btndot1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 468);
            this.Controls.Add(this.btndot1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnequals1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnleave);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnplusminus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.btnroot);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnbackspace);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnprocent);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.Button btnprocent;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnroot;
        private System.Windows.Forms.Button btnpower;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplusminus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnleave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnequals1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndot1;
    }
}

