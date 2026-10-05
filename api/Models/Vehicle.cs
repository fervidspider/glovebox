using Glovebox.api.Models;
    

namespace Glovebox.api.Models
{
    public class Vehicle
    {
        public required Guid Id { get; set; }

        // Identity

        public string Nickname { get; set; } = "My Vehicle";
        public VehicleType Type { get; set; }
        public required string Make { get; set; }
        public required string Model { get; set; }
        public int Year { get; set; }
        public string? Trim { get; set; }
        public string? Vin { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Color { get; set; }

        // Specifications

        public FuelType FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public string? Engine { get; set; }
        public string? OilType { get; set; }
        public string? TireSize { get; set; }

        // Ownership

        public DateOnly? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public DateOnly? SoldDate { get; set; }
        public decimal? SoldPrice { get; set; }

    }

}