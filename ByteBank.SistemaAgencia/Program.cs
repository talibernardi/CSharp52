using ByteBank.Modelos;
using ByteBank.Modelos.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);

            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("asiwqos");
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
