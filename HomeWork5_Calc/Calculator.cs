using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace HomeWork5_Calc
{
    public class Calculator
    {
        private CultureInfo _culture;
        public Calculator()
        {
           _culture = CultureInfo.CreateSpecificCulture("ru-RU");
        }

        public decimal OperandOne  { get; set; }

        public decimal OperandTwo { get; set; }

        public string  TypeOperation { get; set; }

        public string AddOperand(string operand)
        {
            if (operand.Length>0 && operand[^1].ToString() == ",")  operand = operand.TrimEnd(',');
            var format = 0;
            for (int i = 0; i < operand.Length; i++)
            {
                if (operand[i] != ',') continue;
                format = i + 1;
                break;
            }

            if (format != 0) format = operand.Length - format;

            var resultConvert = Decimal.TryParse(operand, NumberStyles.Any, _culture, out var value);

            if (!resultConvert) value=0;
            
            if (OperandOne == default || (OperandOne!=default && OperandTwo!=default))
            {
                OperandOne = value;
                OperandTwo = default;
                return Math.Round(OperandOne, format).ToString(_culture);
            }
            else
            {
                OperandTwo = value;
                return Math.Round(OperandTwo, format).ToString(_culture);
            }
        }

        public string Result()
        {

            switch (TypeOperation)
            {
                case "+":
                    return (OperandOne + OperandTwo).ToString(_culture);
                case "-":
                    return (OperandOne - OperandTwo).ToString(_culture);
                case "*":
                    return (OperandOne * OperandTwo).ToString(_culture);
                case "/":
                    try
                    {
                        return (OperandOne / OperandTwo).ToString(_culture);
                    }
                    catch (Exception e)
                    {
                        return e.GetBaseException().Message;
                    }
                default: return "Что-то пошло не так";
            }
        }

        public void Reset()
        {
            OperandOne = default;
            OperandTwo = default;
            TypeOperation = string.Empty;
            
        }
    }
}
