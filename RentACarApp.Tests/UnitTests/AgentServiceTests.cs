using NUnit.Framework;
using RentACarApp.Contracts;
using RentACarApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp.Tests.UnitTests
{
    //Arrange
    //Act
    //Assert 
    [TestFixture]
    public class AgentServiceTests : TestsBase
    {
        private IAgentService agentService;

        [OneTimeSetUp]
        public void SetUp()
            => agentService = new AgentService(context);


        [Test]
        public void GetAgentId_ShouldReturnCorrectId()
        {
            var resultAgentId = agentService.GetAgentId(Agent.UserId);
                
            Assert.AreEqual(Agent.Id, resultAgentId);
        }

        [Test]
        public void ExistById_ShouldReturnTrueWithValidId()
        {
            var result = agentService.ExistsById(Agent.UserId);

            Assert.IsTrue(result);
        }

        [Test]
        public void AgentWithPhoneNumberExists_ShouldReturnTrue()
        {
            var result = agentService.AgentWithPhoneNumberExists(Agent.PhoneNumber);

            Assert.IsTrue(result);
        }

        [Test]
        public void Create_ShouldCreateAgent()
        {
            //Arrange
            var agentsCountBefore = context.Agents.Count();

            //Act
            agentService.Create(Agent.UserId, Agent.PhoneNumber, Agent.FirstName, Agent.LastName);   

            //Assert
            var agentsCountAfter = context.Agents.Count();
            Assert.AreEqual(agentsCountBefore + 1, agentsCountAfter);

            var newAgentId = agentService.GetAgentId(Agent.UserId);
            var newAgentIdDb = context.Agents.Find(newAgentId);
            Assert.IsNotNull(newAgentIdDb);
            Assert.AreEqual(Agent.UserId, newAgentIdDb.UserId);
            Assert.AreEqual(Agent.PhoneNumber, newAgentIdDb.PhoneNumber);
        }

    }
}
