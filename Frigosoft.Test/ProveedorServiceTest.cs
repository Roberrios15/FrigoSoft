using BLL;
using DAL;
using Entity;
using FluentAssertions;
using NSubstitute;
using Xunit.Abstractions;
namespace Frigosoft.Test;


public class ProveedorServiceTest
{
    private readonly ITestOutputHelper testOutputHelper;
    private readonly IConnectionManager connectionManager = Substitute.For<IConnectionManager>();
    private readonly IProveedorRepository proveedorRepository = Substitute.For<IProveedorRepository>();
    
    private ProveedorService proveedorService;
    
    public ProveedorServiceTest(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
        
        proveedorService = new ProveedorService(proveedorRepository, connectionManager);
    }

    [Fact]
    public void WhenGuardarProveedor_ShouldReturnMessage()
    {
        // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });
        
        // Act
        var result = proveedorService.GuardarProveedor(new Proveedor());
        
        // Assert
        result.Should().NotBeEmpty();
    }
    
    [Fact]
    public void WhenConsultar_ShoulReturnList()
    {
        // Arrange
        connectionManager.When(x => x.Open()).Do(x => { testOutputHelper.WriteLine("Open"); });
        connectionManager.When(x => x.Close()).Do(x => { testOutputHelper.WriteLine("Open"); });

        proveedorRepository.Consultar().Returns(new List<Proveedor>());
        
        // Act
        var result = proveedorService.Consultar();
        
        // Assert
        result.Should().NotBeNull();
    }
}