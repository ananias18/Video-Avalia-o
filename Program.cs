using Aula15.Assistir;

public class Program
{
    public static void Main(string[] args)
    {
        Video[] v = new Video[3];
        v[0] = new Video("Aula 1 de POO");
        v[1] = new Video("Aula 12 de PHP");
        v[2] = new Video("Aula 10 de C#");

        Gafanhoto[] g = new Gafanhoto[2];
        g[0] = new Gafanhoto("João", 20, "Maisculino", "Juba");
        g[1] = new Gafanhoto("Maria", 25, "Feminino", "Creuzita");

        Visualizacao[] vis = new Visualizacao[5];
        vis[0] = new Visualizacao(g[0], v[2]);
        Console.WriteLine(vis[0].ToString());
        vis[0].avaliar();


        vis[1] = new Visualizacao(g[0], v[1]);
        Console.WriteLine(vis[0].ToString());
        vis[1].avaliar(85f);

        Console.WriteLine("Videos\n------------------------------");
        Console.WriteLine(v[0].ToString());
        Console.WriteLine(v[1].ToString());
        Console.WriteLine(v[2].ToString());
        Console.WriteLine("\nGafanhoto\n--------------------------");
        Console.WriteLine(g[0].ToString());
        Console.WriteLine(g[1].ToString());
    }
}
