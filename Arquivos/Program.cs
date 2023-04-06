internal class Program
{
    private static void Main(string[] args)
    {
        string caminhoorigem = @"C:\Users\Felipe\Desktop\PROJETOS\file1.txt";

        string caminhodestino = @"C:\Users\Felipe\Desktop\PROJETOS\file2.txt";

        try
        {
              FileInfo fileinfo = new FileInfo(caminhoorigem);

           // fileinfo.CopyTo(caminhodestino);

            string[] linhas = File.ReadAllLines(caminhoorigem);
     
            foreach(string linha in linhas)
            {
                Console.WriteLine(linha);    
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("ocorreu um erro");
            Console.WriteLine(e.Message);
        }
    }
}