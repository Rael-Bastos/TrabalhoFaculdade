using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoticiasFmuTrabalho.Models
{
    public class Noticias
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public string Conteudo { get; set; }
    }
}