using ProjetoAula05.Entities;
using ProjetoAula05.Enums;
using ProjetoAula05.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Controllers
{
    public class FuncionarioController
    {
        public void CadastarFuncionario()
        {
			try
			{
                Console.WriteLine("\n*** CADASTRO DE FUNCIONÁRIO ***\n");

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("Entre com o Nome du funcionário.....: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Entre com CPF.......................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("Entre com a matrícula...............: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("Entre com a Data de admissão........: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Status:\r\n\tAtivo = 1,\r\n\tAfastado = 2," +
                    "\r\n\tFerias = 3,\r\n\tDemitido = 4\r\n\tEntre com a opção ----> ");
                funcionario.Status = (StatusFuncionario) int.Parse(Console.ReadLine());

                Console.Write("Entre com o ID da Empresa...........: ");
                funcionario.IdEmpresa = Guid.Parse(Console.ReadLine());

                var funcionarioRepository = new FuncionarioRepository();
                funcionarioRepository.Inserir(funcionario);

                Console.WriteLine($"\nO(a) funcionário(a) '{funcionario.Nome}' foi cadastrado(a) com sucesso!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"\nErro de validação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nErro ao cadastrar funcionário: {e.Message}");
            }
        }

        public void ConsultarFuncionario()
        {
            try
            {
                Console.WriteLine("\n*** CONSULTA DE FUNCIONÁRIOS ***\n");

                var funcionarioRepository = new FuncionarioRepository();
                var funcionarios = funcionarioRepository.Consultar();

                foreach (var item in funcionarios)
                {
                    Console.WriteLine("\n***********\n");
                    Console.WriteLine($"ID DO FUNCIONÁRIO..: {item.Id}");
                    Console.WriteLine($"NOME...............: {item.Nome}");
                    Console.WriteLine($"CPF................: {item.Cpf}");
                    Console.WriteLine($"MATRÍCULA..........: {item.Matricula}");
                    Console.WriteLine($"DATA DE ADMISSÃO...: {item.DataAdmissao}");
                    Console.WriteLine($"STATUS.............: {item.Status}");
                    Console.WriteLine($"\nID DA EMPRESA......: {item.Empresa.Id}");
                    Console.WriteLine($"NOME FANTASIA......: {item.Empresa.NomeFantasia}");
                    Console.WriteLine($"RAZÃO SOCIAL.......: {item.Empresa.RazaoSocial}");
                    Console.WriteLine($"CNPJ...............: {item.Empresa.Cnpj}");
                    

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nErro ao consultar funcionário: {e.Message}");
            }
        }
    }
}
