namespace objecttest
{
    public class product
    {
        string productId;
        int stock;
        double StarRateing;

        public void SetDefaultValues()
        {
            productId = "1";
            stock = 0;
            StarRateing = 5;
        }

        public override string ToString()
        {
            return "product " + productId + ", " + stock + " in stock, "
                + StarRateing + " star rateing";
        }

        public void SetValues(string id, int quantity, double rateing)
        {
            productId = id;
            stock = quantity;
            StarRateing = rateing;
        }
    }
}