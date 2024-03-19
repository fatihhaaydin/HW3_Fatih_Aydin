namespace HW3_Fatih_Aydın.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string? Car_plate { get; set; }
        public float? Km { get; set; }
        public int? Model { get; set; }
        public string? Color { get; set; }
        public string? Gear_type { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
    }
}
