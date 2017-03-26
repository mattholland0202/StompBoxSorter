using System.Linq;
using SBS.DAL.Base;
using SBS.DAL.Interfaces.Base;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUnitOfWork uow = new UnitOfWork();
            var all = uow.PedalTypeRepository.GetAll().ToList();
        }
    }
}
