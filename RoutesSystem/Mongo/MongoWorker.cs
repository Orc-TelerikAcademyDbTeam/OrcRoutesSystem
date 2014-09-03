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

<<<<<<< HEAD
=======
        public MongoWorker(string connectionString)
        {
            this.data = new MongoData(connectionString, "RoutesSystem");
        }

>>>>>>> 7d32d474108086435070cb1d0bf8f277a90d99e8
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
<<<<<<< HEAD
                    new MongoModel() { FuelConsumption = 26.5f, Name = "Avensis", NumberOfWheels = 4 });
                this.data.VehicleModels.Insert(
=======
>>>>>>> 7d32d474108086435070cb1d0bf8f277a90d99e8
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
                            VehicleId = 1,
                            Driver = new MongoDriver()
                            {
                                FirstName = "Peter",
                                MiddleName = "Petrov",
                                LastName = "Petrov"
                            },
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
                            VehicleId = 2,
                            Driver = new MongoDriver()
                            {
                                FirstName = "Yaro",
                                MiddleName = "Berov",
                                LastName = "Penov"
                            },
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
                            VehicleId = 3,
                            Driver = new MongoDriver()
                            {
                                FirstName = "Martin",
                                MiddleName = "Vaklinov",
                                LastName = "Vaklinov"
                            },
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
                        VehicleId = 4,
                        Driver = new MongoDriver()
                        {
                            FirstName = "Cristiano",
                            MiddleName = "",
                            LastName = "Ronaldo"
                        },
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
                        VehicleId = 5,
                        Driver = new MongoDriver()
                        {
                            FirstName = "Gergi",
                            MiddleName = "Georgiev",
                            LastName = "Georgiev"
                        },
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
                        VehicleId = 6,
                        Driver = new MongoDriver()
                        {
                            FirstName = "Ognqn",
                            MiddleName = "",
                            LastName = "Jelezov"
                        },
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
                        VehicleId = 7,
                        Driver = new MongoDriver()
                        {
                            FirstName = "Mitko",
                            MiddleName = "Mitev",
                            LastName = "Mitev"
                        },
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
                        VehicleId = 8,
                        Driver = new MongoDriver()
                        {
                            FirstName = "Lalka",
                            MiddleName = "Asenova",
                            LastName = "Paralingova"
                        },
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
                        VehicleId = 9,
                        Driver = new MongoDriver()
                        {
                            FirstName = "Zlatka",
                            MiddleName = "Cherna",
                            LastName = "Chernata"
                        },
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
                       VehicleId = 10,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Zagore",
                           MiddleName = "Toshev",
                           LastName = "Peshev"
                       },
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
                       VehicleId = 11,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Marti",
                           MiddleName = "K",
                           LastName = "Lambova"
                       },
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
                       VehicleId = 12,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Dimitrichka",
                           MiddleName = "Hah",
                           LastName = "Budurova"
                       },
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
                       VehicleId = 13,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Hinka",
                           MiddleName = "Hulk",
                           LastName = "Hinkova"
                       },
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
                       VehicleId = 14,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Urus",
                           MiddleName = "Urugvai",
                           LastName = "Hapeshtiq"
                       },
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
                       VehicleId = 15,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Luiz",
                           MiddleName = "Shark",
                           LastName = "Suarez"
                       },
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
                       VehicleId = 16,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Toshko",
                           MiddleName = "Tosheta",
                           LastName = "Toshev"
                       },
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
                       VehicleId = 17,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Ventilator",
                           MiddleName = "Klimatikov",
                           LastName = "Aspartamov"
                       },
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
                       VehicleId = 18,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Petiletka",
                           MiddleName = "Venelinova",
                           LastName = "Paleva"
                       },
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
                       VehicleId = 19,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Razvigor",
                           MiddleName = "Kornishonov",
                           LastName = "Shtaigov"
                       },
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
                       VehicleId = 20,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Helikopter",
                           MiddleName = "Petrov",
                           LastName = "Petrov"
                       },
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
                       VehicleId = 21,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Joro",
                           MiddleName = "Kolumbieca",
                           LastName = "Smaglata"
                       },
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
                       VehicleId = 22,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Harry",
                           MiddleName = "J",
                           LastName = "Potter"
                       },
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
                       VehicleId = 23,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Adolf",
                           MiddleName = "Funky",
                           LastName = "Shperplatov"
                       },
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
                       VehicleId = 24,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Enq",
                           MiddleName = "Nanq",
                           LastName = "Noniva"
                       },
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
                       VehicleId = 25,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Cvetelina",
                           MiddleName = "P",
                           LastName = "Cecova"
                       },
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
                       VehicleId = 26,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Lora",
                           MiddleName = "O",
                           LastName = "Karadjova"
                       },
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
                       VehicleId = 27,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Magdalena",
                           MiddleName = "Maleeva",
                           LastName = "Maleeva"
                       },
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
                       VehicleId = 28,
                       Driver = new MongoDriver()
                       {
                           FirstName = "Stefka",
                           MiddleName = "Preskachastata",
                           LastName = "Kostadinova"
                       },
                       FuelType = this.data.FuelTypes.SearchFor(x => x.Name == "Benzine A-0").First(),
                       Manufacturer = this.data.Manufacturers.SearchFor(x => x.Name == "Scania").First(),
                       Model = this.data.VehicleModels.SearchFor(x => x.Name == "K124EB").First(),
                       VehicleType =
                           this.data.VehicleTypes.SearchFor(x => x.Name == "Bus").First(),
                       YearOfManifacturer = new DateTime(2008, 9, 17)
                   });
            }

            if (!this.data.Routes.All().Any())
            {
                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 1,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Sofia").First(),
                    Distance = 500
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 2,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Burgas").First(),
                    Distance = 156
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 3,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Sofia").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Burgas").First(),
                    Distance = 335.5f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 4,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Pleven").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Lovech").First(),
                    Distance = 132.9f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 5,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Plovdiv").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Shumen").First(),
                    Distance = 250
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 6,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Montana").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Sliven").First(),
                    Distance = 390
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 7,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Blagoevgrad").First(),
                    Distance = 65.4f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 8,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Shumen").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    Distance = 89.9f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 9,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "St.Zagora").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Maluk Porovec").First(),
                    Distance = 247.6f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 10,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Vraca").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Montana").First(),
                    Distance = 44
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 11,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Burgas").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Plovdiv").First(),
                    Distance = 162
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 12,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Lovech").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Sliven").First(),
                    Distance = 244
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 13,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Sofia").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    Distance = 96.2f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 14,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Vraca").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "St.Zagora").First(),
                    Distance = 233.5f
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 15,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Varna").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    Distance = 510
                });

                this.data.Routes.Insert(new MongoRoute()
                {
                    RouteId = 16,
                    StartTown = this.data.Towns.SearchFor(x => x.Name == "Pernik").First(),
                    EndTown = this.data.Towns.SearchFor(x => x.Name == "Maluk Porovec").First(),
                    Distance = 9090.31f
                });
            }

            if (!this.data.VehicleRoutes.All().Any())
            {
                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 1,
                    Date = new DateTime(2013, 1, 1)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 2,
                    Date = new DateTime(2013, 1, 1)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 3,
                    Date = new DateTime(2013, 1, 2)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 4,
                    Date = new DateTime(2013, 1, 3)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 5,
                    Date = new DateTime(2013, 1, 4)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 6,
                    Date = new DateTime(2013, 1, 5)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 7,
                    Date = new DateTime(2013, 1, 6)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 2,
                    VehicleId = 8,
                    Date = new DateTime(2013, 2, 2)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 2,
                    VehicleId = 9,
                    Date = new DateTime(2013, 3, 3)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 2,
                    VehicleId = 10,
                    Date = new DateTime(2014, 4, 2)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 3,
                    VehicleId = 11,
                    Date = new DateTime(2014, 5, 22)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 3,
                    VehicleId = 12,
                    Date = new DateTime(2014, 5, 22)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 3,
                    VehicleId = 13,
                    Date = new DateTime(2014, 6, 10)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 3,
                    VehicleId = 14,
                    Date = new DateTime(2014, 7, 19)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 4,
                    VehicleId = 15,
                    Date = new DateTime(2014, 8, 20)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 4,
                    VehicleId = 16,
                    Date = new DateTime(2014, 2, 11)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 3,
                    VehicleId = 17,
                    Date = new DateTime(2014, 3, 12)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 5,
                    VehicleId = 18,
                    Date = new DateTime(2014, 4, 13)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 6,
                    VehicleId = 19,
                    Date = new DateTime(2014, 9, 25)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 6,
                    VehicleId = 20,
                    Date = new DateTime(2014, 10, 26)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 7,
                    VehicleId = 21,
                    Date = new DateTime(2014, 11, 13)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 8,
                    VehicleId = 22,
                    Date = new DateTime(2014, 2, 14)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 9,
                    VehicleId = 23,
                    Date = new DateTime(2014, 3, 15)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 9,
                    VehicleId = 24,
                    Date = new DateTime(2013, 12, 5)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 10,
                    VehicleId = 25,
                    Date = new DateTime(2014, 12, 6)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 11,
                    VehicleId = 26,
                    Date = new DateTime(2014, 12, 25)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 12,
                    VehicleId = 26,
                    Date = new DateTime(2013, 1, 29)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 13,
                    VehicleId = 27,
                    Date = new DateTime(2012, 6, 21)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 13,
                    VehicleId = 28,
                    Date = new DateTime(2014, 7, 22)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 14,
                    VehicleId = 1,
                    Date = new DateTime(2014, 3, 3)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 14,
                    VehicleId = 2,
                    Date = new DateTime(2014, 3, 9)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 15,
                    VehicleId = 3,
                    Date = new DateTime(2014, 3, 10)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 15,
                    VehicleId = 4,
                    Date = new DateTime(2014, 3, 12)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 16,
                    VehicleId = 5,
                    Date = new DateTime(2014, 3, 15)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 16,
                    VehicleId = 6,
                    Date = new DateTime(2014, 4, 18)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 1,
                    VehicleId = 28,
                    Date = new DateTime(2014, 5, 21)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 2,
                    VehicleId = 27,
                    Date = new DateTime(2014, 5, 23)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 3,
                    VehicleId = 26,
                    Date = new DateTime(2014, 5, 25)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 4,
                    VehicleId = 25,
                    Date = new DateTime(2014, 5, 27)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 5,
                    VehicleId = 24,
                    Date = new DateTime(2014, 6, 28)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 6,
                    VehicleId = 23,
                    Date = new DateTime(2014, 6, 30)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 7,
                    VehicleId = 22,
                    Date = new DateTime(2014, 6, 1)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 8,
                    VehicleId = 21,
                    Date = new DateTime(2014, 6, 2)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 8,
                    VehicleId = 19,
                    Date = new DateTime(2014, 6, 3)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 9,
                    VehicleId = 18,
                    Date = new DateTime(2014, 6, 5)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 10,
                    VehicleId = 17,
                    Date = new DateTime(2014, 7, 7)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 11,
                    VehicleId = 16,
                    Date = new DateTime(2014, 7, 9)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 12,
                    VehicleId = 15,
                    Date = new DateTime(2014, 7, 11)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 13,
                    VehicleId = 14,
                    Date = new DateTime(2014, 7, 13)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 14,
                    VehicleId = 14,
                    Date = new DateTime(2014, 7, 15)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 15,
                    VehicleId = 15,
                    Date = new DateTime(2014, 7, 17)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 10,
                    VehicleId = 10,
                    Date = new DateTime(2014, 7, 19)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 9,
                    VehicleId = 9,
                    Date = new DateTime(2014, 7, 21)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 8,
                    VehicleId = 8,
                    Date = new DateTime(2014, 8, 23)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 7,
                    VehicleId = 7,
                    Date = new DateTime(2014, 8, 25)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 6,
                    VehicleId = 6,
                    Date = new DateTime(2014, 8, 27)
                });

                this.data.VehicleRoutes.Insert(new MongoVehicleRoute()
                {
                    RouteId = 16,
                    VehicleId = 27,
                    Date = new DateTime(2014, 9, 29)
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

        public IQueryable<MongoRoute> GetAllRoutes()
        {
            return this.data.Routes.All();
        }

        public IQueryable<MongoVehicleRoute> GetAllVehicleRoutes()
        {
            return this.data.VehicleRoutes.All();
        }
    }
}