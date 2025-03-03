﻿using System;
using System.Collections.Generic;

namespace DesignerPattern01.PatternsCases
{
	public abstract class Relatorio
  {
    protected abstract void Cabecalho();
    protected abstract void Rodape();
    protected abstract void Corpo(IList<Conta> contas);

    public void Imprime(IList<Conta> contas)
    {
      Cabecalho();
      Corpo(contas);
      Rodape();
    }
  }

  public class RelatorioSimples : Relatorio
  {
    protected override void Cabecalho()
    {
      Console.WriteLine("Banco XYZ");
    }

    protected override void Rodape()
    {
      Console.WriteLine("(11) 1234-5678");
    }

    protected override void Corpo(IList<Conta> contas)
    {
      foreach(Conta c in contas)
      {
        Console.WriteLine(c.Titular + " - " + c.Saldo);
      }
    }
  }

  public class RelatorioComplexo : Relatorio
  {
    protected override void Cabecalho()
    {
      Console.WriteLine("Banco XYZ");
      Console.WriteLine("Avenida Paulista, 1234");
      Console.WriteLine("(11) 1234-5678");
    }

    protected override void Rodape()
    {
      Console.WriteLine("banco@xyz.com.br");
      Console.WriteLine(DateTime.Now);
    }
    protected override void Corpo(IList<Conta> contas)
    {
      foreach(Conta c in contas)
      {

      }
    }
  }
}
