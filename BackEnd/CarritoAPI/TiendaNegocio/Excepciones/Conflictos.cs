namespace Tienda.Negocio.Excepciones
{
    public class ConflictosException : Exception
    {
        public string? Atributo { get; set; }
        public object? Valor { get; set; }

        public ConflictosException(string msg) : base(msg)
        {
            
        }

        public ConflictosException(string msg, string? atributo, object? valor) : base(msg)
        {
            Atributo = atributo;
            Valor = valor;
        }
    }
}
