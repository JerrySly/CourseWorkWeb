using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CourseWorkWeb.Models;
using CustomIdentityApp.Controllers;

namespace CourseWorkWeb.Test2
{
    public class RolesControllerTest
    {
        [Fact]
        public async Task CreateTestRole()
        {
            var userMoq = GetMockUserManager();
            var roleMoq = GetMockURoleManager();

            RolesController controller = new RolesController(roleMoq.Object, userMoq.Object);

            var result = await controller.Create(null);

            Assert.IsType<ViewResult>(result);

        }
        private Mock<UserManager<User>> GetMockUserManager()
        {
            var userStoreMock = new Mock<IUserStore<User>>();
            return new Mock<UserManager<User>>(
                userStoreMock.Object, null, null, null, null, null, null, null, null);
        }
        private Mock<RoleManager<IdentityRole>> GetMockURoleManager()
        {
            
            var roleStore = new Mock<IRoleStore<IdentityRole>>();
            return new Mock<RoleManager<IdentityRole>>(roleStore.Object, null, null, null, null);
        }

    }
}
