﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Funcionario:CadastroBase
    {
        public string Cargo {  get; set; }  
        public decimal Salario {  get; set; }   
    }
}
