namespace MySQL
{
    using System.Collections.Generic;
    using Telerik.OpenAccess.Metadata;
    using Telerik.OpenAccess.Metadata.Fluent;

    public partial class FluentModelMetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configurations = new List<MappingConfiguration>();

            var customerMapping = new MappingConfiguration<VehicleInformation>();
            customerMapping.MapType(k => new
            {
                VehicleID = k.VehicleID,
                VehicleType = k.VehicleType,
                Manufactorer = k.Manufactorer,
                VehicleModel = k.VehicleModel,
                FuelType = k.FuelType,
                DriverFirstName = k.DriverFirstName,
                DriverLastName = k.DriverLastName
            }).ToTable("VehicleInformation");
            customerMapping.HasProperty(c => c.VehicleID).IsIdentity();

            configurations.Add(customerMapping);

            return configurations;
        }

        protected override void SetContainerSettings(MetadataContainer container)
        {
            container.Name = "FluentModel";
            container.DefaultNamespace = "MySQL";
            container.NameGenerator.SourceStrategy = Telerik.OpenAccess.Metadata.NamingSourceStrategy.Property;
            container.NameGenerator.RemoveCamelCase = false;
        }
    }
}