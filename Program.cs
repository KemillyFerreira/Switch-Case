using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir a operação
            // Pedir o 1° número
            // Pedir o 2° número

            Console.WriteLine("Digite a operação que deseja fazer /n Soma, Subtracao, Multiplicacao, Divisao");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1° número");
            float num1 = float.Parse(Console.ReadLine());

                //ALT + SHIFT + SETA PARA BAIXO

            Console.WriteLine("Digite o 2° número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            //     //IF / ELSE PADRÂO
            // if(operacao == "Soma"){
            //     resultado = num1 + num2;
            // }else if(operacao == "Subtracao"){
            //     resultado = num1 - num2;
            // }else if(operacao == "Multiplicacao"){
            //     resultado = num1 * num2;
            // }else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }else{
            //     Console.WriteLine("Operação Inválida");
            // }
            // Console.WriteLine($"Resultado  : {resultado}");

            switch(operacao){

                case "Soma":
                    resultado = num1+num2;
                    break;
                
                case "Subtracao":
                    resultado = num1+num2;
                    break;

                case "Multiplicacao":
                    resultado = num1*num2;
                    break;

                case "Divisao":
                    resultado = num1/num2;
                    break;
                
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }



// Concatenação
//Console.WriteLine("Calculo : "+num1+" e "+num2+" = Resultado" ; +resultado);

// Interpolação
Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");

        }
    }
}

