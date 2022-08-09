public class RockListOfQuestions : ListOfQuestions{

    public RockListOfQuestions () {
        RockTrivia firstQuestion = new RockTrivia (
            "Who smelled the teen spirit?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Nirvana"),
                new KeyValuePair<int, string>(2, "Kiss"),
                new KeyValuePair<int, string>(3, "Coldplay"),  
                new KeyValuePair<int, string>(4, "Maroon 5"),
            },
        2 
        ); 
         RockTrivia secondQuestion = new RockTrivia (
            "Who is the best selling music act of all time?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "The Beatles"),
                new KeyValuePair<int, string>(2, "Nirvana"),
                new KeyValuePair<int, string>(3, "The Rolling Stones"),  
                new KeyValuePair<int, string>(4, "Queen"),
            },
        1
        ); 
         RockTrivia thirdQuestion = new RockTrivia (
            "How many times were Lincoln Park rejected by record labels?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "9"),
                new KeyValuePair<int, string>(2, "500"),
                new KeyValuePair<int, string>(3, "37"),  
                new KeyValuePair<int, string>(4, "43"),
            },
        4
        ); 
         base.AddQuestions(firstQuestion);
         base.AddQuestions(secondQuestion);
         base.AddQuestions(thirdQuestion);
    
}
}