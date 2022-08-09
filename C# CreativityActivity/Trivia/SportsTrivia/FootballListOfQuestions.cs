public class FootballListOfQuestions : ListOfQuestions {


    public FootballListOfQuestions () {
        FootballTrivia firstQuestion = new FootballTrivia(
            "Who is the quarterback known as the GOAT?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Tom Brady"),
                new KeyValuePair<int, string>(2, "Peyton Manning"),
                new KeyValuePair<int, string>(3, "John Elway"),  
                new KeyValuePair<int, string>(4, "Michael Vick"),
            
            },
            1
        ); 
        FootballTrivia secondQuestion = new FootballTrivia(
            "When was the NFL founded?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "1920"),
                new KeyValuePair<int, string>(2, "1950"),
                new KeyValuePair<int, string>(3, "1925"),  
                new KeyValuePair<int, string>(4, "2000"),  

            },
            1
        );
        FootballTrivia thirdQuestion = new FootballTrivia(
            "What team did Walter Payton play on?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Seahawks"),
                new KeyValuePair<int, string>(2, "Patriots"),
                new KeyValuePair<int, string>(3, "Chicago Bears"),  
                new KeyValuePair<int, string>(4, "Detroit Lions"),  

            },
            3
        );
         base.AddQuestions(firstQuestion);
         base.AddQuestions(secondQuestion);
         base.AddQuestions(thirdQuestion);

    }   
}