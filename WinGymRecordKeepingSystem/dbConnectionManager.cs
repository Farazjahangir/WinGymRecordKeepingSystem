using System.Data.SqlClient;
using System.Windows.Forms;

public static class DbConnectionManager
{
    private static readonly string connectionString = "workstation id=dbGymRecordKeepingSystem.mssql.somee.com;packet size=4096;user id=farazjahangir_SQLLogin_1;pwd=elg1ge3ayc;data source=dbGymRecordKeepingSystem.mssql.somee.com;persist security info=False;initial catalog=dbGymRecordKeepingSystem";
    private static SqlConnection connection;

    static DbConnectionManager()
    {
        connection = new SqlConnection(connectionString);
    }

    public static SqlConnection GetConnection()
    {
        return connection;
    }
}