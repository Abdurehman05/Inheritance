namespace Inheritance
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        void RefuelTank();
    }
}