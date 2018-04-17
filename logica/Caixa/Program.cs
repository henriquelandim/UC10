using System;
using System.IO;

namespace Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
           string produto; 
           double preco;
           bool FormaDePagamento;
           double resultado;
           double precofinal;

                    Console.WriteLine("Especifique o produto:");
                    produto = Console.ReadLine();

                    Console.WriteLine("atribua o preco do produto");
                    preco = double.Parse(Console.ReadLine());

                    Console.WriteLine("O Pagamento será em dinheiro?");
                    FormaDePagamento = bool.Parse(Console.ReadLine());
 
                        if(FormaDePagamento == true){
                            resultado = preco * 10/100;
                            precofinal = preco-resultado;                     
                        }
                        else{
                            resultado = preco * 5/100;
                            precofinal = preco+resultado;                          
                        }

                        StreamWriter arquivo = new StreamWriter("dados.txt");
                        arquivo.WriteLine("Produto especificado: "+produto);
                        arquivo.WriteLine("Preço a vista do produto: "+preco);
                        arquivo.WriteLine("Valor de desconto ou acréscimo: "+resultado);
                        arquivo.WriteLine("Preço final do Produto: "+precofinal);
                        arquivo.Close();


                        Console.WriteLine("Produto especificado: "+produto);
                        Console.WriteLine("Preço a vista do produto: "+preco);
                        Console.WriteLine("Valor de desconto ou acréscimo: "+resultado);
                        Console.WriteLine("Preço final do Produto: "+precofinal);
        }
    }
}
