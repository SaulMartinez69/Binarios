try
{
    FileStream archivo = new FileStream("Archivo.bin", FileMode.Open);
    BinaryReader lector = new BinaryReader(archivo);
    Console.WriteLine(lector);
    archivo.Close();
}
catch (FileNotFoundException e)
{
    Console.WriteLine("El archivo no se encontró.");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Ha ocurrido un error inesperado.");
    Console.WriteLine(e.Message);
}