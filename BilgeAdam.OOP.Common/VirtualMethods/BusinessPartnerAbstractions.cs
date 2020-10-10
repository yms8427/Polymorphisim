namespace BilgeAdam.OOP.Common
{
    public abstract partial class BusinessPartner
    {
        public abstract decimal Commision { get; }
        public virtual decimal GetTotalAmount(decimal price)
        {
            return price * (1 - Commision);
        }
    }
}
