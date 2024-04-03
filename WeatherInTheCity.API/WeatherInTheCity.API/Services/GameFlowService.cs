using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.Services
{
    public class GameFlowService : IGameFlowService
    {
        private readonly WeatherInTheCityDbContext _context;

        public GameFlowService(WeatherInTheCityDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateGameFlow(string correctCity)
        {
            Guid guid = Guid.NewGuid();

            var question = new Question();
            question.QuestionNumber = 1;
            question.CorrectAnswer = correctCity;
            question.UserAnswer = null;
            question.UserPoint = false;

            var questionList = new QuestionList();
            questionList.Questions = new List<Question>();
            questionList.Questions = [question];


            var gameFlow = new GameFlow();
            gameFlow.Id = guid;
            gameFlow.Question = SerializeList(questionList);
            gameFlow.UserId = null;
            gameFlow.LastUpdate = DateTime.Now;


            await _context.GameFlows.AddAsync(gameFlow);
            await _context.SaveChangesAsync();

            return guid.ToString();

        }

        public async Task<string> AddQuestion(string correctCity, string gameFlowId)
        {
            var guid = Guid.Parse(gameFlowId);
            var gameFlow = await _context.GameFlows.Where(r => r.Id == guid).FirstOrDefaultAsync();

            if (gameFlow == null) return null!;

            gameFlow.LastUpdate = DateTime.Now;
            var questionList = DeserializeList(gameFlow.Question);
            var lastQuestionNumber = 0;

            foreach (var question in questionList.Questions!)
            {
                lastQuestionNumber = question.QuestionNumber > lastQuestionNumber ? question.QuestionNumber : lastQuestionNumber;
            }

            var newQuestion = new Question() { QuestionNumber = ++lastQuestionNumber, CorrectAnswer = correctCity, UserAnswer = null, UserPoint = false };
            questionList.Questions.Add(newQuestion);

            gameFlow.Question = SerializeList(questionList);
            await _context.SaveChangesAsync();

            return guid.ToString();
        }

        public async Task<string> GivePoint(int questionId, string gameFlowId)
        {

            var guid = Guid.Parse(gameFlowId);
            var gameFlow = await _context.GameFlows.Where(r => r.Id == guid).FirstOrDefaultAsync();

            if (gameFlow == null) return null!;

            gameFlow.LastUpdate = DateTime.Now;
            var questionList = DeserializeList(gameFlow.Question);
            var question = questionList.Questions!.Where(q => q.QuestionNumber == questionId).FirstOrDefault();

            if(question != null)
            {
                question.UserPoint = true;
                gameFlow.Question = SerializeList(questionList);
                await _context.SaveChangesAsync();
            }         

            return guid.ToString();

        }

        public async Task RemoveGameFlow(string gameFlowId)
        {
            var guid = Guid.Parse(gameFlowId);
            var gameFlow = await _context.GameFlows.Where(r => r.Id == guid).FirstOrDefaultAsync();

            if (gameFlow != null)
            {
                _context.GameFlows.Remove(gameFlow!);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<string> GetCorrectAnswer(string gameFlowId, int questionNumber)
        {
            var guid = Guid.Parse(gameFlowId);
            var gameFlow = await _context.GameFlows.Where(r => r.Id == guid).FirstOrDefaultAsync();

            if (gameFlow == null) return null!;

            var questionList = DeserializeList(gameFlow.Question);
            var correctAnswer = String.Empty;

            foreach(var question in questionList.Questions!)
            {
                if (question.QuestionNumber == questionNumber)
                {
                    correctAnswer = question.CorrectAnswer;
                    break;
                }
            }

            return correctAnswer;

        }


        private string SerializeList(QuestionList questionList)
        {
            string result = JsonConvert.SerializeObject(questionList);
            return result;
        }

        private QuestionList DeserializeList(string serializedList)
        {
            QuestionList? result = JsonConvert.DeserializeObject<QuestionList>(serializedList);
            return result!;
        }

    }
}
