namespace ArdikDb
{
    internal class ArdikDatabaseHeader
    {
        internal ArdikDatabaseHeader(string databaseName)
        {
            DatabaseName = databaseName;

            DatabaseRootDirectory = Path.Combine(ArdikSettings.RootPath, databaseName);

            if(!Directory.Exists(DatabaseRootDirectory))
            {
                Directory.CreateDirectory(DatabaseRootDirectory);
            }
        }

        internal double HeaderLength { get; set; }
        internal double BasePathLength { get; set; }
        internal double TotalTables { get; set; }
        internal double TablesSectionLength { get; set; }
        internal double TotalSchemas { get; set; }
        internal double SchemasSectionLength { get; set; }
        internal double TableNameLength { get; set; }
        internal double SchemaNameLength { get; set; }
        internal string DatabaseRootDirectory { get; set; } = string.Empty;
        internal string DatabaseName { get; set; } = string.Empty;
    }
}
