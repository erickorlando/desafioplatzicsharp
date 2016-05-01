namespace Desafio03PlatziCSharp.WebApi.Models
{
    public class Imagen : Media
    {
        public FormatoImagen Formato { get; set; }
    }

    public enum FormatoImagen
    {
        Bmp,
        Jpg,
        Png
    }
}

