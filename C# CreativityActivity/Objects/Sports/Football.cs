public class Football : Sport{
     
    private bool helmetsAndShoulderPads;
    
    public Football(
        bool isCompetitive,
        int numberOfPlayers,
        string typeOfSport,
        int scoringPoints,
        int numberOfTeams,
        bool helmetsAndShoulderPads) :
        base(
            isCompetitive,
            numberOfPlayers,
            typeOfSport,
            scoringPoints,
            numberOfTeams) => this.helmetsAndShoulderPads = helmetsAndShoulderPads;


    public string StartSuitingUp (){
        if(helmetsAndShoulderPads) {
            return "Get the Pigskin!";
        }
        else {
            return "This is Boring...";
        }
    }

     public string StartSuitingUp (bool coachSaidItsOkay){
        if (coachSaidItsOkay) {
            if(helmetsAndShoulderPads) {
                return "Get the Pigskin!";
            }
            else {
                return "This is Boring...";
            }
        }
        else {
            return "Nah, we gotta listen to the coach";
        }
    }
}