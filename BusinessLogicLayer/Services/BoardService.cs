using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.Services
{
    public class BoardService : IBoardService
    {
        public List<string> getDates()
        {
            List<string> dates = new List<string>();
            dates.Add(DateTime.Today.AddDays(-6).Day + "." + DateTime.Today.AddDays(-6).Month);
            dates.Add(DateTime.Today.AddDays(-5).Day + "." + DateTime.Today.AddDays(-5).Month);
            dates.Add(DateTime.Today.AddDays(-4).Day + "." + DateTime.Today.AddDays(-4).Month);
            dates.Add(DateTime.Today.AddDays(-3).Day + "." + DateTime.Today.AddDays(-3).Month);
            dates.Add(DateTime.Today.AddDays(-2).Day + "." + DateTime.Today.AddDays(-2).Month);
            dates.Add(DateTime.Today.AddDays(-1).Day + "." + DateTime.Today.AddDays(-1).Month);
            dates.Add(DateTime.Today.Day + "." + DateTime.Today.Month);

            return dates; 
        }
        public List<BoardModel> getBoard()
        {

            List<string> dates = getDates();
                  
            List<BoardModel> boardModels = new List<BoardModel>();

            boardModels.Add(new BoardModel() 
            { 
                Num = 2,
                Indicator = "Відміни (%)",
                Target = 1.3, 
                Day7 = 1.09,
                Day6 = 0.92,
                Day5 = 1.23,
                Day4 = 1.03,
                Day3 = 1.11,
                Day2 = 1.08,
                Today = 0,
                TargetForTheWeek = 1.3,
                Result = 1.17 
            });
            boardModels.Add(new BoardModel()
            {
                Num = 3,
                Indicator = "Повернення (%)",
                Target = 0.7,
                Day7 = 0.93,
                Day6 = 0.55,
                Day5 = 0.70,
                Day4 = 1.01,
                Day3 = 0.36,
                Day2 = 0.68,
                Today = 0,
                TargetForTheWeek = 0.7,
                Result = 0.62
            });
            boardModels.Add(new BoardModel()
            {
                Num = 4,
                Indicator = "Заповнення табеля*",
                Target = 0,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 5,
                Indicator = "Касири (не підв'язані)*",
                Target = 0,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 6,
                Indicator = "Не прийняті накладні*",
                Target = 0,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 9,
                Indicator = "Скарги*",
                Target = 0,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 12,
                Indicator = "Магазини що відкрились з запізненням",
                Target = 0,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 13,
                Indicator = "Магазини які закрились раніше",
                Target = 0,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 17,
                Indicator = "Кількість відпрацьованих годин, загальна",
                Target = -1,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });
            boardModels.Add(new BoardModel()
            {
                Num = 18,
                Indicator = "Кількість тт які пройшли чек лист відкриття",
                Target = -1,
                Day7 = 0,
                Day6 = 0,
                Day5 = 0,
                Day4 = 0,
                Day3 = 0,
                Day2 = 0,
                Today = 0,
                TargetForTheWeek = 0,
                Result = 0
            });

            return boardModels;
        }
    }
}
