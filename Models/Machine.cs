using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sun_House.Models
{
    public class Machine
    {
        public int machineId { get; set; }
        public string desMachine { get; set; }
        public double electrCapacity { get; set; }
        public double maxWat { get; set; }
        public double dailyHoursWork { get; set; }
        //public byte[] iconMachine { get; set; }
        public double dailyConsumation { get; set; }
        public double totalMachineCapacity { get; set; }
        public double totalPeakWatt { get; set; }
        public double countEquipped { get; set; }
        public string displayText { get; set; }
    }
}
