using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaisesDataBase : MonoBehaviour
{
    public static List<Paises> paisesList = new List<Paises>();

    void Awake(){
        paisesList.Add(new Paises(1,'192.168.0.1', 60, 2, 'Conexão no Brasil', 'Marrom', 50, 30));
        paisesList.Add(new Paises(2,'192.168.0.2', 60, 2, 'Conexão na Argentina', 'Marrom', 50, 30));
        paisesList.Add(new Paises(3,'193.172.0.3', 100, 2, 'Conexão na Guatemala', 'Azul-Claro', 50, 50));
        paisesList.Add(new Paises(4,'193.172.0.4', 100, 2, 'Conexão na Honduras', 'Azul-Claro', 50, 50));
        paisesList.Add(new Paises(5,'193.172.0.5', 120, 2, 'Conexão na Nicaragua', 'Azul-Claro', 50, 60));
        paisesList.Add(new Paises(6,'185.138.0.6', 140, 2, 'Conexão no Estados Unidos', 'Roxo', 100, 70));
        paisesList.Add(new Paises(7,'185.138.0.7', 140, 2, 'Conexão no Canadá', 'Roxo', 100, 70));
        paisesList.Add(new Paises(8,'185.138.0.8', 150, 2, 'Conexão no México', 'Roxo', 100, 75));
        paisesList.Add(new Paises(9,'171.256.0.9', 180, 2, 'Conexão na França', 'Laranja', 100, 90));
        paisesList.Add(new Paises(10,'171.256.0.10', 180, 2, 'Conexão na Alemanha', 'Laranja', 100, 90));
        paisesList.Add(new Paises(11,'171.256.0.11', 200, 2, 'Conexão na Espanha', 'Laranja', 100, 100));
        paisesList.Add(new Paises(12,'102.154.0.12', 220, 2, 'Conexão no Sudão', 'Vermelho', 150, 110));
        paisesList.Add(new Paises(13,'102.154.0.13', 220, 2, 'Conexão no Egito', 'Vermelho', 150, 110));
        paisesList.Add(new Paises(14,'102.154.0.14', 240, 2, 'Conexão na Líbia', 'Vermelho', 150, 120));
        paisesList.Add(new Paises(15,'256.108.0.15', 260, 2, 'Conexão no Irão', 'Amarelo', 150, 130));
        paisesList.Add(new Paises(16,'256.108.0.16', 260, 2, 'Conexão no Iraque', 'Amarelo', 150, 130));
        paisesList.Add(new Paises(17,'256.108.0.17', 280, 2, 'Conexão na Turquia', 'Amarelo', 150, 140));
        paisesList.Add(new Paises(18,'283.209.0.18', 300, 2, 'Conexão na China', 'Verde', 200, 150));
        paisesList.Add(new Paises(19,'283.209.0.19', 300, 2, 'Conexão no Japão', 'Verde', 200, 150));
        paisesList.Add(new Paises(20,'283.209.0.20', 320, 2, 'Conexão na Mongólia', 'Verde', 200, 160));
        paisesList.Add(new Paises(21,'239.099.0.21', 350, 2, 'Conexão na Austrália', 'Azul-Escuro', 200, 175));
        paisesList.Add(new Paises(22,'239.099.0.22', 400, 2, 'Conexão na Nova Zelândia', 'Azul-Escuro', 200, 200));
    }
}
