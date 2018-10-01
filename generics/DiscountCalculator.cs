namespace generics
{
    // class constaint - where T : Product
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    // value type constraint - where T : struct
    // in C# value type can not be null
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}