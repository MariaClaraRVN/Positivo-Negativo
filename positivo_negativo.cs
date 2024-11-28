using System;

class Program {
  public static void Main (string[] args) {
    int ct;
    int somaPositivo = 0;
    int somaNegativo = 0;
    int valor = 0;
    const int quantValor = 10;
    

    for (ct = 1; ct<= quantValor; ct++)
    {
      Console.WriteLine("Informe o " + ct + "º valor: ");
      valor = int.Parse(Console.ReadLine());
      
      if (valor >= 0)
      {
        somaPositivo += valor;
      }
      else
      {
         somaNegativo ++ ;   
      }
    }

    Console.WriteLine("");
    Console.WriteLine("Somatoria dos valores positivos: " +somaPositivo);
    Console.WriteLine("Somatoria dos valores negativos: " +somaNegativo);
    
  }
}