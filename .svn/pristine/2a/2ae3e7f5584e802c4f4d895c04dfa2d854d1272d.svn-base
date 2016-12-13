using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace Util
{
    public static class FuncoesGerais
    {
        public static string toExtenso(this double valor)
        {
            if (valor < 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else if (valor == 0)
                return "Zero Reais e Zero Centavos";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;

                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += escreva_parte(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " Trilhão" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " Trilhões" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " Bilhão" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " Bilhões" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " Milhão" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " Milhões" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " Mil" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " e " : string.Empty);

                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "Bilhão" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
                                valor_por_extenso += " de";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "Bilhões" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                    valor_por_extenso += " de";
                                else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "Trilhões")
                                        valor_por_extenso += " de";

                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " Real";
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " Reais";

                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " e ";
                    }

                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " Centavo";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " Centavos";
                }
                return valor_por_extenso;
            }
        }

        static string escreva_parte(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));

                if (a == 1) montagem += (b + c == 0) ? "Cem" : "Cento";
                else if (a == 2) montagem += "Duzentos";
                else if (a == 3) montagem += "Trezentos";
                else if (a == 4) montagem += "Quatrocentos";
                else if (a == 5) montagem += "Quinhentos";
                else if (a == 6) montagem += "Seiscentos";
                else if (a == 7) montagem += "Setecentos";
                else if (a == 8) montagem += "Oitocentos";
                else if (a == 9) montagem += "Novecentos";

                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " e " : string.Empty) + "Dez";
                    else if (c == 1) montagem += ((a > 0) ? " e " : string.Empty) + "Onze";
                    else if (c == 2) montagem += ((a > 0) ? " e " : string.Empty) + "Doze";
                    else if (c == 3) montagem += ((a > 0) ? " e " : string.Empty) + "Treze";
                    else if (c == 4) montagem += ((a > 0) ? " e " : string.Empty) + "Quatorze";
                    else if (c == 5) montagem += ((a > 0) ? " e " : string.Empty) + "Quinze";
                    else if (c == 6) montagem += ((a > 0) ? " e " : string.Empty) + "Dezesseis";
                    else if (c == 7) montagem += ((a > 0) ? " e " : string.Empty) + "Dezessete";
                    else if (c == 8) montagem += ((a > 0) ? " e " : string.Empty) + "Dezoito";
                    else if (c == 9) montagem += ((a > 0) ? " e " : string.Empty) + "Dezenove";
                }
                else if (b == 2) montagem += ((a > 0) ? " e " : string.Empty) + "Vinte";
                else if (b == 3) montagem += ((a > 0) ? " e " : string.Empty) + "Trinta";
                else if (b == 4) montagem += ((a > 0) ? " e " : string.Empty) + "Quarenta";
                else if (b == 5) montagem += ((a > 0) ? " e " : string.Empty) + "Cinquenta";
                else if (b == 6) montagem += ((a > 0) ? " e " : string.Empty) + "Sessenta";
                else if (b == 7) montagem += ((a > 0) ? " e " : string.Empty) + "Setenta";
                else if (b == 8) montagem += ((a > 0) ? " e " : string.Empty) + "Oitenta";
                else if (b == 9) montagem += ((a > 0) ? " e " : string.Empty) + "Noventa";

                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " e ";

                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "Um";
                    else if (c == 2) montagem += "Dois";
                    else if (c == 3) montagem += "Três";
                    else if (c == 4) montagem += "Quatro";
                    else if (c == 5) montagem += "Cinco";
                    else if (c == 6) montagem += "Seis";
                    else if (c == 7) montagem += "Sete";
                    else if (c == 8) montagem += "Oito";
                    else if (c == 9) montagem += "Nove";

                return montagem;
            }
        }

        public static bool isValidCNPJ(this string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool isValidCPF(this string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool isValidDouble(this string number)
        {
            double value;
            return double.TryParse(number, out value);
        }

        /// <summary>
        /// Tenta transformar a string em um tipo Double
        /// </summary>
        /// <param name="number">Entrada a ser convertida</param>
        /// <returns>Valor double retornado da conversãos (0.00 em caso de falha)</returns>
        public static double ToDouble(this string number)
        {
            if (number.isValidDouble()) return double.Parse(number);
            return 0.00;
        }
        /// <summary>
        /// Tenta formatar a string em um tipo Currency (2 casas decimais)
        /// </summary>
        /// <param name="number">Texto a ser formatado</param>
        /// <returns>string formatada</returns>
        public static string FormatStringToCurrency(this string number)
        {
            return number.ToDouble().ToString("n2");
        }

        public static string FormatToDecimalIfValid(this string number, int casas)
        {
            string formatacao = "0.";
            for (int i = 0; i < casas; i++)
            {
                formatacao += "0";
            }
            if (number.isValidDouble())
            {
                return string.Format("{0:" + formatacao + "}", Double.Parse(number));
            }
            else
                return string.Format("{0:" + formatacao + "}", 0.0);
        }

        public static bool isValidDate(this string date)
        {
            DateTime value;
            return DateTime.TryParse(date, out value);
        }

        public static string DateComplete(this string date) 
        {
            date = date.Replace("/", "").Replace(":", "").Replace(" ", "");
            string datetime = string.Empty;
            if (date.Length < 2) return string.Empty;

            if (date.Length == 2) datetime = date.Substring(0, 2) + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            
            if (date.Length == 4) datetime = date.Substring(0, 2) + "/" + date.Substring(2, 2) + "/" + DateTime.Now.Year.ToString();
            
            if (date.Length == 6) datetime = date.Substring(0, 2) + "/" + date.Substring(2, 2) + "/" + date.Substring(4, 2);
            
            if (date.Length == 8) datetime = date.Substring(0, 2) + "/" + date.Substring(2, 2) + "/" + date.Substring(4, 4);
            
            if (date.Length > 8) datetime = date.Substring(0, 2) + "/" + date.Substring(2, 2) + "/" + date.Substring(4, 4) + " ";
            
            if (date.Length == 10) datetime += date.Substring(8, 2) + ":00:00";
            
            if (date.Length == 12) datetime += date.Substring(8, 2) + ":" + date.Substring(10, 2) + ":00";
            
            if (date.Length == 14) datetime += date.Substring(8, 2) + ":" + date.Substring(10, 2) + ":" + date.Substring(12, 2);
            
            if(datetime.isValidDate()) return DateTime.Parse(datetime).ToString();
            return string.Empty;
        }

        public static bool isValidInteger(this string number)
        {
            int value = 0;
            return int.TryParse(number, out value);
        }

        public static int ToInteger(this string number)
        {
            if (number.isValidInteger())
                return int.Parse(number);
            return 0;
        }

        /// <summary>
        /// Formata uma string para o tipo Inteiro
        /// </summary>
        /// <param name="number">Valor de Entrada</param>
        /// <param name="valorDefault">Valor a ser devolvido caso a entrada falhe na conversão</param>
        /// <returns>Um valor string representando um inteiro</returns>
        public static string FormatStringToInteger(this string number, int valorDefault = 0)
        {
            if (!number.isValidInteger())
                return valorDefault.ToString();
            return string.Format("{0:0}", number);
        }

        public static bool isNullOrEmpty(this string a)
        {
            return a == null || a == string.Empty;
        }

        public static bool isEmptyOrWhiteSpace(this string a)
        {
            if (a == null) return true;
            if (a.Trim() == string.Empty) return true;
            return false;
        }

        public static void MensagemAviso(string conteudo, string titulo = "Aviso")
        {
            MessageBox.Show(conteudo, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensagemErro(string conteudo, string titulo = "Não foi possível completar a operação")
        {
            MessageBox.Show(conteudo, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool MensagemConfirmacao(string conteudo, string titulo = "Confirmar Operação?")
        {
            return MessageBox.Show(conteudo, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void MensagemSucesso(string conteudo, string titulo = "Sucesso")
        {
            MessageBox.Show(conteudo, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string RetornaSomenteNumeros(this string texto)
        {
            string padrao = @"[^0-9]";
            Regex rgx = new Regex(padrao);
            string resultado = rgx.Replace(texto, string.Empty);
            return resultado;
        }

        public static string RetornaSomenteLetras(this string texto)
        {
            string padrao = @"[^a-záéíóúàèìòùâêîôûãõç\s]";
            Regex rgx = new Regex(padrao, RegexOptions.IgnoreCase);
            string resultado = rgx.Replace(texto, string.Empty);
            return resultado;
        }

        public static string RemoveCaracteresEspeciais(this string texto)
        {
            string padrao = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
            Regex rgx = new Regex(padrao,RegexOptions.IgnoreCase);
            string resultado = rgx.Replace(texto, string.Empty);
            return resultado;
        }

        public static bool isValidCondicaoPagamento(this string input)
        {
            if (input == string.Empty) return false;
            if (input.Substring(input.Length - 1, 1) != "/") input += "/";
            var regex = new Regex(@"^([0-9]{1,3}/)*$");
            return regex.IsMatch(input);
        }

        /// <summary>
        /// Trata um campo do tipo string para um dos tipos de dados disponíveis do banco MySQL
        /// </summary>
        /// <param name="input"></param>
        /// <param name="type"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static string TrataCampoSQL(this string input, Tipos type, int decimals = 2)
        {
            if (input == null) input = "";
            switch (type)
            {
                case Tipos.Bool:
                    if (input.ToLower() == "true" || input.ToLower() == "sim")
                        input = "1";
                    else
                        input = "0";
                    break;
                case Tipos.Text:
                    input = "'" + input.Replace("'", "´").Replace("\\", "\\\\") + "'";
                    break;
                case Tipos.TextLike:
                    input = "'%" + input.Replace("'", "´").Replace("\\", "\\\\") + "%'";
                    break;
                case Tipos.Currency:
                    input = input.FormatStringToCurrency();
                    input = input.Equals("") ? "0.00" : input;
                    input = "'" + input.Replace("'", "´").Replace(".", "").Replace(",", ".") + "'";
                    break;
                case Tipos.Integer:
                    input = input.FormatStringToInteger();
                    input = "'" + input.Replace("'", "´").Replace(",", "").Replace(".", "") + "'";
                    break;
                case Tipos.Double:
                    input = input.FormatToDecimalIfValid(decimals);
                    input = "'" + input.Replace("'", "´").Replace(".", "").Replace(",", ".") + "'";
                    break;
                case Tipos.Date:
                    input = input.Replace("'", "´");
                    try
                    {
                        DateTime data = DateTime.Parse(input);
                        input = "'" + data.Year.ToString("0000") + "-" + data.Month.ToString("00") + "-" + data.Day.ToString("00") + "'";
                    }
                    catch
                    {
                        input = "NULL";
                    }
                    break;
                case Tipos.DateTime:
                    input = input.Replace("'", "´");
                    try
                    {
                        DateTime data = DateTime.Parse(input);
                        input = "'" + data.Year.ToString("0000") + "-" + data.Month.ToString("00") + "-" + data.Day.ToString("00") + " " + data.Hour.ToString("00") + ":" + data.Minute.ToString("00") + ":" + data.Second.ToString("00") + "'";
                    }
                    catch
                    {
                        input = "NULL";
                    }
                    break;
                case Tipos.NULL:
                    input = "NULL";
                    break;
            }
            return input;
        }

        #region DataGridView
        /// <summary>
        /// Metodo que verifica se existem registros em um componente DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView que sera testado</param>
        /// <returns>True/False</returns>
        public static bool HasRows(this DataGridView dgv)
        {
            return dgv.Rows.Count > 0;
        }
        /// <summary>
        /// Metodo que verifica se existem registro selecionados em um componente DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView que sera testado</param>
        /// <returns>True/False</returns>
        public static bool HasSelectedRows(this DataGridView dgv)
        {
            return dgv.SelectedRows.Count > 0;
        }
        #endregion

        #region DataTable
        /// <summary>
        /// Metodo que verifica se existem registros em um componente DataTable
        /// </summary>
        /// <param name="dt">DataTable que sera testado</param>
        /// <returns>True/False</returns>
        public static bool HasRows(this DataTable dt)
        {
            return dt.Rows.Count > 0;
        }

        #endregion
        /// <summary>
        /// Tipos de dados disponíveis para o banco MySQL
        /// </summary>
        public enum Tipos
        {
            /// <summary>
            /// Dado do tipo Booleano
            /// </summary>
            Bool,
            /// <summary>
            /// Dado do tipo Double (Decimal, float, ou numeric do MYSQL)
            /// </summary>
            Double,
            /// <summary>
            /// Campos do tipo Date (Sem hora)
            /// </summary>
            Date,
            /// <summary>
            /// Campo do tipo inteiro
            /// </summary>
            Integer,
            /// <summary>
            /// Campo do Tipo Datetime (também funciona para Timestamp)
            /// </summary>
            DateTime,
            /// <summary>
            /// Campo do tipo Texto (Varchar ou Char)
            /// </summary>
            Text,
            /// <summary>
            /// Campo do tipo Text já com o wildcard like (%)
            /// </summary>
            TextLike,
            /// <summary>
            /// Campo do tipo Monetario (Decimal, numeric, double, float)
            /// </summary>
            Currency,
            /// <summary>
            /// Valores 0 ou 1
            /// </summary>
            Bit,
            /// <summary>
            /// Valor NULO
            /// </summary>
            NULL
        }
    }
}
