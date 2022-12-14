using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;


namespace ED_Acesso
{
    [Serializable()]
    class Cadastro
    {
        private List<Usuario> usuarios;
        private List<Ambiente> ambientes;

        internal List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public Cadastro()
        {
            Usuarios = new List<Usuario>();
            Ambientes = new List<Ambiente>();
        }

        public void adicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public bool removerUsuario(Usuario usuario)
        {
            Usuarios.Remove(usuario);
            bool remov = true;

            foreach (Usuario u in Usuarios)
            {
                if (u.Equals(usuario))
                {
                    remov = false;
                    return remov;
                }
            }
            return remov;
        }

        public Usuario pesquisarUsuario(Usuario usuario)
        {
            Usuario aux = new Usuario(-1);

            foreach (Usuario u in Usuarios)
            {
                if (u.Equals(usuario))
                {
                    aux = u;
                    return aux;
                }
            }
            return aux;
        }

        public void adicionarAmbiente(Ambiente ambiente)
        {
            Ambientes.Add(ambiente);
        }

        public bool removerAmbiente(Ambiente ambiente)
        {
            Ambientes.Remove(ambiente);
            bool remov = true;

            foreach (Ambiente a in Ambientes)
            {
                if (a.Equals(ambiente))
                {
                    remov = false;
                    return remov;
                }
            }
            return remov;
        }

        public Ambiente pesquisarAmbiente(Ambiente ambiente)
        {
            Ambiente aux = new Ambiente(-1);

            foreach (Ambiente a in Ambientes)
            {
                if (a.Equals(ambiente))
                {
                    aux = a;
                    return aux;
                }
            }
            return aux;
        }

        public void upload()
        {



        }

        public void download()
        {



        }
    }
}
