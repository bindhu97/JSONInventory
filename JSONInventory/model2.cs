using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONInventory
{
    internal class model2
    {
        public object typeOfRice { get; internal set; }
        public object typeOfPulses { get; internal set; }
        public object typeOfWheat { get; internal set; }

        public class ModelTwo
        {
            public List<ModelTwo> typeOfRice;
            public List<ModelTwo> typeOfPulses;
            public List<ModelTwo> typeOfWheat;

        }

        public class TypeOfRice
        {
            public static int Count { get; internal set; }
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }

        }
        public class TypeOfPulses
        {
            public static int Count { get; internal set; }
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }

        }
        public class TypeOfWheat
        {
            public static int Count { get; internal set; }
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }

        }
    }
}
