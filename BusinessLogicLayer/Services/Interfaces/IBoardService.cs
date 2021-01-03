using BusinessLogicLayer.Models;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IBoardService
    {
        public List<string> getDates();
        public List<BoardModel> getBoard();
    }
}
