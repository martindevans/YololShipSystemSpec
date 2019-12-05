namespace YololShipSystemSpec.Types
{
    public class TypeInfo
    {
        public YololType Type { get; }

        public decimal? Min { get; }
        public decimal? Max { get; }

        public TypeInfo(YololType type)
        {
            Type = type;
            Min = null;
            Max = null;
        }

        public TypeInfo(YololType type, decimal min, decimal max)
        {
            Type = type;
            Min = min;
            Max = max;
        }
    }
}
