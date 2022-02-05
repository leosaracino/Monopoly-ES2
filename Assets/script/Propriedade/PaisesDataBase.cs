using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class paisesDataBase : MonoBehaviour
{

    private string dbName = "URI=file:monopoly.db";
    // Start is called before the first frame update
    void Start()
    {
        CreateDB();
    }

    public void CreateDB()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();
            using(var command = connection.CreateCommand())
            {
                string paisesTable = ("CREATE TABLE IF NOT EXISTS paises(id INT PRIMARY KEY, " +
                            "ip VARCHAR(20) UNIQUE NOT NULL, " +
                            "cost INT NOT NULL, " +
                            "rent INT NOT NULL, " +
                            "houses INT, " +
                            "description VARCHAR(50) NOT NULL, " +
                            "mortgage INT NOT NULL, " +
                            "rentdescription VARCHAR(350) NOT NULL);");

                command.CommandText = paisesTable;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public void addAll()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                string query = "INSERT INTO paises(id, ip, cost, rent, houses, description, mortgage, rentdescription) VALUES " +
                        "(1, '192.168.0.1', 60, 2, 0, 'Conexão no Brasil', 30, '1 VPN.................R$ 10\n2 VPN.................R$ 30\n3 VPN.................R$ 90\n4 VPN.................R$ 160\nDatacenter........R$ 250')," +
                        "(2, '192.168.0.2', 60, 4, 0, 'Conexão na Argentina', 30, '1 VPN.................R$ 20\n2 VPN.................R$ 60\n3 VPN.................R$ 180\n4 VPN.................R$ 320\nDatacenter........R$ 450')," +
                        "(3, '193.172.0.3', 100, 2, 0, 'Conexão na Guatemala', 50, '1 VPN.................R$ 30\n2 VPN.................R$ 90\n3 VPN.................R$ 270\n4 VPN.................R$ 400\nDatacenter........R$ 550')," +
                        "(4, '193.172.0.4', 100, 2, 0, 'Conexão na Honduras', 50, '1 VPN.................R$ 30\n2 VPN.................R$ 90\n3 VPN.................R$ 270\n4 VPN.................R$ 400\nDatacenter........R$ 550')," +
                        "(5, '193.172.0.5', 120, 2, 0, 'Conexão na Nicaragua', 60, '1 VPN.................R$ 40\n2 VPN.................R$ 100\n3 VPN.................R$ 300\n4 VPN.................R$ 450\nDatacenter........R$ 600')," +
                        "(6, '185.138.0.6', 140, 2, 0, 'Conexão nos Estados Unidos', 70, '1 VPN.................R$ 50\n2 VPN.................R$ 150\n3 VPN.................R$ 450\n4 VPN.................R$ 625\nDatacenter........R$ 750')," +
                        "(7, '185.138.0.7', 140, 2, 0, 'Conexão no Canada', 70, '1 VPN.................R$ 50\n2 VPN.................R$ 150\n3 VPN.................R$450\n4 VPN.................R$ 625\nDatacenter........R$ 750')," +
                        "(8, '185.138.0.8', 150, 2, 0, 'Conexão no Mexico', 80, '1 VPN.................R$ 60\n2 VPN.................R$ 180\n3 VPN.................R$ 500\n4 VPN.................R$ 700\nDatacenter........R$ 900')," +
                        "(9, '171.256.0.9', 180, 2, 0, 'Conexão na França', 90, '1 VPN.................R$ 70\n2 VPN.................R$ 200\n3 VPN.................R$ 550\n4 VPN.................R$ 700\nDatacenter........R$ 900')," +
                        "(10, '171.256.0.10', 180, 2, 0, 'Conexão na Alemanha', 90, '1 VPN.................R$ 70\n2 VPN.................R$ 200\n3 VPN.................R$ 550\n4 VPN.................R$ 700\nDatacenter........R$ 950')," +
                        "(11, '171.256.0.11', 200, 2, 0, 'Conexão na Espanha', 100, '1 VPN.................R$ 80\n2 VPN.................R$ 220\n3 VPN.................R$ 600\n4 VPN.................R$ 800\nDatacenter........R$ 1000')," +
                        "(12, '102.154.0.12', 220, 2, 0, 'Conexão no Sudão', 110, '1 VPN.................R$ 90\n2 VPN.................R$ 250\n3 VPN.................R$ 700\n4 VPN.................R$ 875\nDatacenter........R$ 1050')," +
                        "(13, '102.154.0.13', 220, 2, 0, 'Conexão no Egito', 110, '1 VPN.................R$ 90\n2 VPN.................R$ 250\n3 VPN.................R$ 700\n4 VPN.................R$ 875\nDatacenter........R$ 1050')," +
                        "(14, '102.154.0.14', 240, 2, 0, 'Conexão na Líbia', 120, '1 VPN.................R$ 100\n2 VPN.................R$ 300\n3 VPN.................R$ 750\n4 VPN.................R$ 925\nDatacenter........R$ 1100')," +
                        "(15, '256.108.0.15', 260, 2, 0, 'Conexão no Irão', 130, '1 VPN.................R$ 110\n2 VPN.................R$ 330\n3 VPN.................R$ 800\n4 VPN.................R$ 975\nDatacenter........R$ 1150')," +
                        "(16, '256.108.0.16', 260, 2, 0, 'Conexão no Iraque', 130, '1 VPN.................R$ 110\n2 VPN.................R$ 330\n3 VPN.................R$ 800\n4 VPN.................R$ 975\nDatacenter........R$ 1150')," +
                        "(17, '256.108.0.17', 280, 2, 0, 'Conexão na Turquia', 140, '1 VPN.................R$ 120\n2 VPN.................R$ 360\n3 VPN.................R$ 850\n4 VPN.................R$ 1025\nDatacenter........R$ 1200')," +
                        "(18, '283.209.0.18', 300, 2, 0, 'Conexão na China', 150, '1 VPN.................R$ 130\n2 VPN.................R$ 390\n3 VPN.................R$ 900\n4 VPN.................R$ 1100\nDatacenter........R$ 1275')," +
                        "(19, '283.209.0.19', 300, 2, 0, 'Conexão no Japão', 150, '1 VPN.................R$ 130\n2 VPN.................R$ 390\n3 VPN.................R$ 900\n4 VPN.................R$ 1100\nDatacenter........R$ 1275')," +
                        "(20, '283.209.0.20', 320, 2, 0, 'Conexão na Mongólia', 160, '1 VPN.................R$ 150\n2 VPN.................R$ 450\n3 VPN.................R$ 1000\n4 VPN.................R$ 1200\nDatacenter........R$ 1400')," +
                        "(21, '239.099.0.21', 350, 2, 0, 'Conexão na Austrália', 175, '1 VPN.................R$ 175\n2 VPN.................R$ 500\n3 VPN.................R$ 1100\n4 VPN.................R$ 1300\nDatacenter........R$ 1500')," +
                        "(22, '239.099.0.22', 400, 2, 0, 'Conexão na Nova Zelândia', 200, '1 VPN.................R$ 200\n2 VPN.................R$ 600\n3 VPN.................R$ 1400\n4 VPN.................R$ 1700\nDatacenter........R$ 2000');";

                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
