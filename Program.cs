using System;
using System.Globalization;
using task06;

namespace Task06{
    class Program{
        static void Main(String[] args){
            Aluno a = new Aluno();
            
            System.Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Nota final: "+a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if(a.Aprovado()){
                System.Console.WriteLine("Aprovado!");
            }
            else{
                System.Console.WriteLine("Reprovado! Faltaram "+a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)+" pontos.");
            }
        }
    }
}