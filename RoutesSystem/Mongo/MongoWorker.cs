namespace Mongo
{
    using System;
    using System.Linq;

    using RoutesSystem.Data;
    using RoutesSystem.Model;
    using RoutesSystem.Model.MongoDBModels;
    using RoutesSystem.Model.SQLServerModels;

    public class MongoWorker
    {
        private MongoData data;

        public MongoWorker()
        {
            this.data = new MongoData();
            this.Populate();
        }

        private void Populate()
        {
            if (!this.data.Manufacturers.All().Any())
            {
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Toyota" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "BMW" });

                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Audi" });
            }

            if (!this.data.Towns.All().Any())
            {
                this.data.Towns.Insert(new MongoTown() { Name = "Vraca" });
                this.data.Towns.Insert(new MongoTown() { Name = "Maluk Porovec" });

                this.data.Towns.Insert(new MongoTown() { Name = "Burgas" });
            }

            if (!this.data.VehicleTypes.All().Any())
            {
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Sedan" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Coupe" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Limousine" });
            }

            if (!this.data.FuelTypes.All().Any())
            {
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Diesel" });
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Benzine" });
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Methane" });
            }

            if (!this.data.VehicleModels.All().Any())
            {
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 8.5f, Name = "R8", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 5.5f, Name = "M7", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 4.0f, Name = "Avensis", NumberOfWheels = 4 });
            }

            if (!this.data.Vehicles.All().Any())
            {
                this.data.Vehicles.Insert(
                    new MongoVehicle()
                        {
                            FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine").First(),
                            Manufacturer =
                                this.data.Manufacturers.SearchFor(x => x.Name == "Toyota").First(),
                            Model = this.data.VehicleModels.SearchFor(x => x.Name == "Avensis").First(),
                            VehicleType =
                                this.data.VehicleTypes.SearchFor(x => x.Name == "Limousine").First(),
                            YearOfManifacturer = new DateTime(2012, 1, 1)
                        });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                        {
                            FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Diesel").First(),
                            Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Audi").First(),
                            Model = this.data.VehicleModels.SearchFor(x => x.Name == "R8").First(),
                            VehicleType =
                                this.data.VehicleTypes.SearchFor(x => x.Name == "Limousine").First(),
                            YearOfManifacturer = new DateTime(2012, 1, 1)
                        });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                        {
                            FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Diesel").First(),
                            Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "BMW").First(),
                            Model = this.data.VehicleModels.SearchFor(x => x.Name == "M7").First(),
                            VehicleType =
                                this.data.VehicleTypes.SearchFor(x => x.Name == "Limousine").First(),
                            YearOfManifacturer = new DateTime(2012, 1, 1)
                        });
            }
        }

        public IQueryable<MongoTown> GetAllTowns()
        {
            return this.data.Towns.All();
        }

        public IQueryable<MongoManufacturer> GetAllManufacturers()
        {
            return this.data.Manufacturers.All();
        }

        public IQueryable<MongoVehicleType> GetAllVehicleTypes()
        {
            return this.data.VehicleTypes.All();
        }

        public IQueryable<MongoFuelType> GetAllFuelTypes()
        {
            return this.data.FuelTypes.All();
        }

        public IQueryable<MongoVehicle> GetAllVehicles()
        {
            return this.data.Vehicles.All();
        }

        public IQueryable<MongoModel> GetAllModels()
        {
            return this.data.VehicleModels.All();
        }
    }
}