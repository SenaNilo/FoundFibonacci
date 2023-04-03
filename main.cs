using System;

class Program {
  public static void Main (string[] args) {
    //F de Fibonacci
    int F, Fanterior = 0, Finicial = 1, numeroAVerificar;
    
    Console.WriteLine("Informe um valor para verificar se ele pertence à sequência de Fibonacci: ");
    numeroAVerificar = int.Parse(Console.ReadLine());
    
    if(numeroAVerificar == 0){
      Console.WriteLine("{0} existe em Fibonacci!", numeroAVerificar);
    }else{
      do{
        F = Fanterior + Finicial;
        Fanterior = Finicial;
        Finicial = F;
      }while(numeroAVerificar>F);
      if(F == numeroAVerificar){
        Console.WriteLine("{0} existe em Fibonacci!", numeroAVerificar);
      }else{
        Console.WriteLine("Esse número ñ existe em Fibonacci!");
        Console.WriteLine("Números Mais Próximos: {0} e {1}", Fanterior, F);
      }
    }
  }
}