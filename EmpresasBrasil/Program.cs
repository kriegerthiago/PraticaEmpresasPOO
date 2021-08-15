using System;


namespace EmpresasBrasil
{
    class Program
    {
        static void Main(string[] args)
        {
                                 
            Console.WriteLine("Bem Vindo ao Sistema de Empresas, para continuar" +
                "Digite o Nome da Empresa que queira Acesso: (Ex: MEI,ME,EPP)");

             string EmpresaAlvo = Convert.ToString(Console.ReadLine());

            if (EmpresaAlvo == "MEI")
            {
                MEI empresaMEI = new MEI();
               
                Console.WriteLine("Bem Vindo a Empresa MEI, digite 1- para emitir nota fiscal," +
                    "2- para Receber a Guia de pagamente e 3- Para realizar Contato");
               string escolha = Convert.ToString(Console.ReadLine());

                if(escolha == "1")
                {

                    empresaMEI.EmitirNota();
                    
                }else if(escolha == "2")
                {
                  
                    empresaMEI.ReceberGuia();

                }else if(escolha == "3")
                {
                    empresaMEI.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }



            }else if(EmpresaAlvo == "ME")
            {
                ME empresaME = new ME();
                
                Console.WriteLine("Bem Vindo a Empresa ME, digite 1- para emitir nota fiscal," +
                    "2- para Receber a Guia de pagamente e 3- Para realizar Contato");
                 string escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {

                    empresaME.EmitirNota();

                }
                else if (escolha == "2")
                {

                    empresaME.ReceberGuia();

                }
                else if (escolha == "3")
                {
                    empresaME.Contato();

                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }


            }
            else if(EmpresaAlvo == "EPP")
            {
                EPP empresaEPP = new EPP();

                Console.WriteLine("Bem Vindo a Empresa EPP, digite 1 para emitir nota fiscal," +
                    "2 para Receber a Guia de pagamente e 3- Para realizar Contato");
                string escolha = Convert.ToString(Console.ReadLine());

                if (escolha == "1")
                {

                    empresaEPP.EmitirNota();

                }
                else if (escolha == "2")
                {
                    empresaEPP.ReceberGuia();

                }
                else if (escolha == "3")
                {
                    empresaEPP.Contato();
                }
                else
                {
                    Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");
                }


            }
            else
            {

                Console.WriteLine("Nenhuma Opção acima foi selecionada, tente novamente!");




            }

        }
    }
}
