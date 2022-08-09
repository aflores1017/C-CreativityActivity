public class Paint : Drawing
{
    public Paint(bool visibleSketch, string sizeOfOutline, int numberOfColors) : base(visibleSketch, sizeOfOutline, numberOfColors)
    {
    }

    public bool CanIActuallySeeIt()
   {
       return false;
   }
 
   public void Inspire()
   {
       Console.WriteLine("Inspiration");
      
   }
}
