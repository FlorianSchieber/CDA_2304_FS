using CL_Robot;
internal class Program
{
    private static void Main(string[] args)
    {
        Robot robi = new Robot();

        Telecommande telecom = new Telecommande(robi);

        telecom.BoutonAllumer();
        Console.WriteLine(robi.ToString());

        telecom.BoutonAvancer(1);
        Console.WriteLine(robi.ToString());

        telecom.BoutonTourner(Math.PI / 2);
        Console.WriteLine(robi.ToString());

        telecom.BoutonAvancer(1);
        Console.WriteLine(robi.ToString());
    }
}