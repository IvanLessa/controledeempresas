using ProjetoAula05.Entities;
using ProjetoAula05.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Controllers
{
    public class EmpresaController
    {
        public void CadastrarEmpresa()
        {
            try
            {

                Console.WriteLine("\n*** CADASTRO DE EMPRESA ***\n");

                var empresa = new Empresa();
                empresa.Id = Guid.NewGuid();

                Console.Write("Entre com o Nome Fantasia.....: ");
                empresa.NomeFantasia = Console.ReadLine();

                Console.Write("Entre com a Razão Social......: ");
                empresa.RazaoSocial = Console.ReadLine();

                Console.Write("Entre com o CNPJ..............: ");
                empresa.Cnpj = Console.ReadLine();

                var empresaRepository = new EmpresaRepository();
                empresaRepository.Inserir(empresa);

                Console.WriteLine($"Empresa '{empresa.NomeFantasia}' cadastrada com sucesso!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"\nErro de validação: {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"\nErro ao cadastrar empresa: {e.Message}");
            }
        }

        public void ConsultarEMpresa()
        {
            try
            {
                Console.WriteLine("\n*** CONSULTA DE EMPRESA ***\n");

                var empresaRepository = new EmpresaRepository();
                var empresas = empresaRepository.Consultar();

                foreach (var item in empresas)
                {

                    Console.WriteLine($"ID.................: {item.Id}");
                    Console.WriteLine($"NOME FANTASIA......: {item.NomeFantasia}");
                    Console.WriteLine($"RAZÃO SOCIAL.......: {item.RazaoSocial}");
                    Console.WriteLine($"CNPJ...............: {item.Cnpj}");
                    Console.WriteLine("\n...........\n");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"\nErro ao consultar empresa: {e.Message}");
            }
        }
    }
}
