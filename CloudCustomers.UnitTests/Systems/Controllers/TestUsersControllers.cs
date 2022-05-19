using CloudCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace CloudCustomers.UnitTests;

public class TestUsersControllers
{
    [Fact (DisplayName = "GetUsers")]
    [Trait("OnSucess", "ReturnsStatusCode200")]
    public async Task Get_OnSucess_ReturnsStatusCode200()
    {
        //Arrange
        var sut = new UsersController();
        //Act
        var result = (OkObjectResult)await sut.Get();
        //Assert
        result.StatusCode.Should().Be(200);
    }
    
    [Fact (DisplayName = "GetUsers")]
    [Trait("OnSucess", "InvokeUsersService")]
    public async Task Get_OnSucess_InvokeUsersService()
    {
        //Arrange
        var mockUserService = new Mock<IUsersService>();

        var sut = new UsersController(mockUserService.Object);
        //Act
        var result = (OkObjectResult)await sut.Get();
        //Assert
        result.StatusCode.Should().Be(200);
    }
}