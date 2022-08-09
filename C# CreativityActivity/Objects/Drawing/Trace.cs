public class Trace : Drawing
{
    public Trace(
        bool visibleSketch, string sizeOfOutline, int numberOfColors) : 
        base(
            visibleSketch, 
            sizeOfOutline, 
            numberOfColors)
    {
        
    }

    public bool CanIActuallySeeIt()
   {
       return false;
   }
 
   public void Inspire()
   {
       Console.WriteLine("Inspired");
   }
}
