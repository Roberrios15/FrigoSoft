using BLL;
using DAL;
using Entity;
using FluentAssertions;
using NSubstitute;
using Xunit.Abstractions;

namespace Frigosoft.Test;

public class ProductoServiceTest
{
    private readonly ITestOutputHelper testOutputHelper;
    private readonly IConnectionManager connectionManager = Substitute.For<IConnectionManager>();
    private readonly IProductoRepository productoRepository = Substitute.For<IProductoRepository>();

    private ProductoService service;
    
    public ProductoServiceTest(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
        
        service = new ProductoService(productoRepository, connectionManager);
    }

    [Fact]
    public void WhenGuardarProducto_ShouldReturnMessage()
    {
        // Arrange        //Espacio donde se trabaja
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });
        
        // Act            // Se llama al servicio 
        var result = service.GuardarProducto(new Producto());
        
        // Assert         // Comprobar que que el resultado es el esperado
        result.Should().NotBeEmpty();
    }

    [Fact]
    public void WhenBuscarProducto_ShouldReturnProduct()
    {
            // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });
        
        productoRepository.BuscarProducto(Arg.Any<string>()).Returns(new Producto());
        
        // Act
        var result = service.BuscarProducto("1");
        
        // Assert
        result.Should().NotBeNull();
    }
}