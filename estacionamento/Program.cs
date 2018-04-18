//objetivo; desenvolver um sistema de cobrança de estacionamento, com base que apartir do momento
//que o veiculo entrou, já estara sendo cobrado um valor padrao + adicional a cada hora que ficar
//
// problemas que estou tendo; NÃO SEI DESENVOLVER A COMUNICAÇÃO COM O USUARIO
// O FLUXO SERÁ:
// ESPECIFICAR O VEICULO
//        \/
// HORAS ESTACIONADO
//        \/
// VALOR A SER PAGO

// AUTHOR; HENRIQUE LANDIM 17/04/18


using System; 

namespace estacionamento
{
    class   Program
    {
        static void Main(string[] args)        
    
        {
            double carro;
            double onibus;
            double caminhao;
            double AHC; //adicional hora carro
            double AHO; // adicional hora onibus
            double AHT; // adicional hora caminhao
            double c1h, c2h, c3h, c4h, c5h, c6h, c7h, c8h, c9h, c10h, c11h, c12h; //tabela preço carro
            double o1h, o2h, o3h, o4h, o5h, o6h, o7h, o8h, o9h, o10h, o11h, o12h; //tbla preço onibus
            double t1h, t2h, t3h, t4h, t5h, t6h, t7h, t8h, t9h, t10h, t11h, t12h; //tbla preço caminhao
            
            
                carro=20.00;
                onibus=30.00;
                caminhao=37.00;
                AHC=4.50;
                AHO=6.00;
                AHT=7.00;
        
                    c1h = carro+AHC;
                    c2h = carro+AHC*2; 
                    c3h = carro+AHC*3;
                    c4h = carro+AHC*4;
                    c5h = carro+AHC*5;
                    c6h = carro+AHC*6;
                    c7h = carro+AHC*7;
                    c8h = carro+AHC*8;
                    c9h = carro+AHC*9;
                    c10h = carro+AHC*10;
                    c11h = carro+AHC*11;
                    c12h = carro+AHC*12;


                    o1h = onibus + AHO;
                    o2h = onibus + AHO*2;
                    o3h = onibus + AHO*3;
                    o4h = onibus + AHO*4;
                    o5h = onibus + AHO*5;
                    o6h = onibus + AHO*6;
                    o7h = onibus + AHO*7;
                    o8h = onibus + AHO*8;
                    o9h = onibus + AHO*9;
                    o10h = onibus + AHO*10;
                    o11h = onibus + AHO*11;
                    o12h = onibus + AHO*12;


                    t1h = caminhao+AHT;
                    t2h = caminhao+AHT*2;
                    t3h = caminhao+AHT*3;
                    t4h = caminhao+AHT*4;
                    t5h = caminhao+AHT*5;
                    t6h = caminhao+AHT*6;
                    t7h = caminhao+AHT*7;
                    t8h = caminhao+AHT*8;
                    t9h= caminhao+AHT*9;
                    t10h = caminhao+AHT*10;
                    t11h = caminhao+AHT*11;
                    t12h = caminhao+AHT*12;

                        Console.WriteLine(c1h);
                        Console.WriteLine(c2h);
                        Console.WriteLine(o11h);
                        Console.WriteLine(o8h);
                        Console.WriteLine(t5h);
                        Console.WriteLine(t7h);
        }
    }
}
