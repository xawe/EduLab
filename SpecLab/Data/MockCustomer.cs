using System;
using System.Collections.Generic;
using System.Text;

namespace SpecLab.Data
{
    public class MockCustomer
    {
        public static List<Model.Customer> getMockCustomer()
        {
            var r = new List<Model.Customer>();
            r.Add(new Model.Customer { Id = 1, FirstName = "Huguinho", SecondName = "Patinhas", Active = true });
            r.Add(new Model.Customer { Id = 1, FirstName = "Luisinho", SecondName = "Patinhas", Active = true });
            r.Add(new Model.Customer { Id = 1, FirstName = "Zezinho", SecondName = "Patinhas", Active = true });
            r.Add(new Model.Customer { Id = 1, FirstName = "Pato", SecondName = "Donald", Active = true });
            r.Add(new Model.Customer { Id = 1, FirstName = "Tio", SecondName = "Patinhas", Active = true });
            r.Add(new Model.Customer { Id = 1, FirstName = "Mickey", SecondName = "Mouse", Active = true });
            return r;
        }
    }
}
