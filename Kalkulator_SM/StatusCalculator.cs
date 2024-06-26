﻿using System;
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

        public int equalCount { get; set; } = 0;

        private double lastValue = 0;

        public string LastOperation { get; set; } = string.Empty;

        public double tempCurrent = 0;
        public double tempPending = 0;
        public string tempOperation = string.Empty;

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
            this.equalCount = 0;
            this.tempCurrent = 0;
            this.tempPending = 0;
            this.tempOperation = string.Empty;
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
        public void CalculateResultEquals()
        {

            if (equalCount == 0)
            {
                tempCurrent = this.PendingValue;
                tempPending = this.CurrentValue;
                tempOperation = this.Operation;


                this.CurrentValue = this.PerformOperation(this.PendingValue, this.CurrentValue, this.Operation);
                this.PendingValue = 0;
                this.Operation = string.Empty;
                this.IsOperationPending = false;
            }
            else
            {

                this.CurrentValue = this.PerformOperation(this.CurrentValue, this.tempPending, this.tempOperation);
            }

            this.equalCount += 1;
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

