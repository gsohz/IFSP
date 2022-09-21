using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Agenda
{
    class Contato
    {
        private string email;
        private string nome;
        private Data dtNasc;
        private List<Telefone> telefones;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }
        internal List<Telefone> Telefones { get => telefones; set => telefones = value; }

        public Contato()
        {
            Email = "-1";
            Telefones = new List<Telefone>();
        }
        public Contato(string email)
        {
            Email = email;
           
        }
        public Contato(string email, string nome, Data dtNasc, List<Telefone> telefones)
        {
            Email = email;
            Nome = nome;
            DtNasc = dtNasc;
            Telefones = telefones;
           
        }

        public int GetIdade()
        {
            DateTime today = DateTime.Today;
            DateTime nasc = Convert.ToDateTime(DtNasc.ToString());
            int idade = today.Year - nasc.Year;


            if ((nasc.Month > DateTime.Now.Month) || (nasc.Month == DateTime.Now.Month && nasc.Day > DateTime.Now.Day))
                idade--;

            return idade;
        }

        public void AdicionarTelefone(Telefone t)
        {
            Telefones.Add(t);
        }

        public string GetTelefonePrincipal()
        {
            Telefone aux;
            foreach (Telefone tel in Telefones)
            {
                if (tel.Principal == true)
                {
                    aux = tel;
                    return aux.Numero;
                }
            }

            return "Não existe um telefone principal";
            
        }

        public override string ToString()
        {
            string principal = GetTelefonePrincipal();
            string tels = "";
            int idade = GetIdade();

            foreach (Telefone tel in Telefones)
            {
                if (tel.Principal.Equals(false))
                {
                    tels += tel.Numero;
                }
            }

            string result = "Nome: " + Nome + " | Idade: " + idade + " | Email: " + Email + " | Nascimento: " + DtNasc + " | Tel. Principal: " + principal + " | Outros telefones: " + (tels != "" ? tels : "Não possui outros");
            return result;
        }

        public override bool Equals(object obj)
        {
            return Email.Equals(((Contato)obj).Email);
        }


    }
}
