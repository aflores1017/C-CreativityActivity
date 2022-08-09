public class Sport {
    //properties that makes it a sport
    //
    
    private List<string> listofsports;
    private bool isCompetitive;
    private int numberOfPlayers;
    private string typeOfSport;
    private int numberOfTeams;
    private int scoringPoints;


    public string TypeOfSport { 
        get {
            return this.typeOfSport;
        }
        set {
            
            switch (value) 
            {
                case "Football":
                    typeOfSport = value;
                    break;
                case "Baseball":
                    typeOfSport = value;
                    break;
                case "Basketball":
                    typeOfSport = value;
                    break;
                default:
                    typeOfSport = "This sport is lame";
                    break;
            }
        }
    }

    public Sport (
   
        bool isCompetitive,
        int numberOfPlayers,
        string typeOfSport,
        int scoringPoints,
        int numberOfTeams
    )
    {  
         this.isCompetitive = isCompetitive;
         this.numberOfPlayers = numberOfPlayers;
         this.typeOfSport = typeOfSport;
         this.scoringPoints = scoringPoints;
         this.numberOfTeams = numberOfTeams;
    }

    public bool isAHumanSport () {
        if (isCompetitive == true && TypeOfSport == "Football") {
            return true; 
        }
        else {
            return false;
        }
    }
       
       
    public int scoringAPoint (){
        if (scoringPoints > 5){
            return 6;
        } 
        else { 
            return 0;
        }
    }
 }
 // string scoringAPoint
 // bool movementInSport
 // int waysToMove
 // bool throwingABall