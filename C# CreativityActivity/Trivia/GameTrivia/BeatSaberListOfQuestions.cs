public class BeatSaberListOfQuestions : ListOfQuestions
{
    public BeatSaberListOfQuestions()
    {
        BeatSaber firstQuestion = new BeatSaber(
            "What year was the beat saber launched",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "2019"),
                new KeyValuePair<int, string>(1, "2018"),
                new KeyValuePair<int, string>(2, "2017"),  
            },
            1
        );
        BeatSaber secondQuestion = new BeatSaber(
            "What type of game is beat saber",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "Vr shooting Game"),
                new KeyValuePair<int, string>(1, "Vr Rhythm Game"),
                new KeyValuePair<int, string>(2, "Vr Adventure Game"),  
            },
            1
        );
        BeatSaber thirdQuestion = new BeatSaber(
            "When Were Custom Colors Launched",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "September 24,2019"),
                new KeyValuePair<int, string>(1, "September 13, 2019"),
                new KeyValuePair<int, string>(2, "August 30, 2019"), 
            },
            0
        );

        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);//////////////////wake uppppppppp
    }
}