using Data.Models;

namespace Data.EntryData
{
    internal class BrandsEntryDataProvider : IEntryDataProvider<Brand>
    {
        public Brand[] Data { get; } = new Brand[] {
            new Brand { Id = 1, Name = "Seat" },
            new Brand { Id = 2, Name = "Renault" },
            new Brand { Id = 3, Name = "Peugeot" },
            new Brand { Id = 4, Name = "Dacia" },
            new Brand { Id = 5, Name = "Citroën" },
            new Brand { Id = 6, Name = "Opel" },
            new Brand { Id = 7, Name = "Alfa Romeo" },
            new Brand { Id = 8, Name = "Škoda" },
            new Brand { Id = 9, Name = "Chevrolet" },
            new Brand { Id = 10, Name = "Porsche" },
            new Brand { Id = 11, Name = "Honda" },
            new Brand { Id = 12, Name = "Subaru" },
            new Brand { Id = 13, Name = "Mazda" },
            new Brand { Id = 14, Name = "Mitsubishi" },
            new Brand { Id = 15, Name = "Lexus" },
            new Brand { Id = 16, Name = "Toyota" },
            new Brand { Id = 17, Name = "BMW" },
            new Brand { Id = 18, Name = "Volkswagen" },
            new Brand { Id = 19, Name = "Suzuki" },
            new Brand { Id = 20, Name = "Mercedes-Benz" },
            new Brand { Id = 21, Name = "Saab" },
            new Brand { Id = 22, Name = "Audi" },
            new Brand { Id = 23, Name = "Kia" },
            new Brand { Id = 24, Name = "Land Rover" },
            new Brand { Id = 25, Name = "Dodge" },
            new Brand { Id = 26, Name = "Chrysler" },
            new Brand { Id = 27, Name = "Ford" },
            new Brand { Id = 28, Name = "Hummer" },
            new Brand { Id = 29, Name = "Hyundai" },
            new Brand { Id = 30, Name = "Infiniti" },
            new Brand { Id = 31, Name = "Jaguar" },
            new Brand { Id = 32, Name = "Jeep" },
            new Brand { Id = 33, Name = "Nissan" },
            new Brand { Id = 34, Name = "Volvo" },
            new Brand { Id = 35, Name = "Daewoo" },
            new Brand { Id = 36, Name = "Fiat" },
            new Brand { Id = 37, Name = "Mini" },
            new Brand { Id = 38, Name = "Rover" },
            new Brand { Id = 39, Name = "Smart" }
        };
    }
}
