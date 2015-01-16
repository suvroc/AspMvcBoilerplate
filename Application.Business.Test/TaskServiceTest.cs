using Application.Business.Mappings;
using Application.Business.Tasks;
using Core.Domain.Infrastructure;
using Core.Domain.Models;
using Moq;
using NUnit.Framework;
using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Business.Test
{
    [TestFixture]
    public class TaskServiceTest
    {
        [Test]
        public void GetTaskTest()
        {
            // Arrange
            DtoMappings.Map();

            Fixture fixture = new Fixture();
            fixture.Inject(Enumerable.Empty<Task>());

            var task = fixture.Create<Task>();
            var category = fixture.Create<Category>();

            var taskRepositoryMock = new Mock<IRepository<Task>>();
            taskRepositoryMock.Setup(x => x.GetById(task.Id))
                .Returns(task);
            var categoryRepositoryMock = new Mock<IRepository<Category>>();
            categoryRepositoryMock.Setup(x => x.GetAll())
                .Returns(new []{ category }.AsQueryable());
            ITaskService taskService = 
                new TaskService(taskRepositoryMock.Object,
                    categoryRepositoryMock.Object);

            // Act
            var resultTask = taskService.GetTask(task.Id);
            
            // Assert
            Assert.AreEqual(task.Name, resultTask.Name);
            Assert.AreEqual(task.Description, resultTask.Description);
        }
    }
}
