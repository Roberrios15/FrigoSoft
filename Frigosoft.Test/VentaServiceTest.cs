using BLL;
using DAL;
using Entity;
using FluentAssertions;
using NSubstitute;
using Xunit.Abstractions;

namespace Frigosoft.Test;

public class VentaServiceTest
{
    private readonly ITestOutputHelper testOutputHelper;
    private readonly IConnectionManager connectionManager = Substitute.For<IConnectionManager>();
    private readonly IVentaRepository ventaRepository = Substitute.For<IVentaRepository>();
    
    private VentaService ventaService;
    
    public VentaServiceTest(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
        
        ventaService = new VentaService(ventaRepository, connectionManager);
    }

    [Fact]
    public void WhenGuardarVenta_ShoulReturnMessage()
    {
        // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });
        
        // Act
        var result = ventaService.GuardarVenta(new Venta());
        
        // Assert
        result.Should().NotBeNull();
    }

    [Fact]
    public void WhenConsultar_ShoulReturnList()
    {
            // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });
        
        ventaRepository.Consultar().Returns(new List<Venta>());
        
        // Act
        var result = ventaService.Consultar();
        
        // Assert
        result.Should().NotBeNull();
    }
}