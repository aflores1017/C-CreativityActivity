public class Shooter : Game {
   private bool firstPerson;
 
   public Shooter (
       bool onlinePlay,
       int numberOfCharacter,
       string typeOfGame,
       bool firstPerson):

    base (
       onlinePlay,
       numberOfCharacter,
       typeOfGame)

    {
       this.firstPerson = firstPerson;
    }
 
   public string playCompetitive (){
     if (firstPerson){
           return "You better win";
            }
           else {
               return "It don't matter";
           }
        }
 
    public string playCompetitive (bool thisIsGoingToBeBorning){
      if(thisIsGoingToBeBorning){
         if (firstPerson){
            return "You better win";
         }
         else {
            return "It don't matter";
             }
         }
        else {
         return "Lets try to make it fun";
            }
        }
 
   public string playGame(){
      if (firstPerson){
         return "Lets play";
      }
      else {
         return "Lets not play";
      }
   }
   public string playGame(bool onlinePlay){
      if(onlinePlay) {
         if(firstPerson) {
            return "we are going to have fun";
         }
         else{
            return "we are not going to have fun";
         }
         }
         else {
            return "we are not going to have fun";
         } 
         
      }
   }
   
   //public void wantsToHaveFun(){
    //   playWithFrineds();
  // }
//} 
 
 