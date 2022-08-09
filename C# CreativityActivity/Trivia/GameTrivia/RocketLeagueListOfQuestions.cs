public class RocketLeagueListOfQuestions : ListOfQuestions
{
    public RocketLeagueListOfQuestions()
    {
        RocketLeague firstQuestion = new RocketLeague(
            "WWhat is the Highest Rank in Rocket League?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Grand Champion"),
                new KeyValuePair<int, string>(2, "Champion"),
                new KeyValuePair<int, string>(3, "Platinum"),  
                new KeyValuePair<int, string>(4, "Super Sonic Legend"),  
            },
            4
        );
        RocketLeague secondQuestion = new RocketLeague(
            "When was Rocket league launched?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "2017"),
                new KeyValuePair<int, string>(2, "2019"),
                new KeyValuePair<int, string>(3, "2018"),  
                new KeyValuePair<int, string>(4, "2015"),  
            },
            4
        );
        RocketLeague thirdQuestion = new RocketLeague(
            "You can play Rocket League on the Wii. True or false",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "True"),
                new KeyValuePair<int, string>(1, "False"),
            },
            1
        );

        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}