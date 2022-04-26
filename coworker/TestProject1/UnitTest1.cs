using Xunit;
using coworker.Models;
using coworker.Services;
using System.Linq;

namespace TestProject1
{
    public class UnitTest1
    {
        private coworkerContext context;
        private CoworkerService service;
        public UnitTest1()
        {
            this.context = new coworkerContext();
            this.service = new CoworkerService(context);
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(2, service.GetAllWorker());
        }
        [Fact]
        public void Test2()
        {
            Coworker result = service.GetStudentByEmail("jani@jani.hu");
            Assert.Equal("Jani",result.Name);
            Assert.Equal(1, result.Notebooks.Count);
        }
        [Fact]
        public void Test3()
        {
            Coworker result = service.GetStudentByEmail("jani@jani.hu");
            Phone phone = result.Phones.Where(a => a.Brand == "Samsung").FirstOrDefault();
            Assert.Equal(3, result.Phones.Count);
            Assert.NotNull(phone);
        }
    }
}
