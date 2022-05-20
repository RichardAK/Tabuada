double contador, numero, produto;
int multiplicador;

Console.Write("Tabuada do número:");
numero = Convert.ToDouble(Console.ReadLine()); 

Console.Write("Digite até a multiplicação desejada:");
multiplicador = Convert.ToInt32(Console.ReadLine());

if( numero <0 || numero >10)
{   
    Console.WriteLine("Digite Numero de 0 a 10");
}

else
{   
    contador=0;

while(contador <= multiplicador)
{
    produto = contador * numero;
    Console.WriteLine($"{numero} x {contador} = {produto}");
    contador +=1;
}    

}