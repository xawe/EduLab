using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Data
{    
    /// <summary>
    /// Responsável por validar as funcionaldades da classe CustomerData
    /// A ideia é que cada nova funcionalidade seja testada e futuras atualizaçoes precisam garantir que os testes continuam passando.   
    /// </summary>
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

        /// <summary>
        /// Busca customer by name ok 
        /// </summary>
        [Fact]
        public void GetUserByNameTestOK()
        {
            string name = "Huguinho";
            string lastName = "Patinhas";
            var r = _data.GetCustomerByName(name);

            Assert.NotNull(r);
            Assert.Equal(lastName, r.SecondName);
            Assert.Equal(1, r.Id);
        }


        /// <summary>
        /// Busca Customer by name - not found
        /// </summary>
        [Fact]
        public void GetUserByNameTestNotFound()
        {
            string name = "Pluto";
            string lastName = "";
            var r = _data.GetCustomerByName(name);

            Assert.Null(r);
            
        }
    }
}
