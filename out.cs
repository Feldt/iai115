  /* OUT
  out es básicamente una forma de retornar un valor sin escribir 'return'
  también se puede usar en métodos que retornen un valor,
  lo cual es de bastante utilidad, ya que se pueden controlar dos cosas con un sólo método
  */

//ejemplo muy básico para comprención del out
class EjemploDeOut
{
    public static void LeerInt(String mensaje, out int numero)
    {
      Console.WriteLine(mensaje);
      numero = int.Parse(Console.ReadLine());
    }
    
    static void Main()
    {
      int edad;
      LeerInt("Ingrese su edad", out edad);
      Console.WriteLine("Su edad es: " + edad);
    }
}
