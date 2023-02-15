using SmalandsBackend.DataAccess;
using SmalandsBackend.Models;
//using SmalandsBackend.Interfaces;
//using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SmalandsBackend.Service.IService;
using SmalandsBackend.Models.DTOs;
using AutoMapper;
//using AutoMapper;

namespace SmalandsBackend.Services
{
    public class BoardService : IBoardService
    {
        private readonly SmalandsDbContext _context;
        private readonly IMapper _mapper;

        public BoardService(SmalandsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        /// <summary>
        /// Get all Board members
        /// </summary>
        /// <returns>A list of all members</returns>
        public async Task<IEnumerable<Board>> GetAllBoardMembers()
        {
            return await _context.Boards.ToListAsync();

        }
        //public async Task<ReadBoardDTO> UpdateBoardAsync(UpdateBoardDTO boardDTO)
        //{

        //    Board oldboard = await _context.Boards.SingleOrDefaultAsync(p => p.Id == boardDTO.Id);

        //    if (oldboard != null)
        //    {
        //        _mapper.Map(boardDTO, oldboard);
        //        _context.Boards.Update(oldboard);
        //    }

        //    if (_context.SaveChangesAsync().Result > 0)
        //        return _mapper.Map<ReadBoardDTO>(oldboard);
        //    else
        //        throw new Exception();
        //}
        public async Task<Board> GetBoardMemberById(int boardId)
        {
            var board = await _context.Boards.FirstOrDefaultAsync(g => g.Id == boardId);

           

            
            return board;
        }
        public async Task<ReadBoardDTO> CreateBoard(CreateBoardDTO boardDTO)
        {
            Board newBoard = _mapper.Map<Board>(boardDTO);

            await _context.Boards.AddAsync(newBoard);

            if (_context.SaveChanges() == 0)
                throw new Exception("Board not added to DB");

            return _mapper.Map<ReadBoardDTO>(newBoard);


        }
        //public async Task<Board> CreateBoard(Board newBoard)
        //{

        //    await _context.Boards.AddAsync(newBoard);

        //    if (_context.SaveChanges() == 0)
        //        throw new Exception("Hey Hey");

        //    return newBoard;

        //}




    }
}