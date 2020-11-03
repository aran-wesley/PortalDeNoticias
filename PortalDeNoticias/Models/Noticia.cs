using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        //[DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        //[DataType(DataType.DateTime, ErrorMessage = "Data em formato inválido")]
        public DateTime Data { get; set; }
        public string Conteudo { get; set; }
    }
}