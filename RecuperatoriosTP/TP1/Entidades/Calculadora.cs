using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valido que se haya ingresado el operador correcto caso contrario retorno un + por default
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }


        }
        /// <summary>
        /// Dependiendo del char operador que ingreso utilizo un switch comparando el operador con la funcion
        /// ValidarOperador, utilizando la sobrecarga de operadores guardo el resultado en la variable "resultado"
        /// y retorno la misma
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado=0;
            switch (ValidarOperador(operador))
            {
                
                case '-':
                    resultado= num1 - num2;
                    break;
                case '/':
                    resultado= num1 / num2;
                    break ;
                case '*':
                    resultado= num1 * num2;
                    break;
                default :
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }




    }
}
