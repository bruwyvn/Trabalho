using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Trabalho
{
    class Usuario
    {
        string nome;
        string senha;

        public Usuario(string n, string s)
        {
            nome = n;
            senha = s;
        }

        string GerarHash(string password)
        {
            //converte password de string ("array de chars") para array de bytes
            byte[] passwordEmBytes = System.Text.Encoding.UTF8.GetBytes(password);
            //gera a hash correspondente usando o sha256
            byte[] hashEmBytes = SHA256.Create().ComputeHash(passwordEmBytes);
            //converte array de bytes de novo para string
            string hashEmString = BitConverter.ToString(hashEmBytes);
            //remove os hifens
            hashEmString = hashEmString.Replace("-", String.Empty);
            //retorna hash
            return hashEmString;
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string n)
        {
            nome = n;
        }

        public string getSenha()
        {
            return senha;
        }

        public string Serializar()
        {
            return nome + "," + senha;
        }
    }

    class BaseUsuario
    {
        string filename;
        List<Usuario> usuarios;

        public BaseUsuario(string f)
        {
            filename = f;
            usuarios = new List<Usuario>();
            Carregar();
        }

        //===================================================================================================================================
        public void Carregar()
        {
            if (!File.Exists(filename))
            {
                File.CreateText(filename);
            }
            string input = File.ReadAllText(filename);
            string[] linhas = input.Split("\n");
            foreach (var linha in linhas)
            {
                if (linha.Length > 0)
                {
                    string[] valores = linha.Split(",");
                    Usuario usuario = new Usuario(valores[1], valores[2]);
                    usuarios.Add(usuario);
                }
            }
        }

        //===================================================================================================================================

        public string Serializar()
        {
            string output = "";
            foreach (var usuario in usuarios)
            {
                output += usuario.Serializar + "\n";
            }
            return output;
        }
        //============================================================================================================================================

        public void Salvar()
        {
            string output = Serializar();
            File.WriteAllText(filename, output);
        }

        //=================================================================================================================================

        public void Limpar()
        {
            usuarios.Clear();
        }

        //======================================================= Cadastro ============================================================       
        public void Cadastro(Usuario u)
        {
            usuarios.Add(u);

            Console.WriteLine("Usuário criado com sucesso");
            Teclado.leString("Enter para continuar");

        }

        public bool senhaForte(string senha)
        {
            bool senhaForte = true;

            if (!senha.Contains("") && senha.Length < 8)
            {
                senhaForte = false;
            }

            return senhaForte;
        }

        //===================================================== Login =======================================================================

        public bool login(string usuario, string senha)
        {
            bool usuarioEncontrado = false, senhaEncontrada = false, loginRealizado = true;

            foreach (var login in usuario)
            {

                if (usuarioEncontrado == false)
                {
                    if (login.Equals(usuario))
                    {
                        usuarioEncontrado = true;
                    }
                    else
                    {
                        usuarioEncontrado = false;
                    }
                }
                if (senhaEncontrada == false)
                {
                    if (login.Equals(senha))
                    {
                        senhaEncontrada = true;
                    }
                    else
                    {
                        senhaEncontrada = false;
                    }
                }
            }

            if (usuarioEncontrado.Equals(true) && senhaEncontrada.Equals(true))
            {
                loginRealizado = true;
                Console.WriteLine($"Bem vindo a sua conta {usuario}");
            }
            else
            {
                loginRealizado = false;
                Console.WriteLine("Usuário ou senha estão incorretos");
            }

            return loginRealizado;
        }

        //==================================================== Atualizar usuário ==================================================

        public static void Atualizar()
        {

        }

        //================================================= Deletar usuário ======================================================

        public void deletar()
        {

        }
    }
}