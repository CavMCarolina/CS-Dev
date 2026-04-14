using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace CP2
{
    public class AlunoRepository
    {
        // Inserir
        public void Inserir(Aluno aluno)
        {
            const string sql = "INSERT INTO Alunos (Nome, Idade) VALUES (@Nome, @Idade)";

            using var conn = DatabaseConfig.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Idade", aluno.Idade);
            cmd.ExecuteNonQuery();
        }

        // Listar
        public List<Aluno> ListarTodos()
        {
            const string sql = "SELECT Id, Nome, Idade FROM Alunos ORDER BY Id";
            var lista = new List<Aluno>();

            using var conn = DatabaseConfig.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Aluno
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    Idade = reader.GetInt32("Idade")
                });
            }

            return lista;
        }

        // Buscar por ID
        public Aluno BuscarPorId(int id)
        {
            const string sql = "SELECT Id, Nome, Idade FROM Alunos WHERE Id = @Id";

            using var conn = DatabaseConfig.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Aluno
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    Idade = reader.GetInt32("Idade")
                };
            }

            return null;
        }

        // Atualizar
        public bool Atualizar(Aluno aluno)
        {
            const string sql = "UPDATE Alunos SET Nome = @Nome, Idade = @Idade WHERE Id = @Id";

            using var conn = DatabaseConfig.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Idade", aluno.Idade);
            cmd.Parameters.AddWithValue("@Id", aluno.Id);

            int linhasAfetadas = cmd.ExecuteNonQuery();
            return linhasAfetadas > 0;
        }

        // Remover
        public bool Remover(int id)
        {
            const string sql = "DELETE FROM Alunos WHERE Id = @Id";

            using var conn = DatabaseConfig.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            int linhasAfetadas = cmd.ExecuteNonQuery();
            return linhasAfetadas > 0;
        }
    }
}
