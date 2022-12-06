using BLL;
using DAL;
using Entity;
using FluentAssertions;
using NSubstitute;
using Xunit.Abstractions;

namespace Frigosoft.Test;

public class CompraServiceTest
{
    private readonly ITestOutputHelper testOutputHelper;
    private ICompraRepository compraRepository = Substitute.For<ICompraRepository>();
    private readonly IConnectionManager connectionManager = Substitute.For<IConnectionManager>();

    private CompraService service;

    public CompraServiceTest(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
        service = new CompraService(compraRepository, connectionManager);
    }

    [Fact]
    public void WhenGuardarCompra_ShouldReturnMessage()
    {
        // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });

        // Act
        var compra = new Compra
        {
            NombreProveedor = "Manolo"
        };
        var response = service.GuardarCompra(compra);

        // Assert
        response.Should().NotBeEmpty();
    }

    [Fact]
    public void WhenConsultar_ShouldReturnList()
    {
        // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });
        compraRepository.Consultar().Returns(new List<Compra>());
        
        // Act
        var response = service.Consultar();
        
        // Assert
        response.Should().NotBeNull();
    }
}