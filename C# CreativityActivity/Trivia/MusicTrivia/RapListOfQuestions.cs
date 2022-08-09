public class RapListOfQuestions : ListOfQuestions{

    public RapListOfQuestions () {
        RapTrivia firstQuestion = new RapTrivia (
            "Who is known as one of the most influential rappers of all time?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Playboi Carti"),
                new KeyValuePair<int, string>(2, "Tupac Shakur"),
                new KeyValuePair<int, string>(3, "Justin Timberlake"),  
                new KeyValuePair<int, string>(4, "Kendrick Lamar"),
            },
        2 
        ); 
        RapTrivia secondQuestion = new RapTrivia (
            "Who went double platinum with no features?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "J.Cole"),
                new KeyValuePair<int, string>(2, "Lil T-jay"),
                new KeyValuePair<int, string>(3, "Polo-G"),  
                new KeyValuePair<int, string>(4, "Pusha T"),
            },
        1
        );
        RapTrivia thirdQuestion = new RapTrivia (
            "Who loved it when they got called BIG POPPA?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "G Herbo"),
                new KeyValuePair<int, string>(2, "Slick Rick"),
                new KeyValuePair<int, string>(3, "Ice Cube"),  
                new KeyValuePair<int, string>(4, "Biggie Smalls"),
            },
        4
        );
        RapTrivia fourthQuestion = new RapTrivia (
            "Who made a song called LOVE SOSA?", 
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "CHIEF KEEF"),
                new KeyValuePair<int, string>(2, "NLE CHOPPA"),
                new KeyValuePair<int, string>(3, "G HERBO"),  
                new KeyValuePair<int, string>(4, "YOUNG PAPPY"),
            },
        1
        ); 
         base.AddQuestions(firstQuestion);
         base.AddQuestions(secondQuestion);
         base.AddQuestions(thirdQuestion);
         base.AddQuestions(fourthQuestion);

    }
}

