namespace Prueba_Banco.Models
{
    public class Ventas
    {
        public int id { get; set; }
        public string? CODGTE { get; set; }
        public string? NOMGTE { get; set; }
        public string? CODCOOR { get; set; }
        public string? NOMCOOR { get; set; }
        public string? CODVENTAS { get; set; }
        public string? NOMVEND { get; set; }
        public string? CODNIVEL { get; set; }
        public string? NOMNIVEL { get; set; }
        public float? NIT_CLIENTE { get; set; }
        public string? ITEM { get; set; }
        public string? NOM_CLIENTE { get; set; }
        public string? SEGMENTO { get; set; }
        public string? GERENCIADO { get; set; }
        public float? OFICINA_CLIENTE { get; set; }
        public float? FECHAFIL { get; set; }
        public int? PERIODOMED { get; set; }
        public int? CONDIC { get; set; }
        public int? CTACAMP { get; set; }

        public Ventas()
        {

        }
    }


}
