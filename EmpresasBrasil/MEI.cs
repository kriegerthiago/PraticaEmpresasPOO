using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresasBrasil
{
    class MEI : Empresa
    {

      public override void EmitirNota()
        {
            Console.WriteLine("A emissão da Nota Fiscal da Empresa MEI foi Concluída!");
        }
      public override void ReceberGuia()
        {
        
            Console.WriteLine("Digite a data de vencimento da guia desejada:  Ex(13-10-1994");
           string DataVenc = Convert.ToString(Console.ReadLine());
            DateTime dt = DateTime.ParseExact(DataVenc, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

             Console.WriteLine("As Guias de imposto da Empresa MEI foi recebida com a data de vencimento para  dia " + DataVenc);
        }

        public override void Contato()
        {
            Console.WriteLine("Solicitação de Contato com a Empresa MEI Realizada!");
        }

    }
}
