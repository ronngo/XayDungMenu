namespace XayDungMenu
{
    internal class ChuviDientich
    {
        public double cd {get; set;}
        public double cr {get; set;}
        public double a {get; set;}
        public double r {get; set;}
        public double pi {get; set;}

        public ChuviDientich(double cd = 1, double cr = 1, double a = 1, double r = 1, double pi = 3.14)
        {
            this.cd = cd;
            this.cr = cr;
            this.a = a;
            this.r = r;
            this.pi = pi;
        }
        public double dtHCN()
        {
            return cd * cr;
        }

        public double cvHCN()
        {
            return (cd + cr) * 2;
        }

        public double dtHV()
        {
            return a * a;
        }

        public double cvHV()
        {
            return a * 4;
        }

        public double dtHT()
        {
            return r * r * pi;
        }

        public double cvHT()
        {
            return 2 * r * pi;
        }
    }
}
