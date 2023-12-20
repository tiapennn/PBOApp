namespace BMIChecking
{
    public class BMI
    {
        private double mass;
        private double meter;

        public BMI(double mass, double meter)
        {
            this.mass = mass;
            this.meter = meter;

        }
        public double computeBMI()
        {
            double BMI = mass / (meter * meter / 10000);
            return BMI;
        }
        
        public BMI()
        {
            mass = 0;
            meter = 0;

        }
        
    }
}