using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_SM
{
    public class StatusCalculator
    {
        public double CurrentValue { get; set; } = 0;      // Bieżąca wartość wyświetlana na ekranie
        public double PendingValue { get; set; } = 0;      // Wartość tymczasowa do przechowywania drugiej liczby
        public string Operation { get; set; } = string.Empty; // Aktualnie wybrana operacja (np. "+", "-", "*", "/")
        public bool IsOperationPending { get; set; } = false; // Flaga wskazująca, czy operacja jest w toku

        public bool IsDecimal { get; set; } = false; // Flaga wskazująca wprowadzanie części dziesiętnej

        private int equalCount = 0;

        private double lastValue = 0;

        public void Reset()
        {
            this.CurrentValue = 0;
            this.PendingValue = 0;
            this.Operation = string.Empty;
            this.IsOperationPending = false;
            this.IsDecimal = false;
            this.equalCount = 0;
        }

        public double PerformOperation(double value1, double value2, string operation)
        {
            switch (operation)
            {
                case "➕":
                    return value1 + value2;
                case "➖":
                    return value1 - value2;
                case "✖️":
                    return value1 * value2;
                case "➗":
                    if (value2 != 0)
                    {
                        return value1 / value2;
                    }
                    else
                    {
                        MessageBox.Show("Nie można dzielić przez 0", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return value2 = 0;
                    }
                    /*
                case "%":
                    return value1 / 100;
                case "x²":
                    return Math.Pow(value1, 2);
                case "√":
                    return Math.Sqrt(value1);
                    */
                default:
                    MessageBox.Show("Nie znana operacja", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }
        }
        public double PerformSingleOperation(double value1, string operation)
        {
            switch (operation)
            {
                case "%":
                    return value1 / 100;
                case "x²":
                    return Math.Pow(value1, 2);
                case "√":
                    if (value1 < 0)
                    {
                        MessageBox.Show("Nie można dzielić przez 0", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.PendingValue = 0;
                        return value1 = 0;
                    }
                    else
                    {
                        return Math.Sqrt(value1);
                    }
                default:
                    MessageBox.Show("Nie znana operacja", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }
        }

        public void SetOperation(string operation)
        {
            this.IsDecimal = false;
            if (this.IsOperationPending)
            {
                CalculateResult();
            }

            if (operation == "√" || operation == "x²" || operation == "%")
            {
                // Wykonaj operację jednostkową bezpośrednio na bieżącej wartości
                this.PendingValue = double.Parse(this.CurrentValue + this.Operation);
                this.CurrentValue = this.PerformSingleOperation(this.CurrentValue, operation);
                this.IsOperationPending = false;
                this.Operation = string.Empty;
            }
            else
            {
                // Przenieś bieżącą wartość do wartości tymczasowej i przygotuj się na operację binarną
                this.PendingValue = this.CurrentValue;
                this.CurrentValue = 0;
                this.Operation = operation;
                this.IsOperationPending = true;
            }
        }

        public void CalculateResult()
        {
            if (!string.IsNullOrEmpty(this.Operation))
            {
                this.CurrentValue = this.PerformOperation(this.PendingValue, this.CurrentValue, this.Operation);
                this.PendingValue = 0;
                this.Operation = string.Empty;
                this.IsOperationPending = false;
            }
        }
      
        public string CalculateResultEquals()
        {
           
            if (!string.IsNullOrEmpty(Operation))
            {
                if (equalCount > 1)
                {
                    this.CurrentValue = PerformOperation(this.PendingValue, this.lastValue, this.Operation);
                    return $"{this.PendingValue} {this.Operation} {this.lastValue} =";
                }
                else
                {
                    this.CurrentValue = PerformOperation(this.PendingValue, this.CurrentValue, this.Operation);
                    this.lastValue = CurrentValue;
                    equalCount++;
                    return $"{this.PendingValue} {this.Operation} {this.CurrentValue} =";
                }
                
            }
            this.IsOperationPending = false;
            return string.Empty;


        }
        public void ReceiveInput(double Value)
        {

            if (IsDecimal)
            {
                string currentValueString = CurrentValue.ToString();
                if (!currentValueString.Contains("."))
                {
                    currentValueString += ".";
                }
                currentValueString += Value.ToString();
                CurrentValue = double.Parse(currentValueString);
            }
            else
            {
                CurrentValue = CurrentValue * 10 + Value;
            }

        }
    }
}

