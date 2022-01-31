using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.SqLiteClient;

public class PaisesDataBase : MonoBehaviour{

    private IDbConnection connection; //Faz a conexão com o banco
    private IDbCommand command; //Faz o comando da conexão
    private IDataReader reader;

    void Start() {

    }

    private void Connection(){
        connection = new SqliteConnection();
    }

    public void ConsultOne(){

    }
}
