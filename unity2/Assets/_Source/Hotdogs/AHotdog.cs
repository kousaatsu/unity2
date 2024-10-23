using UnityEngine;

namespace Hotdog
{
    public abstract class AHotdog
    {
        private readonly string _name;
        private readonly int _weight;
        private readonly int _cost;

        public Hotdog(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public string GetName() => _name;
        public int GetWeight() => _weight;
        public abstract int GetCost();
    }
    public abstract class AHotdogDecorator: AHotdog
    {
        protected AHotdog _hotdog;
        
        public HotdogDecorator(string name, int weight, AHotdog hotdog) : base(name,weight)
        {
            _hotdog = hotdog;
        }
    }
    public class HotdogCesar : AHotdog
    {
        public HotdogCesar(string name, int weight) : base(name,weight) { }

        public override int GetCost()
        {
            return 290;
        }
    }
    public class HotdogClassic : AHotdog
    {
        public HotdogClassic(string name, int weight) : base(name, weight) { }

        public override int GetCost()
        {
            return 210;
        }
    }
    public class HotdogMeat : AHotdog
    {
        public HotdogMeat(string name, int weight) : base(name,weight) { }

        public override int GetCost()
        {
            return 290;
        }
    }
    public class HotdogWithCucumber: AHotdogDecorator
    {
        public HotdogWithCucumber(string name, int weight, AHotdog hotdog) : base(name, weight,hotdog) { }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 50;
        }
    }
    public class HotdogWithOnion: AHotdogDecorator
    {
        public HotdogWithOnion(string name, int weight, AHotdog hotdog) : base(name, weight,hotdog) { }

        public override int GetCost()
        {
            return _hotdog.GetCost() + 30;
        }
    }
}