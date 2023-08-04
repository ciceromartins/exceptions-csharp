try
{
  var numero1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("EXECUTADO!");
}
catch (FormatException ex)
{
  Console.WriteLine("Erro de conversão!");
}
finally
{
  Console.WriteLine("EXECUTO SEMPRE!");
}