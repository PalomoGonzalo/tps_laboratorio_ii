using System;

namespace Entidades
{

    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Si se logra pasar strNumero a double retorno ese numero, de lo contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroRetorno;

            if (double.TryParse(strNumero, out numeroRetorno))
            {
                return numeroRetorno;
            }
            else
            {
                return 0;
            }

        }

        public string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// recorro el string binario y retorno verdadero si solamente tiene 0 o 1 
        /// en caso de no existir retorno false
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '1' || binario[i] == '0')
                { 
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// pregunto con la funcion EsBinario, si es verdadero convierto a entero el valor del binario
        /// de lo contrario tira numero invalido
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)
        {
            int resultadoBinDecimal;

            if (EsBinario(binario))
            {
                resultadoBinDecimal = Convert.ToInt32(binario, 2);
                return resultadoBinDecimal.ToString();
            }
            else
            {
                return "numero invalido ";
            }
        }


        /// <summary>
        /// Si el numero es mayor a cero convierto a binario 
        /// caso contrario retorno numero invalido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            if (numero > 0)
            {
                int numInt = (int)numero;
                return Convert.ToString(numInt, 2);
            }
            else
            {
                return "numero invalido";
            }
        }
        /// <summary>
        /// Si el numero es mayor a cero convierto a binario 
        /// caso contrario retorno numero invalido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            double resultado;
            if (double.TryParse(numero, out resultado))
            {
                return DecimalBinario(resultado);
            }
            else
            {
                return "numero invalido";
            }
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// sobrecargo el operador / verificando que si el operando n2 es cero retorna double.minvalue
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
    }
}
