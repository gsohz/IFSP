using System;
using System.Collections.Generic;
using System.Text;

namespace ED_Acervo
{
    class Livros
    {
        private List<Livro> acervo;

        internal List<Livro> Acervo { get => acervo; set => acervo = value; }

        public Livros()
        {
            Acervo = new List<Livro>();
        }

        public void adicionar(Livro livro)
        {
           Acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            Livro aux = new Livro();

            foreach(Livro l in Acervo)
            {
                if (l.Equals(livro))
                {
                    aux = l;
                    return aux;
                }
            }

            return aux;
        }

    }
}
