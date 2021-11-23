namespace DaybookCore.Entities
{
    public class Point
    {
        public const byte MinPoint = 1;
        public const byte MaxPoint = 12;

        private byte _value;

        public byte Value
        {
            get => _value;
            set 
            {
                _value = value >= MinPoint && value <= MaxPoint
                    ? value
                    : MinPoint;
            }
        }

        public static bool operator >(Point point, Point secoundPoint)
        {
            return point.Value > secoundPoint.Value;
        }

        public static bool operator <(Point point, Point secoundPoint)
        {
            return point.Value < secoundPoint.Value;
        }

        public static bool operator ==(Point point, Point secoundPoint)
        {
            return point.Value == secoundPoint.Value;
        }

        public static bool operator !=(Point point, Point secoundPoint)
        {
            return point.Value != secoundPoint.Value;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
