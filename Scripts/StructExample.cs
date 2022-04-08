namespace DefaultNamespace
{
    public struct StructExample
    {
        private int x;
        private int y;
        
        public StructExample(int x, int y)
        {
            this.x = x; 
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