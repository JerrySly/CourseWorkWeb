using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using CourseWorkWeb.Models;
using CourseWorkWeb.Controllers;
using CourseWorkWeb.ViewModels;
using CustomIdentityApp.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
namespace CourseWorkWeb.Test2
{
    public class UserControllerTest
    {
        [Fact]
        public void EditUserTest()
        {
            var storeMock = new Mock<IUserStore<User>>();
            var optionMock = new Mock<IdentityOptions>();
            var mock = new Mock<UserManager<User>>(storeMock.Object,optionMock.Object);
            UsersController controller = new UsersController(mock.Object);

            Task<IActionResult> result = controller.Edit("999");

            Assert.True( new NotFoundResult().Equals(result));
        }
    }
}
