public class Rap : Music {
    private bool lyricsAreMeteredOrRhyme;
 
    public Rap(
        int numberOfInstruments,
        int amountOfRhythms,
        int numberOfBeats,
        int numberOfGenres,
        bool lyricsAreMeteredOrRhyme) :
    base(
        numberOfInstruments,
        amountOfRhythms,
        numberOfBeats,
        numberOfGenres)
    {
        this.lyricsAreMeteredOrRhyme = lyricsAreMeteredOrRhyme;
    }
 
public string startSpittin() {
    if (lyricsAreMeteredOrRhyme) {
        return "Yo, thats fire";
        }
    else {
        return "Nah, thats just a boring ass speech";
    }

}

public string startSpittin (bool thisGoesHard){
    if (thisGoesHard) {
        if(lyricsAreMeteredOrRhyme) {
        return "Yo, thats fire";
        }
    else {
        return "Nah, thats just a boring ass speech";
        }
        }
    else {
        return "I like music";
        }
}
public string writingMusic() {
    if(lyricsAreMeteredOrRhyme) {
        return "This beat is heat my boy";
        }
    else {
        return "This beat could be way better tbh";
        }
}

public string writingMusic(bool penToPaper) {
    if (penToPaper) { 
        if(lyricsAreMeteredOrRhyme) {
        return "That bar go crazy";
        }
    else {
        return "This song too relatable";
        }
        } 
    else
        {
        return "This song too relatable";    
        }           
    }

}
