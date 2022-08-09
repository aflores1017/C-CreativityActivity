public class BaseballListOfQuestions : ListOfQuestions {


    public BaseballListOfQuestions () {
       BaseballTrivia firstQuestion = new  BaseballTrivia(
            "Who broke the color barrier for African American MLB players?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Jackie Robinson"),
                new KeyValuePair<int, string>(2, "Willie Mays "),
                new KeyValuePair<int, string>(3, "Ernie Banks"),  
                new KeyValuePair<int, string>(4, "Barry Bonds"),
            
            },
            1
        ); 
        BaseballTrivia secondQuestion = new   BaseballTrivia(
            "Which team in MLB has the most World Series titles?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "New York Yankees"),
                new KeyValuePair<int, string>(2, "St. Louis Cardinals"),
                new KeyValuePair<int, string>(3, "Chicago Cubs"),  
                new KeyValuePair<int, string>(4, "Chicago White Sox"),  

            },
            1
        );
         BaseballTrivia thirdQuestion = new   BaseballTrivia(
            "Who is better: the White Sox or Cubs?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "White Sox"),
                new KeyValuePair<int, string>(2, "Cubs"),
                new KeyValuePair<int, string>(3, "I like Both"),  
                new KeyValuePair<int, string>(4, "None"),  

            },
            4
        );
         base.AddQuestions(firstQuestion);
         base.AddQuestions(secondQuestion);
         base.AddQuestions(thirdQuestion);

    }   
}