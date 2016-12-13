using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace FuncoesGerais
{
    public partial class CurrencyTextBox : TextBox
    {
        public CurrencyTextBox()
        {
            InitializeComponent();
            this.Text = this.Text.FormatToDecimalIfValid(Decimais);
        }

        private int _decimais;

        public int Decimais
        {
            get { return _decimais;}
            set { _decimais = value; }
        }

        public CurrencyTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void CurrencyTextBox_Leave(object sender, EventArgs e)
        {
            this.Text = this.Text.FormatToDecimalIfValid(Decimais);
        }

        private void CurrencyTextBox_Enter(object sender, EventArgs e)
        {
            this.Text = this.Text.FormatToDecimalIfValid(Decimais);
        }

        private void CurrencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != ',' && e.KeyChar != (char)8)
                e.Handled = true;
            if (e.KeyChar == ',' && this.Text.IndexOf(',') >= 0)
                e.Handled = true;
        }

    }
}
