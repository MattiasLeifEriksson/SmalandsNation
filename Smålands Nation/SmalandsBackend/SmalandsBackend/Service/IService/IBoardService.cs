using SmalandsBackend.Models;
using SmalandsBackend.Models.DTOs;

namespace SmalandsBackend.Service.IService
{
    public interface IBoardService
    {
        public Task<IEnumerable<Board>> GetAllBoardMembers();

       // public Task<ReadBoardDTO> UpdateBoardAsync(UpdateBoardDTO boardDTO);

        public Task<Board> GetBoardMemberById(int boardId);
         public Task<ReadBoardDTO> CreateBoard(CreateBoardDTO boardDTO);
       // public Task<Board> CreateBoard(Board newBoard);
    }
}
