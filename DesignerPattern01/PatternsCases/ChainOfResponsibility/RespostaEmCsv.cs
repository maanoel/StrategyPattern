﻿using System;

namespace DesignerPattern01
{
  class RespostaEmCsv : IResposta
  {
    public IResposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta)
    {
      if(req.Formato == Formato.CSV)
      {
        Console.WriteLine(conta.Titular + ";" + conta.Saldo);
      }
      else
      {
        OutraResposta.Responde(req, conta);
      }
    }
  }
}
