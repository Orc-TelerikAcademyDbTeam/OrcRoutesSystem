using Telerik.OpenAccess;
    
    namespace MySQL
    {
       public class EntryPoint
       {
           public static void Start()
           {
               UpdateDatabase();
           }
    
           private static void UpdateDatabase()
           {
               using (var context = new MySQL.FluentModel())
               {
                   var schemaHandler = context.GetSchemaHandler();
                   EnsureDB(schemaHandler);
               }
           }
    
           private static void EnsureDB(ISchemaHandler schemaHandler)
           {
               string script = null;
               if (schemaHandler.DatabaseExists())
               {
                   script = schemaHandler.CreateUpdateDDLScript(null);
               }
               else
               {
                   schemaHandler.CreateDatabase();
                   script = schemaHandler.CreateDDLScript();
               }
    
               if (!string.IsNullOrEmpty(script))
               {
                   schemaHandler.ExecuteDDLScript(script);
               }
           }
       }
    }