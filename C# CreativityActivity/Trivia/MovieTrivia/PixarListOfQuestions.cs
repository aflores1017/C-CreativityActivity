public class PixarListOfQuestions : ListOfQuestions
{

    public PixarListOfQuestions()
    {
        PixarTrivia firstQuestion = new PixarTrivia(
            "What is the name of Andy's neighbor in Toy Story?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Michael"),
                new KeyValuePair<int, string>(2, "Bruce"),
                new KeyValuePair<int, string>(3, "David"),
                new KeyValuePair<int, string>(4, "Sid"),
            },
            4 // Whichever one is right
        );
        PixarTrivia secondQuestion = new PixarTrivia(
            "Who is Remy's culinary hero in Ratatouille?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Auguste Gusteau"),
                new KeyValuePair<int, string>(2, "Betty Crocker"),
                new KeyValuePair<int, string>(3, "Justin Wilson"),
                new KeyValuePair<int, string>(4, "Rick Bayless"),
            },
            1
        );
        PixarTrivia thirdQuestion = new PixarTrivia(
            "What was the first Pixar Movie?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Monsters Inc."),
                new KeyValuePair<int, string>(2, "Toy Story"),
                new KeyValuePair<int, string>(3, "Ratatouille"),
                new KeyValuePair<int, string>(4, "A Bug's Life"),
            },
            2
        );

        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}