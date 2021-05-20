using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Data
{    
    public class CustomerDataTest
    {
        public CustomerDataTest()
        {
            _data = new SpecLab.Data.CustomerData();
        }
        SpecLab.Data.CustomerData _data;
        
        /// <summary>
        /// Teste de sucesso da obtenção de dados do cliente
        /// </summary>
        [Fact]        
        public void GetActiveUsersOkTest()
        {
            var r = _data.GetActiveCustomer();
            Assert.NotNull(r);
            Assert.True(r.Count > 0);

        }

        /// <summary>
        /// Teste de sucesso de busca de clientes inativos
        /// </summary>
        [Fact]
        public void GetInActiveUsersOkTest()
        {
            var r = _data.GetInactiveCustomer() ;
            Assert.NotNull(r);
            Assert.False(r.Count > 0);
        }

    }
}
