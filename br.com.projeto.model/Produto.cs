﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_Vendas.br.com.projeto.model
{
    public class Produto
    {
        public int id { get; set; }

        public string descricao {  get; set; }

        public decimal preco { get; set; }

        public int estoque { get; set; }

        public int for_id { get; set; }

    }
}
