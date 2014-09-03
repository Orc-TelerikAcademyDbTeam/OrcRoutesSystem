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
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Mercedes" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Audi" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Lada" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Opel" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Wolkswagen" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Fiat" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Seat" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "GreatWall" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Chevy" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Harley-Davidson" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Suzuki" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Honda" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Chavdar" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Iveco" });
                this.data.Manufacturers.Insert(new MongoManufacturer() { Name = "Scania" });
            }

            if (!this.data.Towns.All().Any())
            {
                this.data.Towns.Insert(new MongoTown() { Name = "Vraca" });
                this.data.Towns.Insert(new MongoTown() { Name = "Maluk Porovec" });
                this.data.Towns.Insert(new MongoTown() { Name = "Sofia" });
                this.data.Towns.Insert(new MongoTown() { Name = "Burgas" });
                this.data.Towns.Insert(new MongoTown() { Name = "Varna" });
                this.data.Towns.Insert(new MongoTown() { Name = "Plovdiv" });
                this.data.Towns.Insert(new MongoTown() { Name = "Montana" });
                this.data.Towns.Insert(new MongoTown() { Name = "Shumen" });
                this.data.Towns.Insert(new MongoTown() { Name = "Lovech" });
                this.data.Towns.Insert(new MongoTown() { Name = "Pleven" });
                this.data.Towns.Insert(new MongoTown() { Name = "St.Zagora" });
                this.data.Towns.Insert(new MongoTown() { Name = "Sliven" });
                this.data.Towns.Insert(new MongoTown() { Name = "Blagoevgrad" });
                this.data.Towns.Insert(new MongoTown() { Name = "Perniks" });
            }

            if (!this.data.VehicleTypes.All().Any())
            {
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Bus" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Sedan" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Coupe" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Limousine" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "TIR" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Motor-Cycle" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "Buggy" });
                this.data.VehicleTypes.Insert(new MongoVehicleType() { Name = "MicroBus" });
            }

            if (!this.data.FuelTypes.All().Any())
            {
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Diesel" });
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Benzine A-10" });
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Methane" });
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Benzine A-5" });
                this.data.FuelTypes.Insert(new MongoFuelType() { Name = "Benzine A-0" });
            }

            if (!this.data.VehicleModels.All().Any())
            {
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 8.5f, Name = "R8", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 5.5f, Name = "M7", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 12.3f, Name = "X5", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 15.0f, Name = "C100", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 13.0f, Name = "SLK", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 20.0f, Name = "1600", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 6.6f, Name = "Vectra", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 5.4f, Name = "Golf", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 3.7f, Name = "Novo", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 3.7f, Name = "Umbro", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 11.0f, Name = "555", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 22.0f, Name = "Curvet", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 19.0f, Name = "2200", NumberOfWheels = 2 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 12.0f, Name = "Hayabusa", NumberOfWheels = 2 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 5.0f, Name = "VS1400", NumberOfWheels = 2 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 4.0f, Name = "Civic", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 2.3f, Name = "SuperCub", NumberOfWheels = 2 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 50.0f, Name = "141", NumberOfWheels = 6 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 39.0f, Name = "11M3", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 63.2f, Name = "Stralis", NumberOfWheels = 6 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 49.89f, Name = "Traker", NumberOfWheels = 6 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 32.0f, Name = "Daily", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 26.0f, Name = "DailyVan", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 23.0f, Name = "R470", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 43.0f, Name = "R500", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
                    new MongoModel() { FuelConsumption = 35.0f, Name = "K124EB", NumberOfWheels = 4 });
            }

            if (!this.data.Vehicles.All().Any())
            {
                this.data.Vehicles.Insert(
                    new MongoVehicle()
                        {
                            FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
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

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                    {
                        FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
                        Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Mercedes").First(),
                        Model = this.data.VehicleModels.SearchFor(x => x.Name == "C100").First(),
                        VehicleType =
                            this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                        YearOfManifacturer = new DateTime(2006, 2, 6)
                    });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                    {
                        FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Diesel").First(),
                        Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Mercedes").First(),
                        Model = this.data.VehicleModels.SearchFor(x => x.Name == "SLK").First(),
                        VehicleType =
                            this.data.VehicleTypes.SearchFor(x => x.Name == "Coupe").First(),
                        YearOfManifacturer = new DateTime(2010, 6, 2)
                    });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                    {
                        FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                        Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Lada").First(),
                        Model = this.data.VehicleModels.SearchFor(x => x.Name == "1600").First(),
                        VehicleType =
                            this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                        YearOfManifacturer = new DateTime(2012, 1, 1)
                    });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                    {
                        FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                        Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "BMW").First(),
                        Model = this.data.VehicleModels.SearchFor(x => x.Name == "X5").First(),
                        VehicleType =
                            this.data.VehicleTypes.SearchFor(x => x.Name == "Coupe").First(),
                        YearOfManifacturer = new DateTime(2014, 12, 12)
                    });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                    {
                        FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Diesel").First(),
                        Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Opel").First(),
                        Model = this.data.VehicleModels.SearchFor(x => x.Name == "Vectra").First(),
                        VehicleType =
                            this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                        YearOfManifacturer = new DateTime(2001, 10, 9)
                    });

                this.data.Vehicles.Insert(
                    new MongoVehicle()
                    {
                        FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                        Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Wolkswagen").First(),
                        Model = this.data.VehicleModels.SearchFor(x => x.Name == "Golf").First(),
                        VehicleType =
                            this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                        YearOfManifacturer = new DateTime(1989, 3, 3)
                    });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Wolkswagen").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Golf").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                       YearOfManifacturer = new DateTime(1989, 3, 3)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Methane").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Fiat").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Novo").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                       YearOfManifacturer = new DateTime(1999, 8, 11)
                   });


                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Methane").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Seat").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Umbro").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Coupe").First(),
                       YearOfManifacturer = new DateTime(1999, 2, 2)
                   });


                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Methane").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "GreatWall").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "555").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Limousine").First(),
                       YearOfManifacturer = new DateTime(2013, 5, 5)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Chevy").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Curvet").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Limousine").First(),
                       YearOfManifacturer = new DateTime(2014, 6, 6)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Harley-Davidson").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "2200").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Motor-Cycle").First(),
                       YearOfManifacturer = new DateTime(1950, 7, 7)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Suzuki").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Hayabusa").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Motor-Cycle").First(),
                       YearOfManifacturer = new DateTime(1999, 7, 7)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Suzuki").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "VS1400").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Motor-Cycle").First(),
                       YearOfManifacturer = new DateTime(2001, 7, 8)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Honda").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Civic").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Sedan").First(),
                       YearOfManifacturer = new DateTime(2005, 8, 8)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Honda").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "SuperCub").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Motor-Cycle").First(),
                       YearOfManifacturer = new DateTime(2004, 9, 8)
                   });


                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Chavdar").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "141").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Bus").First(),
                       YearOfManifacturer = new DateTime(1945, 12, 11)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Chavdar").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "11M3").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Bus").First(),
                       YearOfManifacturer = new DateTime(1946, 9, 8)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Iveco").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Stralis").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "TIR").First(),
                       YearOfManifacturer = new DateTime(2002, 10, 10)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-10").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Iveco").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Traker").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "TIR").First(),
                       YearOfManifacturer = new DateTime(1999, 12, 1)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-5").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Iveco").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "Daily").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "MicroBus").First(),
                       YearOfManifacturer = new DateTime(2012, 12, 20)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Iveco").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "DailyVan").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "MicroBus").First(),
                       YearOfManifacturer = new DateTime(2010, 3, 26)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Scania").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "R470").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "TIR").First(),
                       YearOfManifacturer = new DateTime(2012, 3, 19)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Scania").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "R500").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "TIR").First(),
                       YearOfManifacturer = new DateTime(2007, 3, 29)
                   });

                this.data.Vehicles.Insert(
                   new MongoVehicle()
                   {
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Scania").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "K124EB").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Bus").First(),
                       YearOfManifacturer = new DateTime(2008, 9, 17)
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