using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpecLab.Data
{
    /// <summary>
    /// Simula algumas operações simples de obtenção de dados de usuário.
    /// </summary>
    public class CustomerData
    {
        private List<Model.Customer> _customerList;
        public CustomerData()
        {
            _customerList = MockCustomer.getMockCustomer();
        }
        public List<Model.Customer> GetActiveCustomer()
        {
            return _customerList.Where(x => x.Active.Equals(true)).ToList();
        }

        public List<Model.Customer> GetInactiveCustomer()
        {
            return _customerList.Where(x => x.Active.Equals(false)).ToList();
        }

        public Model.Customer GetCustomerByName(string firsName)
        {
            return _customerList.FirstOrDefault(x => x.FirstName.Equals(firsName));
        }
    }
}
