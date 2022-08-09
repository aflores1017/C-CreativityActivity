public class PencilSketch : Drawing
{
    public PencilSketch(
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
       return false;
   }
 
   public void Inspire()
   {
       Console.WriteLine(" I love this pencil sketch");
   }
}
