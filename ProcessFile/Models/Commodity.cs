namespace ProcessFile.Models
{
    public class Commodity : Item
    {
        public float Capacity { get; set; }
        public Commodity(string name, decimal price, float capacity) : base(name, price)
        {
            Capacity = capacity;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} {Capacity}";
        }
    }
}
