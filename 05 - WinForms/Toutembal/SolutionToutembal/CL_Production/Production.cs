using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Production
{
    public class Production
    {
        // Class operations

        public static int ByHourToMsBy(int _byHour)
        {
            return (int)Math.Floor(3600 * 1000 / (double)_byHour);
        }

        // Instance Constants
        public readonly int MAX_CRATE_NUMBER;
        public readonly int CRATE_PRODUCTION_BY_HOUR;
        public readonly double ERROR_RATE;

        // Attributes
        private string name;
        private string type;
        private ProductionStatus status;
        private List<Crate> productedCrates;
        private Thread thread;

        // Constructor
        public Production( string _name, string _type, int _maxCrateNumber, int _crateProductionByHour, double _errorRate)
        {
            this.MAX_CRATE_NUMBER = _maxCrateNumber;
            this.CRATE_PRODUCTION_BY_HOUR = _crateProductionByHour;
            this.ERROR_RATE = _errorRate;

            this.name = _name;
            this.type = _type;
            this.status = ProductionStatus.WaitingStart;
            this.productedCrates = new List<Crate> { };

            this.thread = new Thread(new ThreadStart(this.Run));
            this.thread.Start();
        }

        // Properties
        public string Name { get { return this.name; } }
        public string Type { get { return this.type; } }
        public ProductionStatus Status { get { return this.status; } }

        // Computed Values
        public int CrateCount()
        {
            return this.productedCrates.Count;
        }

        public double ErrorRateFromStart()
        {
            int errorCount = 0;

            lock (this.productedCrates)
            {
                foreach (Crate crate in this.productedCrates)
                {
                    if (!crate.IsInGoodOrder)
                    {
                        errorCount++;
                    }
                }

                if (this.CrateCount() != 0)
                {
                    return (double)errorCount / this.CrateCount();
                }

                return 0;
            } 
        }

        public double ErrorRateOfLastHour()
        {
            int errorCount = 0;
            int lastHourCount = 0;
            DateTime lastHour = DateTime.Now.AddMinutes(-30);

            lock (this.productedCrates)
            {
                foreach (Crate crate in this.productedCrates)
                {
                    if (crate.ProductionDate >= lastHour)
                    {
                        lastHourCount++;

                        if (!crate.IsInGoodOrder)
                        {
                            errorCount++;
                        }
                    }
                }

                if (lastHourCount != 0)
                {
                    return (double)errorCount / lastHourCount;
                }

                return 0;
            }
        }

        // Tests
        public bool TargetIsAchieved()
        {
            return this.CrateCount() >= this.MAX_CRATE_NUMBER;
        }

        // Operations
        public bool Start()
        {
            if (this.status == ProductionStatus.WaitingStart || this.status == ProductionStatus.Paused)
            {
                this.status = ProductionStatus.Started;

                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (this.status == ProductionStatus.Started)
            {
                this.status = ProductionStatus.Paused;
                
                return true;
            }

            return false;
        }
        
        public bool ProductCrate()
        {
            Random random = new Random();
            double randomDouble = random.NextDouble();

            lock (this.productedCrates)
            {
                if (this.status == ProductionStatus.Started)
                {
                    this.productedCrates.Add(new Crate(randomDouble >= this.ERROR_RATE, DateTime.Now));

                    if (this.TargetIsAchieved())
                    {
                        this.status = ProductionStatus.Ended;
                    }

                    return true;
                }

                return false;
            }
        }

        public void Run()
        {
            int waitingInMs = Production.ByHourToMsBy(this.CRATE_PRODUCTION_BY_HOUR);

            while (this.status != ProductionStatus.Ended)
            {
                if (this.status == ProductionStatus.Started)
                {
                    Thread.Sleep(waitingInMs);

                    this.ProductCrate();
                }
            }
        }
    }
}
