using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using PaisesDataBase;

public class ThisPais : MonoBehaviour 
{

    public List<Paises> thisPais = new List<Paises>();
    public int thisId;

    public int id;
    public string ip;
    public int cost;
    public int rent;
    public string description;
    public string color;
    public int houseCost;
    public int mortgage;

    public Text ipText;
    public Text costText;
    public Text rentText;
    public Text descriptionText;
    public Text houseCostText;
    public Text mortgageText;

    // Start is called before the first frame update
    void Start(){
        Debug.Log("I am Alive");
        thisPais[0].id = PaisesDataBase.paisesList[thisId].id;
        thisPais[0].ip = PaisesDataBase.paisesList[thisId].ip;
    }

    // Update is called once per frame
    void Update(){
        id = thisPais[0].id;
        ip = thisPais[0].ip;
        cost = thisPais[0].cost;
        rent = thisPais[0].rent;
        description = thisPais[0].description;
        color = thisPais[0].color;
        houseCost = thisPais[0].houseCost;
        mortgage = thisPais[0].mortgage;

        ipText.text = "" + ip;
        costText.text = "" + cost;
        rentText.text = "" + rent;
        descriptionText.text = "" + description;
        houseCostText.text = "" + houseCost;
        mortgageText.text = "" + mortgage;
    }
}