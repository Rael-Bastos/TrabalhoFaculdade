using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiasFmuTrabalho.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticias> noticias;

        public static List<Noticias> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }
        private static void CriarNoticias()
        {
            noticias = new List<Noticias>();

            noticias.Add(new Noticias
            {
                Id = 1,
                Titulo = " Teste 1",
                Autor = "Israel Bastos",
                Data = DateTime.Today,
                Conteudo = "Teste 1, Teste 1,Teste 1, Teste 1,Teste 1"
            });

            noticias.Add(new Noticias
            {
                Id = 2,
                Titulo = " Teste 2",
                Autor = "Israel Basto 2",
                Data = DateTime.Today,
                Conteudo = "Teste 2, Teste 2,Teste 2, Teste 2,Teste 2"
            });

            noticias.Add(new Noticias
            {
                Id = 3,
                Titulo = " Teste 3",
                Autor = "Israel Basto 3",
                Data = DateTime.Today,
                Conteudo = "Teste 3, Teste 3,Teste 3, Teste 3,Teste 3"
            });

        }
    }
}