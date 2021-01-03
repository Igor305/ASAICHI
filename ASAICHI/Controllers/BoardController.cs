using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASAICHI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        IBoardService _boardService;
        public BoardController (IBoardService boardService)
        {
            _boardService = boardService;   
        }

        // GET: /board
        [HttpGet]
        public List<BoardModel> createBoard()
        {
            List<BoardModel> boardModels = _boardService.getBoard();
            return boardModels;    
        }
    }
}
