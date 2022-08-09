public class Drawing : IDrawing {
     //limit 3 properties of drawing

    private List<string> Procompany;
    private bool visibleSketch;//sketching
    private string sizeOfOutline;//outlining or inking
    private int numberOfColors;//coloring in
    public string SizeOfOutLine {
         get {
              return sizeOfOutline;
         }
         set {
              switch (value)
              {
                   case "thin":
                      sizeOfOutline = value;
                      break;
                   case "not thin or thick":
                      sizeOfOutline = value;
                      break;
                   case "thick":
                      sizeOfOutline = value;
                      break;  
                   default:
                      sizeOfOutline = "Is there an outline?";
                      break;
              }
         }
     }
     public Drawing(
          bool visibleSketch,
          string sizeOfOutline,
          int numberOfColors
     )
     {
          this.visibleSketch = visibleSketch;
         this.sizeOfOutline = sizeOfOutline;          
         this.numberOfColors = numberOfColors;
     }
    public bool CanIActuallySeeIt() {
         if (visibleSketch == true) {
              return true;
              Console.WriteLine("Woah, nice drawing!");
         }
         else {
              return false;
              Console.WriteLine("Is it a polar bear in a snow storm?");
         }
    }
         public void Inspire()
    {
         Console.WriteLine("I am so inspired!");
    }    
}
