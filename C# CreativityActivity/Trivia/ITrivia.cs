public interface ITrivia {
    public string AskQuestions();
    public List<KeyValuePair<int, string>> GetAnswers();
    public bool CheckAnswers(int answerSelected);
}