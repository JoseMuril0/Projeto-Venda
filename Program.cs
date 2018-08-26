using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoriasAlura
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tudo certo

            //Compra compra = new Compra()
            //{
            //    Mercadorias = new Mercadorias("Ração para cachorro 2kg",
            //    "78982981", 150.30, "KiloGrama"),
            //    Quantidade = 6
            //};
            //Console.WriteLine($"Compra instaciada =)");
            //using(var repor = new MercadoriaContext())
            //{
            //    repor.Compras.Add(compra);
            //    repor.SaveChanges();
            //    Console.WriteLine($"Compra adcoinada com sucesso");
            //}


            int options = 0;
            while(options != 5)
            {
                try
                {

                    MenuOptions();
                    options = int.Parse(Console.ReadLine());
                    if (options == 1)
                    {
                        AdcionarMerc();
                    } else if(options == 2)
                    {
                        DeletarMerc();
                    } else if (options == 3)
                    {
                        MostrarMerc();
                    } else if(options == 4)
                    {
                        AtualizarMerc();
                    } else if (options == 5)
                    {
                        Console.WriteLine("Programa finzalizado com sucesso . . .");
                    } else
                    {
                        Console.WriteLine("Opção digitada inválida... Tente novamente por favor :)");
                    }
                    Console.WriteLine("\n\nDigite enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            Console.ReadLine();
        }

     
        private static void AtualizarMerc()
        {

            Console.WriteLine(" - Atualizar descrições/Preços - ");
            Console.WriteLine("Informe o preco do produto: ");
            var IdTeste = int.Parse(Console.ReadLine());
            using(var contexto = new MercadoriaContext())
            {
                var primeiro = contexto.Mercadoria.ToList();
                
                for(int i = 0; i < primeiro.Count; i++)
                {
                    if (primeiro[i].Id == IdTeste)
                    {
                        Console.Write("Novo preço: ");
                        primeiro[i].Preco = double.Parse(Console.ReadLine());
                        contexto.Update(primeiro[i]);
                        contexto.SaveChanges();
                        Console.WriteLine("Preço do primeiro item alterado com sucesso!");
                    }
                }

            }
        }

        private static void DeletarMerc()
        {

            Console.Write("Informe o Id: ");
            var IdTeste = int.Parse(Console.ReadLine());

            using(var contexto = new MercadoriaContext())
            {
                var mercadorias = contexto.Mercadoria.ToList();

               // Console.WriteLine($"Quantidade de mercadorias {mercadorias.Count} ANTES");

                for(int i = 0; i < mercadorias.Count; i++)
                {
                    if (IdTeste == mercadorias[i].Id)
                    {
                        contexto.Mercadoria.Remove(mercadorias[i]);
                        contexto.SaveChanges();
                        Console.WriteLine("Deletado com sucesso!");
                    }
                }
            }
        }

        private static void MostrarMerc()
        {
            Console.WriteLine("Buscando dados do banco . . .");
            Console.ReadLine();

            using(var contexto = new MercadoriaContext())
            {
                IList<Mercadorias> mercadorias = contexto.Mercadoria.ToList();
                Console.WriteLine($"Encontrados: {mercadorias.Count} itens.\n");

                foreach(var e in mercadorias)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private static void AdcionarMerc()
        {

            Mercadorias M = new Mercadorias();

            do
            {
                Console.Write("Descrição:");
                M.Descricao = Console.ReadLine();
            }
            while (Conferir(M.Descricao));
            do
            {
                Console.Write("Codigo de barra: ");
                M.CodigoBarra = Console.ReadLine();
            }
            while (Conferir(M.CodigoBarra));

            Console.Write("Preço: R$ ");
            M.Preco = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Unidade: ");
                M.Unidade = Console.ReadLine();
            }
            while (Conferir(M.Unidade));
            

            using (var contexto = new MercadoriaContext())
            {
                contexto.Mercadoria.Add(M);
                contexto.SaveChanges();
                Console.WriteLine($"{M.Descricao} Foi adcionado com sucesso!");
            }
        }

        private static bool Conferir(string recebido)
        {
            if(recebido == "")
            {
                return true;
            }
            return false;
        }

        private static void MenuOptions()
        {
            Console.WriteLine("[01] - Castratar mercadoria");
            Console.WriteLine("[02] - Deletar todas mercadorias");
            Console.WriteLine("[03] - Mostrar mercadoriais");
            Console.WriteLine("[04] - Atualizar info/Mercadoria");
            Console.WriteLine("[05] - Sair");
            Console.Write(": ");
        }
    }
}
