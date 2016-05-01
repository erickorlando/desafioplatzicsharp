using System;

namespace Desafio03PlatziCSharp.WebApi.Models
{
    public class Video : Media
    {
        public TimeSpan Duracion { get; set; }
        public FormatoVideo Formato { get; set; }
    }

    public enum FormatoVideo
    {
        Mp4,
        Avi,
        Flv
    }
}
