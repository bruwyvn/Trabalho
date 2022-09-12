using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {

            bool loopIncial = true;
            var baseUsuarios = new BaseUsuario("usuarios.csv");

            do
            {
                loopIncial = true;
                MenuInicial();
                int escolha = Teclado.leInteiro("Escolha uma das opções do menu: ");

                switch (escolha)
                {
                    case 1:
                        string usuario = Teclado.leString("Usuário: ");
                        string senha = "", confirmarSenha = "";
                        //do
                        //{
                        senha = Teclado.leString("Senha: ");
                        //} while (senhaForte(senha) == false);

                        do
                        {
                            confirmarSenha = Teclado.leString("Confirme sua senha: ");

                            if (confirmarSenha != senha)
                            {
                                Console.WriteLine("Confirmação de senha inválida");
                            }
                        } while (!confirmarSenha.Equals(senha));

                        var Conta = new Usuario(usuario, senha);
                        baseUsuarios.Cadastro(Conta);
                        baseUsuarios.Salvar();
                        break;

                    case 2:
                        usuario = Teclado.leString("Informe seu usuário: ");
                        senha = Teclado.leString("Informe sua senha: ");
                        bool loginEncontrado = baseUsuarios.login(usuario, senha);

                        if (loginEncontrado == true)
                        {
                            loopIncial = false;
                        }
                        break;

                    case 3:

                        break;

                    case 4:
                        
                        break;

                    case 5:
                        return;
                    default:
                        Teclado.leString("Opção inválida! Aperte Enter para continuar ");
                        break;
                }

            } while (loopIncial == true);

        }

        //====================================================== Menus ==================================================================
        static void MenuInicial()
        {
            Console.WriteLine(" Bem vindo ao menu inicial da biblioteca virtual \n O que deseja fazer \n" +
                              "1- Realizar cadastro \n" +
                              "2- Fazer login \n" +
                              "3- Atualizar dados \n" +
                              "4- Deletar usuário \n" +
                              "5- sair");
        }

    }
}
