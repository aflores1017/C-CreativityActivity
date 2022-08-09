public class PopListOfQuestions : ListOfQuestions{

    public PopListOfQuestions () {
        PopTrivia firstQuestion = new PopTrivia (
            "Who is known as the King of Pop?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Prince"),
                new KeyValuePair<int, string>(2, "Future"),
                new KeyValuePair<int, string>(3, "Micheal Jackson"),  
                new KeyValuePair<int, string>(4, "The Weeknd"),
            },
        4
        ); 
        PopTrivia secondQuestion = new PopTrivia (
            "Who screamed BABY BABY BABY OOOH?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Ariana Grande"),
                new KeyValuePair<int, string>(2, "Selena Gomez"),
                new KeyValuePair<int, string>(3, "Taylor Swift"),  
                new KeyValuePair<int, string>(4, "Justin Beiber"),
            },
        4
        ); 
          PopTrivia thirdQuestion = new PopTrivia (
            "Who mad a song called WHAT DOES THE FOX SAY?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Billie Eilish"),
                new KeyValuePair<int, string>(2, "Beyonce"),
                new KeyValuePair<int, string>(3, "Ylvis"),  
                new KeyValuePair<int, string>(4, "Justin Timberlake"),
            },
        3
        ); 
        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}


