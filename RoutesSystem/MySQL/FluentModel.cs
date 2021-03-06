namespace MySQL
{
    using System.Linq;
    using Telerik.OpenAccess;
    using Telerik.OpenAccess.Metadata;

    public interface IFluentModelUnitOfWork : IUnitOfWork
    {
    }

    public partial class FluentModel : OpenAccessContext, IFluentModelUnitOfWork
    {
        private static string connectionStringName = @"connectionId";

        private static BackendConfiguration backend = GetBackendConfiguration();

        private static MetadataSource metadataSource = new FluentModelMetadataSource();

        public FluentModel()
            : base(connectionStringName, backend, metadataSource)
        { 
        }

        public FluentModel(string connection)
            : base(connection, backend, metadataSource)
        { 
        }

        public FluentModel(BackendConfiguration backendConfiguration)
            : base(connectionStringName, backendConfiguration, metadataSource)
        { 
        }

        public FluentModel(string connection, MetadataSource metadataSource)
            : base(connection, backend, metadataSource)
        { 
        }

        public FluentModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
            : base(connection, backendConfiguration, metadataSource)
        { 
        }

        public IQueryable<VehicleInformation> Reports
        {
            get
            {
                return this.GetAll<VehicleInformation>();
            }
        }

        public static BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();
            backend.Backend = "MySql";
            backend.ProviderName = "MySql.Data.MySqlClient";

            CustomizeBackendConfiguration(ref backend);

            return backend;
        }

        /// <summary>
        /// Allows you to customize the BackendConfiguration of FluentModel.
        /// </summary>
        /// <param name="config">The BackendConfiguration of FluentModel.</param>
        static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
    }
}
