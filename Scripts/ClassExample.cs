using Unity.VisualScripting;
using UnityEngine.Timeline;

namespace DefaultNamespace
{
    public class ClassExample
    {
        private int x;
        private int y;  // notice the read only suggestion 

        public ClassExample(int x, int y)
        {
            this.x = x; // Try highlighting the variables if you don't understand
            this.y = y; 
        }

        public void SetX(int new_x)
        {
            x = new_x; 
        }

        public int GetX()
        {
            return x; 
        }

        public override string ToString()
        {
            return x.ToString() + ", " + y.ToString();
        }
    }
}