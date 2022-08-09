using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

List<KeyValuePair<int, string>> musicListOfSubs = new List<KeyValuePair<int, string>>();
List<KeyValuePair<int, string>> animationListOfSubs = new List<KeyValuePair<int, string>>();
List<KeyValuePair<int, string>> sportsListOfSubs = new List<KeyValuePair<int, string>>();
List<KeyValuePair<int, string>> gamesListOfSubs = new List<KeyValuePair<int, string>>();

List<KeyValuePair<int, ListOfQuestions>> musicListOfQuestions = new List<KeyValuePair<int, ListOfQuestions>>();
List<KeyValuePair<int, ListOfQuestions>> animationListOfQuestions = new List<KeyValuePair<int, ListOfQuestions>>();
List<KeyValuePair<int, ListOfQuestions>> sportsListOfQuestions = new List<KeyValuePair<int, ListOfQuestions>>();
List<KeyValuePair<int, ListOfQuestions>> gamesListOfQuestions = new List<KeyValuePair<int, ListOfQuestions>>();

musicListOfSubs.Add(new KeyValuePair<int, string>(1, "Pop"));
musicListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(1, new PopListOfQuestions()));
musicListOfSubs.Add(new KeyValuePair<int, string>(2, "Rap"));
musicListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(2, new RapListOfQuestions()));
musicListOfSubs.Add(new KeyValuePair<int, string>(3, "RnB"));
musicListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(3, new RnBListOfQuestions()));
musicListOfSubs.Add(new KeyValuePair<int, string>(4, "Rock"));
musicListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(4, new RockListOfQuestions()));

gamesListOfSubs.Add(new KeyValuePair<int, string>(1, "Dead By Dead Light"));
gamesListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(1, new DeadByDeadLightListOfQuestons()));
gamesListOfSubs.Add(new KeyValuePair<int, string>(2, "Apex Legends"));
gamesListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(2, new ApexLegendsListOfQuestions()));
gamesListOfSubs.Add(new KeyValuePair<int, string>(3, "Beat Saber"));
gamesListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(3, new BeatSaberListOfQuestions()));
gamesListOfSubs.Add(new KeyValuePair<int, string>(4, "Rocket League"));
gamesListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(4, new RocketLeagueListOfQuestions()));

sportsListOfSubs.Add(new KeyValuePair<int, string>(1, "Football"));
sportsListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(1, new FootballListOfQuestions()));
sportsListOfSubs.Add(new KeyValuePair<int, string>(2, "Baseball"));
sportsListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(2, new BaseballListOfQuestions()));
sportsListOfSubs.Add(new KeyValuePair<int, string>(3, "Basketball"));
sportsListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(3, new BasketballListOfQuestions()));
sportsListOfSubs.Add(new KeyValuePair<int, string>(4, "Wrestling"));
sportsListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(4, new WrestlingListOfQuestions()));

animationListOfSubs.Add(new KeyValuePair<int, string>(1, "Pixar"));
animationListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(1, new PixarListOfQuestions()));
animationListOfSubs.Add(new KeyValuePair<int, string>(2, "Walt Disney"));
animationListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(2, new WaltDisneyListOfQuestions()));
animationListOfSubs.Add(new KeyValuePair<int, string>(3, "Studio Ghibli"));
animationListOfQuestions.Add(new KeyValuePair<int, ListOfQuestions>(3, new StudioGhibliListOfQuestions()));

Console.WriteLine("This is a trivia game!");

//Function 1: Lists category 3items
Console.WriteLine("Pick a category: \n 1. Music \n 2. Animation \n 3. Sports \n 4. Games");

string userCategoryAnswer = Console.ReadLine();

int countSubCategory = 0;
switch (userCategoryAnswer)
{
    case "1":

        GetQuestion(musicListOfSubs, musicListOfQuestions);
        // check users answer (triviaToAsk.CheckAnswer)
        break;

    case "2":
        GetQuestion(animationListOfSubs, animationListOfQuestions);
        // Print out all the animation categories
        break;

    case "3":
        GetQuestion(sportsListOfSubs, sportsListOfQuestions);
        // Print out all the sports categories
        break;

    case "4":
        GetQuestion(gamesListOfSubs, gamesListOfQuestions);
        // Print out all the games categories
        break;
}


static void GetQuestion(List<KeyValuePair<int, string>> listOfSubs, List<KeyValuePair<int, ListOfQuestions>> listOfQuestions) {
    foreach (var item in listOfSubs) {
        Console.WriteLine(item.Key + ") " + item.Value);
    }
    string userInput = Console.ReadLine();
    int userInputNumber = Int32.Parse(userInput);
    var result = listOfQuestions.Where(item => item.Key == userInputNumber).FirstOrDefault();
    var triviaToAsk = result.Value.AskRandomQuestionAndAnswer();
    
    Console.WriteLine(triviaToAsk.AskQuestions());
    foreach (var possibleTriviaAnswer in triviaToAsk.GetAnswers()){
        Console.WriteLine(possibleTriviaAnswer.Key + ") " + possibleTriviaAnswer.Value);
    }

    var userAnswer = Console.ReadLine();

    bool isAnswerRight = triviaToAsk.CheckAnswers(Int32.Parse(userAnswer));

    if(isAnswerRight) {
        Console.Write("Looks like you know your stuff!!");
    }
    else {
        Console.Write("TOUGH LUCK BUDDY DO BETTER NEXT TIME!");
    }
}