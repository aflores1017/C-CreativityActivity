public class WaltDisneyListOfQuestions : ListOfQuestions
{

    public WaltDisneyListOfQuestions()
    {
        WaltDisneyTrivia firstQuestion = new WaltDisneyTrivia(
            "What are the names of Hades minions in Hercules?",
            new List<KeyValuePair<int, string>>{
                new KeyValuePair<int, string>(1, "Stuart and Kevin"),
                new KeyValuePair<int, string>(2, "Meeko and Percy"),
                new KeyValuePair<int, string>(3, "Pain and panic"),
                new KeyValuePair<int, string>(4, "Wilbur and Orville"),
            },
            3
        );
        WaltDisneyTrivia secondQuestion = new WaltDisneyTrivia(
            "What does Hakuna Matata mean?",
            new List<KeyValuePair<int, string>>{
                new KeyValuePair<int, string>(1, "Where there's a will, there's a way"),
                new KeyValuePair<int, string>(2, "No Worries"),
                new KeyValuePair<int, string>(3, "Make the right thing to do the easy thing to do"),
                new KeyValuePair<int, string>(4, "Health first"),
            },
            3
        );
        WaltDisneyTrivia thirdQuestion = new WaltDisneyTrivia(
            "How many fingers does Mickey Mouse have?",
            new List<KeyValuePair<int, string>>{
                new KeyValuePair<int, string>(1, "5"),
                new KeyValuePair<int, string>(2, "3"),
                new KeyValuePair<int, string>(3, "6"),
                new KeyValuePair<int, string>(4, "4"),
            },
            3
        );

        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}