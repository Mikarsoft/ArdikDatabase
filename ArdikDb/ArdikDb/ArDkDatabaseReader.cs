namespace ArdikDb
{
    internal class ArDkDatabaseReader
    {

        internal bool CreateDatabase(string databaseName)
        {
            ArdikDatabaseHeader databaseHeader = new ArdikDatabaseHeader(databaseName);
            return true;
        }
    }
}
