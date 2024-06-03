using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_SM
{
    public partial class Form1 : Form
    {
        private StatusCalculator statusCalculator;
        public Form1()
        {
            InitializeComponent();
            statusCalculator = new StatusCalculator();
            this.button1.Click += new System.EventHandler(this.button1_Click);
            btn0.Click += Button_Click;
            btn1.Click += Button_Click;
            btn2.Click += Button_Click;
            btn3.Click += Button_Click;
            btn4.Click += Button_Click;
            btn5.Click += Button_Click;
            btn6.Click += Button_Click;
            btn7.Click += Button_Click; 
            btn8.Click += Button_Click;
            btn9.Click += Button_Click;
            btndivide.Click += Button_Click;
            btnmultiply.Click += Button_Click;
            btnplus.Click += Button_Click;
            btnminus.Click += Button_Click;
            btnpower.Click += Button_Click;
            btnroot.Click += Button_Click;
            btnequals1.Click += btnequals1_Click;
            btnce.Click += btnce_Click;
            btnc.Click += btnc_Click;
            btndot1.Click += btndot1_Click;
            btnprocent.Click += Button_Click;

            //btnplusminus.Click += btnplusminus_Click;
            //btnbackspace.Click += btnbackspace_Click;
        }
        private void UpdateDisplay()
        {

            // Ustaw tekst wyświetlacza na bieżącą wartość z klasy StatusCalculator
            txtDisplay1.Text = statusCalculator.CurrentValue.ToString();
            TxtDisplay2.Text = statusCalculator.PendingValue.ToString() + " " + statusCalculator.Operation;

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Pobierz przycisk, który został kliknięty
            if (clickedButton != null)
            {
               
                string buttonText = clickedButton.Text; // Pobierz tekst przycisku
                double buttonValue;
               
                if (double.TryParse(buttonText, out buttonValue))
                {
                    if(statusCalculator.CurrentValue > 999999999999)
                    {
                        MessageBox.Show("Za duża liczba", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Jeśli tekst przycisku jest liczbą, przekaż ją do instancji klasy StatusCalculator
                        statusCalculator.ReceiveInput(buttonValue);
                    } 
                }
                else
                {
                    // Jeśli tekst przycisku jest operatorem (+, -, *, / itp.), przekaż go do instancji klasy StatusCalculator
                    statusCalculator.SetOperation(buttonText);
                }
            }
            UpdateDisplay();
        }

        private void s_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnequals1_Click(object sender, EventArgs e)
        {
            statusCalculator.CalculateResultEquals();
            TxtDisplay2.Text = $"{statusCalculator.tempCurrent} {statusCalculator.tempOperation} {statusCalculator.tempPending} =";
            txtDisplay1.Text = statusCalculator.CurrentValue.ToString();


        }

        private void btnce_Click(object sender, EventArgs e)
        {
            statusCalculator.Reset();
            UpdateDisplay();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            statusCalculator.Reset();
            UpdateDisplay();
        }
        //Pomocnicza funkcja do +/-
        public int GetDecimalPlaces(double value)
        {
            string valueString = value.ToString();
            int decimalPlaces = 0;
            if (valueString.Contains('.'))
            {
                decimalPlaces = valueString.Split('.')[1].Length;
            }
            return decimalPlaces;
        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            int ile = GetDecimalPlaces(statusCalculator.CurrentValue);
            if (ile > 12)
            {
                double temp = Math.Round(statusCalculator.CurrentValue, 12);
                statusCalculator.CurrentValue = temp * -1;
            }
            else
            {
                statusCalculator.CurrentValue *= -1;
            }
            UpdateDisplay();
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            string currentValueAsString = statusCalculator.CurrentValue.ToString();

            if (currentValueAsString.Length > 1)
            {
                currentValueAsString = currentValueAsString.Substring(0, currentValueAsString.Length - 1);

                statusCalculator.CurrentValue = double.Parse(currentValueAsString);
            }
            else
            {
                statusCalculator.CurrentValue = 0;
            }
            UpdateDisplay();
        }

        private void btndot1_Click(object sender, EventArgs e)
        {
            if (!statusCalculator.IsDecimal)
            {
                statusCalculator.IsDecimal = true;
                if (statusCalculator.CurrentValue == 0)
                {
                    txtDisplay1.Text = "0.";
                }
                else
                {
                    txtDisplay1.Text = statusCalculator.CurrentValue.ToString() + ".";
                }
            }
        }
        private void btnroot_Click(object sender, EventArgs e)
        {

        }
    }
}
