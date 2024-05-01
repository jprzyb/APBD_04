namespace APBD_04.Controllers;

public class WarehouseController
{
    private IConfiguration _configuration;
    private string _connectionString;
    
    public WarehouseController(IConfiguration configuration)
    {
        _configuration = configuration;
        string strProject = "KUBUS"; // Wprowadź nazwę instancji serwera SQL
        string strDatabase = "Animals"; // Wprowadź nazwę bazy danych
        string strUserID = "user_two"; // Wprowadź nazwę użytkownika SQL Server
        string strPassword = "aaaa"; // Wprowadź hasło użytkownika SQL Server
        _connectionString = "data source=" + strProject +
                            ";Persist Security Info=false;database=" + strDatabase +
                            ";user id=" + strUserID + ";password=" +
                            strPassword +
                            ";Connection Timeout = 0;trustServerCertificate=true;";
    }
}