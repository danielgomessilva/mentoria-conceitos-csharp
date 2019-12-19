using System;

namespace Conceitos_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var idDoAluno = Aluno.GetLastId();

            var readLine = Console.ReadLine();
            var readKey = Console.ReadKey();
            var read = Console.Read();

            Console.WriteLine("O PLR do {0} é {1}", "GP", new Pelisam().GetValorDoPLR());
            Console.WriteLine("O PLR do {0} é {1}","Monstrao",new Paulo().GetValorDoPLR());

            Console.ReadKey();

            var data = new Data(19,12,2019);
            var dataCopia = data;

            data.dia = 30;

            var dataTime = new DateTime();
            var guid = new Guid();

            Console.WriteLine("Dia da dataCopia é {0}", dataCopia.dia);

            var dataClass = new DataClass(19, 11, 2019);
            var dataClassCopia = dataClass;

            dataClass.dia = 30;

            Console.WriteLine("Dia da classCopia é {0}", dataClassCopia.dia);


        }
    }
    public struct Data
    {

        public int dia;
        public int mes;
        public int ano;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
    }
    public class DataClass
    {
        public int dia;
        public int mes;
        public int ano;

        public DataClass(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
    }

    public static class Aluno
    {
        private static int _id = 30;
        public static int GetLastId() => _id++;
    }
    public abstract class PLR
    {
        public double GetValorDoPLR()
            => GetSalario() * 1.25;
        protected abstract double GetSalario();

    }
    public class Paulo : PLR
    {
        protected override double GetSalario()
            => 6000;
    }
    public class Pelisam : PLR
    {
        protected override double GetSalario()
            => 12000;
    }
}
