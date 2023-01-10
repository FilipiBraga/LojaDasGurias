using LojaDasGurias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDasGurias.Tests.Entities
{
    [Collection("Mapper")]
    public class ClientesTests
    {
        [Fact]
        public void CriarCliente_Sucesso_Test()
        {
            var cliente = new Cliente("João", DateTime.Now);

            Assert.True(cliente.IsValid);
        }

        [Fact]
        public void CriarCliente_NomeVazio_Test()
        {
            var cliente = new Cliente(string.Empty, DateTime.Now);

            Assert.False(cliente.IsValid);
        }

        [Fact]
        public void CriarCliente_DataMinima_Test()
        {
            var cliente = new Cliente("João", DateTime.MinValue);

            Assert.False(cliente.IsValid);
        }
    }
}
