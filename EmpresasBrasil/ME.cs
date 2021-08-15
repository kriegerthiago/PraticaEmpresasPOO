using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresasBrasil
{
    class ME:Empresa
    {
        public override void EmitirNota()
        {
            Console.WriteLine("A emissão da Nota Fiscal da Empresa ME foi Concluída!");
        }
        public override void ReceberGuia()
        {

            string DataVenc;
            Console.WriteLine("Digite a data de vencimento da guia desejada:  Ex(13-10-1994");
            DataVenc = Convert.ToString(Console.ReadLine());
            DateTime dt = DateTime.ParseExact(DataVenc, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);



            Console.WriteLine("As Guias de imposto da Empresa ME foi recebida com a data de vencimento para  dia " + DataVenc);

        }

        public override void Contato()
        {
            Console.WriteLine("Solicitação de Contato com a Empresa ME Realizada!");
        }




    }
}
