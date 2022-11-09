namespace MyCoinChange
{
    public class ChangeCoinService : IChangeCoinService
    {
        public Change OptimalChange(long monney)
        {
            if (monney < 2) return null;

            Change change = new Change(0,0,0);
            
            if(monney%10!=0 && monney%5!=0) 
            { 
                do
                {
                    monney = monney - 2;
                    change.Coin2 += 1;

                } while (monney> 0 && monney%5!=0 );
            }
            if (monney >0)
            {
                change.Bill10 = (monney/10);
                monney = monney - (change.Bill10 * 10);
            }
            if (monney > 0)
            {
                change.Bill5 = (monney / 5);
                monney = monney - (change.Bill5 * 5);
            }
            return change;
        }
    }
}
