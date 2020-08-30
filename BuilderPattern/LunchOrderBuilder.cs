namespace BuilderPattern
{
    /// <summary>
    /// Object created with Builder Pattern needs to be immutable.
    /// Internal Builder Class used to create the LunchOrder object
    /// </summary>
    public class LunchOrder
    {
        private string Bread { get; }
        private string Meat { get; }
        private string Dressing { get; }

        public class Builder
        {
            public string Bread;
            public string Meat;
            public string Dressing;

            public Builder AddBread(string bread)
            {
                this.Bread = bread;
                return this;
            }

            public Builder AddMeat(string meat)
            {
                this.Meat = meat;
                return this;
            }

            public Builder AddDressing(string dressing)
            {
                this.Dressing = dressing;
                return this;
            }
        }

        public LunchOrder(Builder builder)
        {
            this.Bread = builder.Bread;
            this.Dressing = builder.Dressing;
            this.Meat = builder.Meat;
        }

        public string GetBread()
        {
            return this.Bread;
        }
        public string GetDressing()
        {
            return this.Dressing;
        }
        public string GetMeat()
        {
            return this.Meat;
        }
    }
}