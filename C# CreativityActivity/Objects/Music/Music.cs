public class Music {

    private List<string> genre; 
        
    private int numberOfInstruments;
    private int amountOfRhythmes;
    private int numberOfBeats;
    public int numberOfGenres {

        get {
            return numberOfGenres;
        }

        set {
            switch (value) 
            {
                case 4:
                numberOfGenres = value;
                break;

                case 9:
                numberOfGenres = value;
                break;

                case 3:
                numberOfGenres = value;
                break;

                default:
                numberOfGenres = 1;
                break;
            }

        }

    }
    public Music (
     int numberOfInstruments,
     int amountOfRhythmes,
     int numberOfBeats,
     int numberOfGenres
    )
    {
    this.numberOfInstruments = numberOfInstruments;
    this.amountOfRhythmes = amountOfRhythmes;
    this.numberOfBeats = numberOfBeats; 
    this.numberOfGenres = numberOfGenres;       
    }
    public bool playsAnInstrument() {
        if (numberOfInstruments > 0) {
            return true; 
        }
        else {
            return false;
        }
    }
    public void changeNumberOfInstruments(int newNumberOfInstruments) {
        this.numberOfInstruments = newNumberOfInstruments;
    }


}

