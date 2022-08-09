public class Trivia : ITrivia
{
    private string question;

    private List<KeyValuePair<int, string>> possibleAnswers;

    private int keyToAnswer;

    public Trivia(string question, List<KeyValuePair<int, string>> possibleAnswers, int keyToAnswer)
    {
        this.question = question;
        this.possibleAnswers = possibleAnswers;
        this.keyToAnswer = keyToAnswer;
    }

    public string AskQuestions()
    {
        return question;
    }

    public bool CheckAnswers(int answerSelected)
    {
        return answerSelected == keyToAnswer;
    }

    public List<KeyValuePair<int, string>> GetAnswers()
    {
        return possibleAnswers;
    }
}