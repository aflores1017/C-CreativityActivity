public class StudioGhibliListOfQuestions : ListOfQuestions
{

    public StudioGhibliListOfQuestions()
    {
        StudioGhibliTrivia firstQuestion = new StudioGhibliTrivia(
            "Which film was Studio Ghibli's first production",
            new List<KeyValuePair<int, string>>{
                new KeyValuePair<int, string>(1, "My Neighbor Totoro"),
                new KeyValuePair<int, string>(2, "Nausicaa of the valley of the wind"),
                new KeyValuePair<int, string>(3, "Castle in the sky"),
                new KeyValuePair<int, string>(4, "Grave of the fireflies"),
            },
            3
        );
        StudioGhibliTrivia secondQuestion = new StudioGhibliTrivia(
            "Which Studio Ghibli film was not directed by Hayao Miyazaki?",
            new List<KeyValuePair<int, string>>{
                new KeyValuePair<int, string>(1, "Kiki's Delivery Service "),
                new KeyValuePair<int, string>(2, "The Wind Rises"),
                new KeyValuePair<int, string>(3, "Ponyo"),
                new KeyValuePair<int, string>(4, "Grave of the fireflies"),
            },
            4
        );
        StudioGhibliTrivia thirdQuestion = new StudioGhibliTrivia(
            "Which Studio Ghibli character is featured in the studio's logo",
            new List<KeyValuePair<int, string>>{
                new KeyValuePair<int, string>(1, "Calcifer from Howl's Moving Castle"),
                new KeyValuePair<int, string>(2, "Totoro from My Neighbor Totoro"),
                new KeyValuePair<int, string>(3, "Jiji from Kiki's Delivery Service"),
                new KeyValuePair<int, string>(4, "Moro from Princess Mononoke"),
            },
            2
        );

        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}