// public class Games {
// //    private bool onlinePlay;
//    private int numberOfCharacter;
//    private string typeOfGame;
//    private int onlinePlay;

// pickTypeOfGame (){
//     Console.WriteLine("Which type of game would you like: ");
//     string typeOfGame = Console.ReadLine();
//     return ;
// }
// public string TypeOfGame {

//        get {
//            return typeOfGame;
//        }
//        set {
//            switch (value)
//            {
//                case "RPG":
//                    typeOfGame = value;
//                    break;
//                case "Horror":
//                    typeOfGame = value;
//                    break;
//                case "Shooter":
//                    typeOfGame= value;
//                    break;
//                    default:
//                    typeOfGame = "Let's not play";
//                    break;
//            }
//        }
//     }

// pickNumberOfCharacter(){
//     Console.WriteLine("How many playable characters do you want?");
//     int numberOfCharacter = Console.ReadLine();
//     return;
// }
// public int NumberOfCharacter{
//      get {
//            return numberOfCharacter;
//        }
//        set {
//            switch (value)
//            {
//                case 1:
//                    typeOfGame = value;
//                    break;
//                case 2:
//                    typeOfGame = value;
//                    break;
//                case 3:
//                    typeOfGame= value;
//                    break;
//                    default:
//                    typeOfGame = "Next time Choose the numbers given";
           
// }
// }
// // Don't write new objects - bring in the ones from two weeks ago

public class Game {
  
   private bool onlinePlay;
   private int numberOfCharacter;
   private string typeOfGame;
 
   public string TypeOfGame {
       get {
           return typeOfGame;
       }
       set {
           switch (value)
           {
               case "RPG":
                   typeOfGame = value;
                   break;
               case "Horror":
                   typeOfGame = value;
                   break;
               case "Shooter":
                   typeOfGame= value;
                   break;
               default:
                   typeOfGame = "Let's not play";
                   break;
           }
       }
   }

    
   public Game (
       bool onlinePlay,
       int numberOfCharacter,
       string typeOfGame
   )
   {
       this.onlinePlay = onlinePlay;
       this.numberOfCharacter = numberOfCharacter;
       this.typeOfGame = typeOfGame;
   }
   
   
   protected bool playWithFrineds (){
       if (onlinePlay){
           return true;
       }
       else {
           return false;
       }
   }
 
   public void feelsBoard (){
       playWithFrineds();
   }
}
