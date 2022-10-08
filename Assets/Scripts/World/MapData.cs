public class MapData
{
    public float[,] Data;
    private float min;
    public float Min {
        get {
            return min;
        }
        set {
            min = value;
        }
    }
    private float max;
    public float Max {
        get {
            return max;
        }
        set {
            max = value;
        }
    }

    public MapData(int width, int height) {
        Data = new float[width,height];
        Min = float.MaxValue;
        Max = float.MinValue;
    }
}
