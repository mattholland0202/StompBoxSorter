using SBS.BLL.Interfaces;
using SBS.BLL.Interfaces.Base;
using SBS.DAL.Base;
using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Base
{
    public class BLL : IBLL
    {
        private IUnitOfWork unitOfWork;

        private IAccessoryBll accessories;
        private IBoardBll boards;
        private IPedalBll pedals;
        private IGetEntityBLLBase<PedalType> pedalTypes;
        private IGetEntityBLLBase<PedalTypeFamily> pedalTypeFamilies;

        public BLL()
        {
            unitOfWork = new UnitOfWork();

            Setup();
        }

        public BLL(IUnitOfWork testUnitOfWork)
        {
            unitOfWork = testUnitOfWork;

            Setup();
        }

        private void Setup()
        {
            accessories       = new AccessoryBll(this);
            boards            = new BoardBll(this);
            pedals            = new PedalBll(this);
            pedalTypes        = new PedalTypeBll(this);
            pedalTypeFamilies = new PedalTypeFamilyBll(this);
        }

        public IUnitOfWork UnitOfWork => unitOfWork;

        public IAccessoryBll Accessories => accessories;
        public IBoardBll Boards => boards;
        public IPedalBll Pedals => pedals;
        public IGetEntityBLLBase<PedalType> PedalTypes => pedalTypes;
        public IGetEntityBLLBase<PedalTypeFamily> PedalTypeFamilies => pedalTypeFamilies;
    }
}
