namespace BilgeAdam.OOP.Common
{
    public partial class BilgeAdam : BusinessPartner
    {
        public override decimal Commision { get { return 0.04M; } }

        public override decimal GetTotalAmount(decimal price)
        {
            return base.GetTotalAmount(price) - 100;
        }
    }

    public class Meteksan : BusinessPartner
    {
        public override decimal Commision { get { return 0.02M; } }
    }

    public class Tepe : BusinessPartner
    {
        public override decimal Commision { get { return 0; } }
    }
}
