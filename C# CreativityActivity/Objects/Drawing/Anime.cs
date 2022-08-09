public class Anime : Drawing {

    bool canItMove;
    bool brightHair;

    public Anime (
        bool visibleSketch,
        string sizeOfOutline,
        int numberOfColors) :
        base(
            visibleSketch,
            sizeOfOutline,
            numberOfColors)
    {
        this.canItMove = canItMove;
        this.brightHair = brightHair;
    }
    public string startProject(){
        if (canItMove) {
            return "Nice animation";
        }
        else {
            return "Is it a rough draft?";
        }

    }
    public string startProject (bool isThereAShape){
        if (isThereAShape) {
            if(canItMove) {
                return "Nice drawing";
            }
        
        else {
            return "Is it a rough draft?";
        }
        }
        else {
            return "You don't have any ideas...";
        }
    }
    
}