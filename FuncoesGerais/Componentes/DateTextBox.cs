using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace FuncoesGerais.Componentes
{
    public partial class DateTextBox : MaskedTextBox
    {
        public DateTextBox()
        {
            InitializeComponent();
        }
        public DateTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        private DateType tipoData = DateType.Short;

        public DateType TipoData
        {
            get { return this.tipoData; }
            set { this.tipoData = value; }
        }

        private string customMask = "99/99/9999";
        public string CustomMask
        {
            get { return this.customMask; }
            set 
            {
                if (this.TipoData == DateType.Short)
                    this.customMask = "99/99/9999";
                else
                    this.customMask = "99/99/9999 99:99";
                this.Mask = this.customMask;
            }
        }

        private void DateTextBox_Leave(object sender, EventArgs e)
        {
            this.Text = this.Text.DateComplete();
        }

    }

    public enum DateType 
    {
        Short,
        ShortWithTime
    }
}
