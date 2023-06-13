namespace Challenge
{
    class InventoryItem
    {
        public double Weight { get; }
        public double Volume { get; }

        public InventoryItem(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }

    class Arrow : InventoryItem
    {
        public Arrow() : base(0.1, 0.05) { }
    }

    class Bow : InventoryItem
    {
        public Bow() : base(1, 4) { }
    }

    class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5) { }
    }

    class Water : InventoryItem
    {
        public Water() : base(2, 3) { }
    }

    class FoodRations : InventoryItem
    {
        public FoodRations() : base(1, 0.5) { }
    }

    class Sword : InventoryItem
    {
        public Sword() : base(5, 3) { }
    }
}