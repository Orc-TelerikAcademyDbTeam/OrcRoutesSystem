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
                this.data.Towns.Insert(new MongoTown() { Name = "Pernik" });
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

            if (!this.data.Drivers.All().Any())
            {
                this.data.Drivers.Insert(new MongoDriver() 
                { 
                    DriverID = "1",
                    FirstName = "Peter",
                    MiddleName = "Petrov",
                    LastName = "Petrov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "2",
                    FirstName = "Yaro",
                    MiddleName = "Berov",
                    LastName = "Penov"
                });


                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "3",
                    FirstName = "Martin",
                    MiddleName = "Vaklinov",
                    LastName = "Vaklinov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "4",
                    FirstName = "Cristiano",
                    MiddleName = "",
                    LastName = "Ronaldo"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "5",
                    FirstName = "Gergi",
                    MiddleName = "Georgiev",
                    LastName = "Georgiev"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "6",
                    FirstName = "Ognqn",
                    MiddleName = "",
                    LastName = "Jelezov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "7",
                    FirstName = "Mitko",
                    MiddleName = "Mitev",
                    LastName = "Mitev"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "8",
                    FirstName = "Lalka",
                    MiddleName = "Asenova",
                    LastName = "Paralingova"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "9",
                    FirstName = "Zlatka",
                    MiddleName = "Cherna",
                    LastName = "Chernata"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "10",
                    FirstName = "Zagore",
                    MiddleName = "Toshev",
                    LastName = "Peshev"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "11",
                    FirstName = "Marti",
                    MiddleName = "K",
                    LastName = "Lambova"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "12",
                    FirstName = "Dimitrichka",
                    MiddleName = "Hah",
                    LastName = "Budurova"
                });


                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "13",
                    FirstName = "Hinka",
                    MiddleName = "Hulk",
                    LastName = "Hinkova"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "14",
                    FirstName = "Urus",
                    MiddleName = "Urugvai",
                    LastName = "Hapeshtiq"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "15",
                    FirstName = "Luiz",
                    MiddleName = "Shark",
                    LastName = "Suarez"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "16",
                    FirstName = "Toshko",
                    MiddleName = "Tosheta",
                    LastName = "Toshev"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "17",
                    FirstName = "Ventilator",
                    MiddleName = "Klimatikov",
                    LastName = "Aspartamov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "18",
                    FirstName = "Petiletka",
                    MiddleName = "Venelinova",
                    LastName = "Paleva"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "19",
                    FirstName = "Razvigor",
                    MiddleName = "Kornishonov",
                    LastName = "Shtaigov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "20",
                    FirstName = "Helikopter",
                    MiddleName = "Petrov",
                    LastName = "Petrov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "21",
                    FirstName = "Joro",
                    MiddleName = "Kolumbieca",
                    LastName = "Smaglata"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "22",
                    FirstName = "Harry",
                    MiddleName = "J",
                    LastName = "Potter"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "23",
                    FirstName = "Adolf",
                    MiddleName = "Funky",
                    LastName = "Shperplatov"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "24",
                    FirstName = "Enq",
                    MiddleName = "Nanq",
                    LastName = "Noniva"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "25",
                    FirstName = "Cvetelina",
                    MiddleName = "P",
                    LastName = "Cecova"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "26",
                    FirstName = "Lora",
                    MiddleName = "O",
                    LastName = "Karadjova"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "27",
                    FirstName = "Magdalena",
                    MiddleName = "Maleeva",
                    LastName = "Maleeva"
                });

                this.data.Drivers.Insert(new MongoDriver()
                {
                    DriverID = "28",
                    FirstName = "Stefka",
                    MiddleName = "Preskachastata",
                    LastName = "Kostadinova"
                });
            }

            if (!this.data.Routes.All().Any())
            {
                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Sofia").First(),
                    Distance = 500
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Burgas").First(),
                    Distance = 156
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Sofia").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Burgas").First(),
                    Distance = 335.5f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Pleven").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Lovech").First(),
                    Distance = 132.9f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Plovdiv").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Shumen").First(),
                    Distance = 250
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Montana").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Sliven").First(),
                    Distance = 390
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Blagoevgrad").First(),
                    Distance = 65.4f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Shumen").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    Distance = 89.9f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "St.Zagora").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Maluk Porovec").First(),
                    Distance = 247.6f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Vraca").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Montana").First(),
                    Distance = 44
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Burgas").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Plovdiv").First(),
                    Distance = 162
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Lovech").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Sliven").First(),
                    Distance = 244
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Sofia").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    Distance = 96.2f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Vraca").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "St.Zagora").First(),
                    Distance = 233.5f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    Distance = 510
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Maluk Porovec").First(),
                    Distance = 9090.31f
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