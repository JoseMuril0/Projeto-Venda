namespace MercadoriasAlura
{
    public class Mercadorias
    {
        public int Id { get; internal set; }       
        public string Descricao { get; internal set; }
        public string CodigoBarra { get; internal set; }
        public double Preco { get; internal set; }
        public string Unidade { get; internal set; }

        public Mercadorias()
        {

        }

        public Mercadorias(string descricao, string codigoBarra
            , double preco, string unidade)
        {
            Descricao = descricao;
            CodigoBarra = codigoBarra;
            Preco = preco;
            Unidade = unidade;
        }

        public override string ToString()
        {
            return $"Nome do produto: {Descricao} " +
                $"Preço: R$ {Preco}\nID: {Id}";
        }
    }
}