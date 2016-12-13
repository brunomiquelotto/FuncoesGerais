using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace FuncoesGerais.Componentes
{
    public partial class RegexTextBox : TextBox
    {
        public RegexTextBox()
        {
            InitializeComponent();
        }
        private string _regex = "";
        private bool _testarQuandoVazio = false;
        private bool _regexFalhou = false;
        private Color _corErro = Color.Salmon;
        private Color _corPadrao = Color.White;
        /// <summary>
        /// Indica quando o componente já foi validado e se contem erros de validação
        /// </summary>
        public bool RegexFalhou 
        {
            get { return this.BackColor == this.CorErro; }
        }
        /// <summary>
        /// Recebe ou atribui se quando um texto é branco seu valor é testado
        /// </summary>
        public bool TestarQuandoVazio
        {
            get { return _testarQuandoVazio; }
            set { _testarQuandoVazio = value; }
        }
        /// <summary>
        /// Recebe ou atribui a cor que será utilizada no fundo do controle quando ocorrer um erro de validação
        /// </summary>
        public Color CorErro
        {
            get { return _corErro; }
            set { _corErro = value; }
        }
        /// <summary>
        /// Recebe ou atribui a cor que será utilizada no fundo do controle quando a validação obtiver exito
        /// </summary>
        public Color CorPadrao
        {
            get { return _corPadrao; }
            set { _corPadrao = value; }
        }
        /// <summary>
        /// Recebe ou atribui o padrão que será utilizado para testar o valor do Text ao executar o Leave
        /// </summary>
        public string Regex
        {
            get { return _regex; }
            set { _regex = value; }
        }
        public RegexTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        private void RegexTextBox_Leave(object sender, EventArgs e)
        {
            var rg = new Regex(this.Regex);

            if (rg.IsMatch(this.Text) || (!TestarQuandoVazio && this.Text == string.Empty))
                this.BackColor = this.CorPadrao;
            else
                this.BackColor = this.CorErro;
        }
    }
}
