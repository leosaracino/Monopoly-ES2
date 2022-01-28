using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Paises : MonoBehaviour
{
    public int id;
    public string ip;
    public int cost;
    public int rent;
    public bool buyHouse;
    private int qHouses;
    public string description;
    public string color;
    public int houseCost;
    public int mortgage;

    public Paises(){

    }

    public Paises(int id, string ip, int cost, int rent, string description, string color, int houseCost, int mortgage){
        id=this.id;
        ip=this.ip;
        cost=this.cost;
        rent=this.rent;
        description=this.description;
        color=this.color;
        houseCost=this.houseCost;
        mortgage=this.mortgage;
    }
}
