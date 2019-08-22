using NoticiasFmuTrabalho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoticiasFmuTrabalho.Controllers
{
    public class NoticiasController : Controller
    {

        public ActionResult Index()
        {
            return View(RepositorioNoticias.Noticias);
        }
        public ActionResult Detalhes(int id)
        {
            var noticia = RepositorioNoticias.Noticias.FirstOrDefault(x => x.Id == id);
            return View(noticia);
        }

        public ActionResult Busca(string texto)
        {
            var buscarNoticias = RepositorioNoticias.Noticias.Where(x => x.Titulo.Contains(texto) || x.Conteudo.Contains(texto));
            return View(buscarNoticias);
        }
    }
}