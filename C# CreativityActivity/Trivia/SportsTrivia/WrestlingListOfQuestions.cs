public class WrestlingListOfQuestions : ListOfQuestions {


    public WrestlingListOfQuestions () {
       WrestlingTrivia firstQuestion = new  WrestlingTrivia(
            "Is WWE real wrestling?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "No"),
                new KeyValuePair<int, string>(2, " Yes "),
                new KeyValuePair<int, string>(3, "Some matches are"),  
                new KeyValuePair<int, string>(4, "Its my childhood don't ruin it"),
            
            },
            1
        ); 
        WrestlingTrivia secondQuestion = new    WrestlingTrivia(
            "How many seconds does it take to pin someone?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "2"),
                new KeyValuePair<int, string>(2, "3"),
                new KeyValuePair<int, string>(3, "5"),  
                new KeyValuePair<int, string>(4, "10"),  

            },
            2
        );
         WrestlingTrivia thirdQuestion = new    WrestlingTrivia(
            "How many points is a takedown in wrestling?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "2"),
                new KeyValuePair<int, string>(2, "3"),
                new KeyValuePair<int, string>(3, "4"),  
                new KeyValuePair<int, string>(4, "5"),  

            },
            1
        );
         base.AddQuestions(firstQuestion);
         base.AddQuestions(secondQuestion);
         base.AddQuestions(thirdQuestion);

    }   
}