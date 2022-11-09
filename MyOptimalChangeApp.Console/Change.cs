using System.Drawing;

namespace MyCoinChange
{
    public class Change
    {
        
            public long Coin2 { get; set; }
            public long Bill5 { get; set; }
            public long Bill10 { get; set; }
        public Change(long coin2, long bill5, long bill10)
        {
            Coin2 = coin2;
            Bill5 = bill5;
            Bill10 = bill10;
        }
    }
}
