﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern01
{
	public class NotaFiscal
	{
		public string RazaoSocial { get; set; }
		public string Cnpj { get; set; }
		public DateTime DataEmissao{ get; set; }
		public double ValorBruto{ get; set; }
		public double Impostos { get; set; }
		public IList<ItemDaNota> Itens { get; set; }
		public string Observacao { get; set; }

		public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacao )
		{
			RazaoSocial = razaoSocial;
			Cnpj = cnpj;
			DataEmissao = dataEmissao;
			ValorBruto = valorBruto;
			Impostos = impostos;
			Itens = itens;
			Observacao = observacao;
		}
	}
}
