using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Production
{
    internal class Crate
    {
        // Attributes
        private bool isInGoodOrder;
        private DateTime productionDate;

        // Constructor
        public Crate(bool _isInGoodOrder, DateTime _productionDate)
        {
            this.isInGoodOrder = _isInGoodOrder;
            this.productionDate = _productionDate;
        }

        // Properties
        public bool IsInGoodOrder { get { return this.isInGoodOrder; } }
        public DateTime ProductionDate { get { return this.productionDate; } }
    }
}
