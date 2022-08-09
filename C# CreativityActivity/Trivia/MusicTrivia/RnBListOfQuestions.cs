public class RnBListOfQuestions : ListOfQuestions{

    public RnBListOfQuestions () {
        RnBTrivia firstQuestion = new RnBTrivia (
            "Who had a tornado fly around their room?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Tank"),
                new KeyValuePair<int, string>(2, "Frank Ocean"),
                new KeyValuePair<int, string>(3, "Justin Timberlake"),  
                new KeyValuePair<int, string>(4, "Chris Brown"),
            },
        2 
        ); 
        RnBTrivia secondQuestion = new RnBTrivia (
            "Who had too many confessions?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Usher"),
                new KeyValuePair<int, string>(2, "Beyonce"),
                new KeyValuePair<int, string>(3, "Jhene Aiko"),  
                new KeyValuePair<int, string>(4, "Chris Brown"),
            },
        1 
        ); 
        RnBTrivia thirdQuestion = new RnBTrivia (
            "Who made a song called The Worst?", 
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Jhene Aiko"),
                new KeyValuePair<int, string>(2, "Brent Faiyaz"),
                new KeyValuePair<int, string>(3, "Jeremmih"),  
                new KeyValuePair<int, string>(4, "Ari Lennox"),
            },
        1
        ); 
        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}

