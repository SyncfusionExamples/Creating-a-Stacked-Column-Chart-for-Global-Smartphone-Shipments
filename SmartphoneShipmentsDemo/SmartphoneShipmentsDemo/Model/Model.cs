namespace SmartphoneShipmentsDemo
{

    public class Model
    {
        public string BrandName { get; set; }

        public double Quarter1 { get; set; }

        public double Quarter2 { get; set; }

        public double Quarter3 { get; set; }

        public double Quarter4 { get; set; }

        public double MarketShare { get; set; }

        public Model(string brandName,double q1, double q2, double q3, double q4, double marketShare)
        {
            BrandName = brandName;
            Quarter1 = q1;
            Quarter2 = q2;
            Quarter3 = q3;
            Quarter4 = q4;
            MarketShare = marketShare;
        }
    }
}
