namespace ImageToArray
{
    public struct YuvColor
    {
        public float Y;
        public float U;
        public float V;

        public YuvColor(float y, float u, float v)
        {
            Y = y;
            U = u;
            V = v;
        }
    }
}