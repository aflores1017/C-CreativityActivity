public class PopTrivia : Trivia
{
    public PopTrivia(string question, List<KeyValuePair<int, string>> possibleAnswers, int keyToAnswer) : base(question, possibleAnswers, keyToAnswer)
    {
    }
}