﻿namespace DesignerPattern01
{
	public class ICPP : TemplateDeImpostoCondicional
	{
		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor >= 500;
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.07;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.05;
		}
	}
}
