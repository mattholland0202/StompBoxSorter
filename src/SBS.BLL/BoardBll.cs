using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SBS.BLL.Base;
using SBS.BLL.Interfaces;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class BoardBll : AbstractBLLBase, IBoardBll
    {
        public BoardBll(IBLL bll) : base(bll)
        {
        }

        public void Add(string name, 
                        string shortName, 
                        Manufacturer manufacturer, 
                        int width, 
                        int height, 
                        int? weight = null)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (String.IsNullOrWhiteSpace(shortName))
            {
                throw new ArgumentNullException(nameof(shortName));
            }

            if (manufacturer == null)
            {
                throw new ArgumentNullException(nameof(manufacturer));
            }

            Board board = new Board(name,
                                    shortName,
                                    manufacturer,
                                    width,
                                    height,
                                    weight);

            UnitOfWork.BoardRepository.Add(board);
        }

        public void Delete(Board board)
        {
            UnitOfWork.BoardRepository.Delete(board);
        }

        public Board Get(int id)
        {
            var board = UnitOfWork.BoardRepository.Get(id);
            return board;
        }

        public IEnumerable<Board> GetAll()
        {
            var boards = UnitOfWork.BoardRepository.GetAll();
            return boards;
        }

        public void Update(Board board)
        {
            UnitOfWork.SaveChanges();
        }

        public void Verify(Board board)
        {
            board.IsVerified = true;
        }
    }
}
