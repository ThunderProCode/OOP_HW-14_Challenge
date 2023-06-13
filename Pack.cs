namespace Challenge
{
    class Pack
    {
        private InventoryItem[] items;
        private int itemCount;
        private double currentWeight;
        private double currentVolume;

        public int MaxItemCount { get; }
        public double MaxWeight { get; }
        public double MaxVolume { get; }

        public int ItemCount => itemCount;
        public double CurrentWeight => currentWeight;
        public double CurrentVolume => currentVolume;

        public Pack(int maxItemCount, double maxWeight, double maxVolume)
        {
            MaxItemCount = maxItemCount;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            items = new InventoryItem[maxItemCount];
        }

        public bool Add(InventoryItem item)
        {
            if (itemCount >= MaxItemCount || currentWeight + item.Weight > MaxWeight || currentVolume + item.Volume > MaxVolume)
            {
                return false;
            }

            items[itemCount] = item;
            itemCount++;
            currentWeight += item.Weight;
            currentVolume += item.Volume;
            return true;
        }
    }
}