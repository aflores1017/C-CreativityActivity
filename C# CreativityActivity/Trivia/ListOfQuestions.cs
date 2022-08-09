public class ListOfQuestions {
    private List<ITrivia> questions = new List<ITrivia>();

    public List<ITrivia> Questions { get => questions; set => questions = value; }

    public void AddQuestions(ITrivia trivia) {
        questions.Add(trivia);
    }

    public Trivia AskRandomQuestionAndAnswer() {
        var random = new Random();
        int index = random.Next(this.Questions.Count);
        return (Trivia)this.Questions[index];
    }
}