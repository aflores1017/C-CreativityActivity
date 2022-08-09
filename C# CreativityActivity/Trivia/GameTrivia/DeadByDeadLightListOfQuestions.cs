public class DeadByDeadLightListOfQuestons : ListOfQuestions
{
    public DeadByDeadLightListOfQuestons()
    {
        DeadByDeadLight firstQuestion = new DeadByDeadLight(
            "The game 'Dead by Daylight' was launched in the year?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "2020"),
                new KeyValuePair<int, string>(1, "2016"),
                new KeyValuePair<int, string>(2, "2018"),  
            },
            1
        );
        DeadByDeadLight secondQuestion = new DeadByDeadLight(
            "What is the weapon used by the Trapper?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "Bear Traps"),
                new KeyValuePair<int, string>(1, "BoneSaw"),
                new KeyValuePair<int, string>(2, "Bow and Arrow"),  
            },
            0
        );
        DeadByDeadLight thirdQuestion = new DeadByDeadLight(
            "How many survivor characters are there in this game series?",
            new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(0, "26"),
                new KeyValuePair<int, string>(1, "20"),
                new KeyValuePair<int, string>(2, "31"),  
            },
            2
        );
        base.AddQuestions(firstQuestion);
        base.AddQuestions(secondQuestion);
        base.AddQuestions(thirdQuestion);
    }
}