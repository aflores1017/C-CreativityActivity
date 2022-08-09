public class ColoringPage : Drawing
{
    public ColoringPage(
        bool visibleSketch,
        string sizeOfOutline,
        int numberOfColors) : 
        base(
            visibleSketch,
            sizeOfOutline,
            numberOfColors)
    {
    }

    public bool CanIActuallySeeIt()
   {
       Console.WriteLine("I see it");
       return true;
   }
 
   public void Inspire()
   {
       Console.WriteLine("I want to Color!");
   }
}
