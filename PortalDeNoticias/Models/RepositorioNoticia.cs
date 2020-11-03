using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticia
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticia();
                return noticias;
            }
        }

        private static void CriarNoticia()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "João Calors",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam finibus congue efficitur. Morbi eget lorem eleifend, consectetur sapien non, rutrum eros. Integer dictum ipsum eu vehicula pellentesque. Integer ullamcorper magna aliquam tempor eleifend. Ut sed lobortis ante. Pellentesque finibus laoreet tristique. Integer lobortis, orci quis maximus eleifend, sapien est sodales purus, vitae mattis dui risus suscipit quam."
            });
            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Pedro Alvares",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam finibus congue efficitur. Morbi eget lorem eleifend, consectetur sapien non, rutrum eros. Integer dictum ipsum eu vehicula pellentesque. Integer ullamcorper magna aliquam tempor eleifend. Ut sed lobortis ante. Pellentesque finibus laoreet tristique. Integer lobortis, orci quis maximus eleifend, sapien est sodales purus, vitae mattis dui risus suscipit quam."
            });
            noticias.Add(new Noticia
            {
                Id =3,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Lucas Pinto",
                Data = DateTime.Today.AddDays(-2),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam finibus congue efficitur. Morbi eget lorem eleifend, consectetur sapien non, rutrum eros. Integer dictum ipsum eu vehicula pellentesque. Integer ullamcorper magna aliquam tempor eleifend. Ut sed lobortis ante. Pellentesque finibus laoreet tristique. Integer lobortis, orci quis maximus eleifend, sapien est sodales purus, vitae mattis dui risus suscipit quam."
            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Aran Wesley",
                Data = DateTime.Today.AddDays(-1),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam finibus congue efficitur. Morbi eget lorem eleifend, consectetur sapien non, rutrum eros. Integer dictum ipsum eu vehicula pellentesque. Integer ullamcorper magna aliquam tempor eleifend. Ut sed lobortis ante. Pellentesque finibus laoreet tristique. Integer lobortis, orci quis maximus eleifend, sapien est sodales purus, vitae mattis dui risus suscipit quam."
            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Andrew Marques",
                Data = DateTime.Today.AddDays(-5),
                Conteudo = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam finibus congue efficitur. Morbi eget lorem eleifend, consectetur sapien non, rutrum eros. Integer dictum ipsum eu vehicula pellentesque. Integer ullamcorper magna aliquam tempor eleifend. Ut sed lobortis ante. Pellentesque finibus laoreet tristique. Integer lobortis, orci quis maximus eleifend, sapien est sodales purus, vitae mattis dui risus suscipit quam."
            });

        }
    }
}