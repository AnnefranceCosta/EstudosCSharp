namespace Ex01PessoaMaisVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Qual o NOME da primeira pessoa? ");
            pessoa1.name = Console.ReadLine();

            Console.WriteLine("Qual a IDADE da primeira pessoa?");
            pessoa1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o NOME da segunda pessoa?");
            pessoa2.name = Console.ReadLine();

            Console.WriteLine("Qual a IDADE da segunda pessoa?");
            pessoa2.age = int.Parse(Console.ReadLine());

            if (pessoa1.age > pessoa2.age)
            {
                Console.WriteLine($"{pessoa1.name} é mais velho(a)!");
            } else if (pessoa2.age > pessoa1.age)
            {
                Console.WriteLine($"{pessoa2.name} é mais velho(a)!");
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade!");
            }

        }
    }
}