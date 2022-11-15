using System;

namespace ED_Medicamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            Medicamentos medicamentos = new Medicamentos();

            do
            {
                Console.WriteLine(
                  "\n--------------------------------------------------------------------" +
                  "\n| 0. Finalizar processo                                            |" +
                  "\n| 1. Cadastrar medicamento                                         |" +
                  "\n| 2. Consultar medicamento (sintético: informar dados)            |" +
                  "\n| 3. Consultar medicamento (analítico: informar dados + lotes)   |" +
                  "\n| 4. Comprar medicamento (cadastrar lote)                          |" +
                  "\n| 5. Vender medicamento (abater do lote mais antigo)               |" +
                  "\n| 6. Listar medicamentos (informando dados sintéticos)             |" +
                  "\n--------------------------------------------------------------------");

                Console.Write("\n\nEscolha uma opção: ");
                key = int.Parse(Console.ReadLine());
                Console.Write("\n\n");

                switch (key)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            } while (key != 0);
        }
    }
}
