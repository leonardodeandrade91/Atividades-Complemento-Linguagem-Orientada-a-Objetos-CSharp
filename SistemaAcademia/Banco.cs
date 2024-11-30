using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SistemaAcademia {
    class Banco {
        private static SQLiteConnection conexao;
        private static string dirAtual = Directory.GetCurrentDirectory();

        private static SQLiteConnection conexaoBanco() {
            conexao = new SQLiteConnection($"Data Source={dirAtual}\\bancos\\academia.db3");

            conexao.Open();

            return conexao;
        }

        private static DataTable obterTodosUsuarios() {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();

                comando.CommandText = "select * from usuario";

                dataAp = new SQLiteDataAdapter(comando.CommandText, conexaoBanco());

                dataAp.Fill(dataTab);

                conexaoBanco().Close();

                return dataTab;
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static DataTable consultaBanco(string sql) {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();
                
                comando.CommandText = sql;

                dataAp = new SQLiteDataAdapter(comando.CommandText, conexaoBanco());

                dataAp.Fill(dataTab);

                conexaoBanco().Close();

                return dataTab;
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static DataTable consultaBanco(string sql, Dictionary<string, string> dados) {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();

                comando.CommandText = sql;

                if(dados.Count > 0) {
                    foreach(KeyValuePair<string, string> d in dados) {
                        comando.Parameters.AddWithValue(d.Key, d.Value);
                    }
                }

                comando.CommandType = CommandType.Text;

                dataAp = new SQLiteDataAdapter(comando.CommandText, conexaoBanco());

                dataAp.SelectCommand = comando;

                dataAp.Fill(dataTab);

                conexaoBanco().Close();

                return dataTab;
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static void novoUser(Usuario user) {
            if(existUser(user)) {
                MessageBox.Show("Username já Existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            try {
                SQLiteCommand comando = conexaoBanco().CreateCommand();

                comando.CommandText = "insert into usuario (nome, username, senha, status, nivel) values (@nome, @username, @senha, @status, @nivel)";

                comando.Parameters.AddWithValue("@nome", user.nome);
                comando.Parameters.AddWithValue("@username", user.username);
                comando.Parameters.AddWithValue("@senha", user.senha);
                comando.Parameters.AddWithValue("@status", user.status);
                comando.Parameters.AddWithValue("@nivel", user.nivel);

                comando.ExecuteNonQuery();

                MessageBox.Show("Novo Usuário Inserido!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexaoBanco().Close();
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                conexaoBanco().Close();
            }
        }

        public static bool existUser(Usuario user) {
            bool res;
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();
            SQLiteCommand comando = conexaoBanco().CreateCommand();

            comando.CommandText = "select * from usuario where username = @username";

            comando.Parameters.AddWithValue("@username", user.username);

            comando.CommandType = CommandType.Text;

            dataAp = new SQLiteDataAdapter(comando.CommandText, conexaoBanco());

            dataAp.SelectCommand = comando;

            dataAp.Fill(dataTab);

            if(dataTab.Rows.Count == 1) {
                res = true;
            }
            else {
                res = false;
            }

            conexaoBanco().Close();

            return res;
        }

        public static DataTable obterUsuarioIdNome() {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();

                comando.CommandText = "select id as 'ID', nome as 'Nome' from usuario";

                dataAp = new SQLiteDataAdapter(comando.CommandText, conn);

                dataAp.Fill(dataTab);

                conn.Close();

                return dataTab;
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static DataTable obterDadosUsuario(int id) {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();

                comando.CommandText = "select * from usuario where id = @id";

                comando.Parameters.AddWithValue("@id", id);

                comando.CommandType = CommandType.Text;

                dataAp = new SQLiteDataAdapter(comando.CommandText, conn);

                dataAp.SelectCommand = comando;

                dataAp.Fill(dataTab);

                conn.Close();

                return dataTab;
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public static void atualizarUsuario(Usuario u) {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();

                comando.CommandText = "update usuario set nome = @nome, username = @username, senha = @senha, status = @status, nivel = @nivel where id = @id";

                comando.Parameters.AddWithValue("@nome", u.nome);
                comando.Parameters.AddWithValue("@username", u.username);
                comando.Parameters.AddWithValue("@senha", u.senha);
                comando.Parameters.AddWithValue("@status", u.status);
                comando.Parameters.AddWithValue("@nivel", u.nivel);
                comando.Parameters.AddWithValue("@id", u.id);

                dataAp = new SQLiteDataAdapter(comando.CommandText, conn);

                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void excluirUsuario(int id) {
            SQLiteDataAdapter dataAp = null;
            DataTable dataTab = new DataTable();

            try {
                SQLiteConnection conn = conexaoBanco();

                SQLiteCommand comando = conn.CreateCommand();

                comando.CommandText = "delete from usuario where id = @id";

                comando.Parameters.AddWithValue("@id", id);

                dataAp = new SQLiteDataAdapter(comando.CommandText, conn);

                comando.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show($"ERRO: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
