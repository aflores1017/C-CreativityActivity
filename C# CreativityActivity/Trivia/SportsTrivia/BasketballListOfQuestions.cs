public class BasketballListOfQuestions : ListOfQuestions {


    public BasketballListOfQuestions () {
        BasketballTrivia firstQuestion = new BasketballTrivia(
            "Which NBA player tried for MLB but failed miserably?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Lebron James"),
                new KeyValuePair<int, string>(2, "Michael Jordan"),
                new KeyValuePair<int, string>(3, "Stephen curry"),  
                new KeyValuePair<int, string>(4, "Nobody"),
            
            },
            2
        ); 
        BasketballTrivia secondQuestion = new  BasketballTrivia(
            "How many championships did Michael Jordan win?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "3"),
                new KeyValuePair<int, string>(2, "0"),
                new KeyValuePair<int, string>(3, "5"),  
                new KeyValuePair<int, string>(4, "6"),  

            },
            4
        );
         BasketballTrivia thirdQuestion = new  BasketballTrivia(
            "When was the NBA founded?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "1946"),
                new KeyValuePair<int, string>(2, "1956"),
                new KeyValuePair<int, string>(3, "1947"),  
                new KeyValuePair<int, string>(4, "1960"),  

            },
            1
        );
         base.AddQuestions(firstQuestion);
         base.AddQuestions(secondQuestion);
         base.AddQuestions(thirdQuestion);

    }   
}