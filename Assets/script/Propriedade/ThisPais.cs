using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ThisPais : MonoBehaviour
{

    public List<Pais> thisPais = new List<Pais>();
    public int thisId;

    private int idPais;
    private string ipPais;
    private int rentPais;
    private int costPais;
    private int housesPais;
    private string descriptionPais;
    private int mortgagePais;
    public string vpn1Pais;
    public string vpn2Pais;
    public string vpn3Pais;
    public string vpn4Pais;
    public string datacenterPais;

    public Text ip;
    public Text rent;
    public Text cost;
    public Text mortgage;
    public Text vpn1;
    public Text vpn2;
    public Text vpn3;
    public Text vpn4;
    public Text datacenter;

    // Start is called before the first frame update
    void Start()
    {
        ip = GameObject.FindWithTag("Endereco_Ip").GetComponent<Text>();
        rent = GameObject.FindWithTag("Aluguel").GetComponent<Text>();
        cost = GameObject.FindWithTag("Preco").GetComponent<Text>();
        mortgage = GameObject.FindWithTag("Hipoteca").GetComponent<Text>();
        vpn1 = GameObject.FindWithTag("Vpn1").GetComponent<Text>();
        vpn2 = GameObject.FindWithTag("Vpn2").GetComponent<Text>();
        vpn3 = GameObject.FindWithTag("Vpn3").GetComponent<Text>();
        vpn4 = GameObject.FindWithTag("Vpn4").GetComponent<Text>();
        datacenter = GameObject.FindWithTag("Datacenter").GetComponent<Text>();
        thisPais[0] = LocalDataBase.listPais[thisId];
    }

    // Update is called once per frame
    void Update()
    {
        idPais = thisPais[0].idPais;
        ipPais = thisPais[0].ipPais;
        rentPais = thisPais[0].rentPais;
        costPais = thisPais[0].costPais;
        housesPais = thisPais[0].housesPais;
        descriptionPais = thisPais[0].descriptionPais;
        mortgagePais = thisPais[0].mortgagePais;
        vpn1Pais = thisPais[0].VPN1;
        vpn2Pais = thisPais[0].VPN2;
        vpn3Pais = thisPais[0].VPN3;
        vpn4Pais = thisPais[0].VPN4;
        datacenterPais = thisPais[0].Datacenter;

        ip.text = "Ip: " + ipPais;
        rent.text  = "Aluguel: "+ rentPais;
        cost.text  = "Preço: "+ costPais;
        mortgage.text  = "Hipoteca: "+ mortgagePais;
        vpn1.text = "" + vpn1Pais;
        vpn2.text = "" + vpn2Pais;
        vpn3.text = "" + vpn3Pais;
        vpn4.text = "" + vpn4Pais;
        datacenter.text = "" + datacenterPais;
    }
}
