using System;
using System.Collections.Generic;
using System.Text;

namespace SpecLab.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public bool Active { get; set; }
    }
}
