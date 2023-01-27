using ProjetoAula05.Controllers;

namespace ProjetoAula05
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("\n**** CONTROLE DE EMPRESAS E FUNCIONÁRIOS ****\n");

            Console.WriteLine("\t(1) Cadastrar Empresa");
            Console.WriteLine("\t(2) Consultar Empresa");
            Console.WriteLine("\t(3) Cadastrar Funcionários");
            Console.WriteLine("\t(4) Consultar Funcionário");

            Console.Write("\n Entre com a opção desejada....: ");
            var opcao = int.Parse(Console.ReadLine());

            var empresaController = new EmpresaController();
            var funcionarioController = new FuncionarioController();

            switch (opcao)
            {
                case 1:
                    empresaController.CadastrarEmpresa();
                    break;

                case 2:
                    empresaController.ConsultarEMpresa();
                    break;

                case 3:
                    funcionarioController.CadastarFuncionario();
                    break;

                case 4:
                    funcionarioController.ConsultarFuncionario();
                    break;

                default:
                    break;
            }

            Console.Write("\nDESEJA CONTINUAR? (S, N)...: ");
            var escolha = Console.ReadLine();

            if (escolha.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("\nFIM DO PROGRAMA!");
                Console.ReadKey();
            }
        }
    }
}





