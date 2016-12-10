﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FuncoesGerais.Componentes
{
    public partial class LabelComValor : Label
    {
        private string _valor1;
        public string Valor1
        {
            get { return _valor1; }
            set 
            {
                _valor1 = value;
                AtualizaTexto();
            }
        }
        private string _valor2;
        public string Valor2
        {
            get { return _valor2; }
            set 
            { 
                _valor2 = value;
                AtualizaTexto();
            }
        }
        private string _valor3;
        public string Valor3
        {
            get { return _valor3; }
            set
            {
                _valor3 = value;
                AtualizaTexto();
            }
        }
        private string _valor4;
        public string Valor4
        {
            get { return _valor4; }
            set
            {
                _valor4 = value;
                AtualizaTexto();
            }
        }
        private string _textoReplace = string.Empty;
        public string TextoReplace 
        {
            get { return this._textoReplace; }
            set { this._textoReplace = value; AtualizaTexto(); }
        }
        private void AtualizaTexto()
        {
            this.Text = this.TextoReplace.Replace("{1}", this.Valor1).Replace("{2}", this.Valor2)
                .Replace("{3}", this.Valor3).Replace("{4}", this.Valor4);
        }
        public LabelComValor()
        {
            InitializeComponent();
        }
        public LabelComValor(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
