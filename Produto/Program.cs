using System.Globalization;


namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            p.Name = Console.ReadLine();

            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Numbers = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int amt = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(amt);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}