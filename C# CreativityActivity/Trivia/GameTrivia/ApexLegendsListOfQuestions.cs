public class ApexLegendsListOfQuestions : ListOfQuestions
{
    public ApexLegendsListOfQuestions()
    {
        ApexLegend firstQuestion = new ApexLegend(
            "The characters are known as?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "boosters"),
                new KeyValuePair<int, string>(1, "mura"),
                new KeyValuePair<int, string>(2, "legends"),  
            },
            2
        );
        ApexLegend secondQuestion = new ApexLegend(
            "Which one is not a map in the Battle Royale mode?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "Olympus"),
                new KeyValuePair<int, string>(1, "World's Edge"),
                new KeyValuePair<int, string>(2, "Kings Canyon"),  
            },
            2
        );
        ApexLegend thirdQuestion = new ApexLegend(
            "Pathfinder's ability is to scan:",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "Food"),
                new KeyValuePair<int, string>(1, "Treasures"),
                new KeyValuePair<int, string>(2, "None of these"), 
            },
            2
        );

        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}