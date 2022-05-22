using RH.Models;

namespace RH.Repository
{
    public static class FuncionarioRepository
    {
        public static List<Funcionario> Funcionarios = new() { new Funcionario() { Id = 1, Nome = "admin", Permissao = Enums.Permissoes.Administrador, Senha = "admin" } };

        public static List<Funcionario> Obter()
        {
            return Funcionarios;
        }

        public static Funcionario? ObterPorUsuarioESenha(string nome, string senha)
        {
            return Funcionarios.Find(f => f.Nome == nome && f.Senha == senha);
        }
        
        public static void Adicionar(Funcionario funcionario)
        {
            var nextId = Funcionarios.Last().Id++;
            Funcionarios.Add(funcionario);
        }

        public static Funcionario? Editar(Funcionario funcionario, int id)
        {
            var indexFuncionario = Funcionarios.FindIndex(find => find.Id == id);
            if (indexFuncionario == -1) return null;
            funcionario.Id = id;
            Funcionarios[indexFuncionario] = funcionario;
            return funcionario;
        }

        public static void Excluir(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
        }
    }
}
