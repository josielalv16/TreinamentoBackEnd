﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teste objeto = new teste();
            int valor = 10;
            //objeto.Acrescentar(ref valor);
            valor = objeto.Acrescentar();

            label1.Text = valor.ToString();
        }
    }
}
