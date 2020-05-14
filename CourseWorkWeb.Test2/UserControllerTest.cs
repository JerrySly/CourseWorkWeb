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

using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Xunit.Sdk;
using Microsoft.AspNetCore.Http;

namespace CourseWorkWeb.Test2
{
    public class UserControllerTest
    {
        [Fact]
        public async Task EditUserTest()
        {
            var moq = GetMockUserManager();
            UsersController controller = new UsersController(moq.Object);

           var result =await controller.Edit("-100");

           Assert.IsType<NotFoundResult>(result);      
        }
        private Mock<UserManager<User>> GetMockUserManager()
        {
            var userStoreMock = new Mock<IUserStore<User>>();
            return new Mock<UserManager<User>>(
                userStoreMock.Object, null, null, null, null, null, null, null, null);
        }
      
    }
}
