using System;
using System.Collections.Generic;
using SBS.BLL.Base;
using SBS.BLL.Interfaces;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class AccessoryBll : AbstractBLLBase, IAccessoryBll
    {
        public AccessoryBll(IBLL bll) : base(bll)
        {
        }

        public void Add(string name,
                        int width,
                        int depth,
                        int height,
                        int? weight = null)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Accessory accesory = new Accessory(name,
                                               width,
                                               height,
                                               depth,
                                               weight);

            UnitOfWork.AccessoryRepository.Add(accesory);
        }

        public void Delete(Accessory accessory)
        {
            UnitOfWork.AccessoryRepository.Delete(accessory);
        }

        public Accessory Get(int id)
        {
            var accessory = UnitOfWork.AccessoryRepository.Get(id);
            return accessory;
        }

        public IEnumerable<Accessory> GetAll()
        {
            var accessories = UnitOfWork.AccessoryRepository.GetAll();
            return accessories;
        }

        public void Update(Accessory accessory)
        {
            UnitOfWork.SaveChanges();
        }

        public void Verify(Accessory accessory)
        {
            accessory.IsVerified = true;
        }
    }
}
