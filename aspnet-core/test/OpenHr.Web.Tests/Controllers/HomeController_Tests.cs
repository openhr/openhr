using System.Threading.Tasks;
using OpenHr.Models.TokenAuth;
using OpenHr.Web.Controllers;
using Shouldly;
using Xunit;

namespace OpenHr.Web.Tests.Controllers
{
    public class HomeController_Tests: OpenHrWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}