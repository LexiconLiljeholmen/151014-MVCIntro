using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStorage.Models {
    public class Item {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}