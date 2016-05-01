namespace Desafio03PlatziCSharp.WebApi.Models
{
    public class Media
    {
        public int Id { get; set; }
        public Size Tamaño { get; set; }
        public string Nombre { get; set; }
        public string Path { get; set; }
    }

    public struct Size
    {
        public short Width { get; set; }
        public short Height { get; set; }
    }
}
