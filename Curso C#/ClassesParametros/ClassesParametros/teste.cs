﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesParametros
{
    class teste
    {
        //public void Acrescentar(ref int valor)
        //{
        //    valor += 5;
        //}

        public int Acrescentar(int valor = 20)
        {
            valor += 10;
            return valor;
        }
        public void Diminuir(ref int valor)
        {
            valor -= 5;
        }
    }
}
