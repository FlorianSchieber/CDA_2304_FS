using CL_Production;

internal class Program
{
    public static string ToPercent(double _double)
    {
        return (_double * 100).ToString("0.00") + " %";
    }

    public static int ByHourToMsBy(int _byHour)
    {
        return (int)Math.Floor(3600 * 1000 / (double)_byHour);
    }

    public static void Run(Production _production)
    {
        if (_production.Start())
        {
            int waitingInMs = Program.ByHourToMsBy(_production.CRATE_PRODUCTION_BY_HOUR);

            while (_production.Status != ProductionStatus.Ended)
            {
                Thread.Sleep(waitingInMs);

                _production.ProductCrate();
                Console.WriteLine(
                    _production.Name + "\n" +
                    "Nombre de caisses " + _production.Type + " : " + _production.CrateCount() + " caisses." + "\n" +
                    "Taux d'erreur sur une heure : " + Program.ToPercent(_production.ErrorRateOfLastHour()) + "\n" +
                    "Taux d'erreur total : " + Program.ToPercent(_production.ErrorRateFromStart()) + "\n" +
                    "----------------------------------------------"
                );
            }
        }
    }

    public static void Run(object? _production)
    {
        if (_production is not null)
        {
            Program.Run((Production)_production);
        }
        
    }

    private static void Main(string[] args)
    {
        List<Production> productions = new List<Production>
        {
            new Production("Production A", "A", 10000, 1000, 0.01),
            new Production("Production B", "B", 25000, 5000, 0.02),
            new Production("Production C", "C", 120000, 10000, 0.05)
        };

        List<Thread> threads = new List<Thread> { };

        for (int i = 0; i < productions.Count; i++)
        {
            threads.Add(new Thread(new ParameterizedThreadStart(Program.Run)));
            threads[i].Start(productions[i]);

        }


        
    }
}