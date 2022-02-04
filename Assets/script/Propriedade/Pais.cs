using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pais : MonoBehaviour
{
    public int idPais;
    public string ipPais;
    public int rentPais;
    public int costPais;
    public int housesPais;
    public string descriptionPais;
    public int mortgagePais;
    public string VPN1;
    public string VPN2;
    public string VPN3;
    public string VPN4;
    public string Datacenter;

    public Pais()
    {

    }

    public Pais(int id, string ip, int rent, int cost, int houses, string description, int mortgage, string vpn1, string vpn2, string vpn3, string vpn4, string datacenter)
    {
        idPais = id;
        ipPais = ip;
        rentPais = rent;
        costPais = cost;
        housesPais = houses;
        descriptionPais = description;
        mortgagePais = mortgage;
        VPN1 = vpn1;
        VPN2 = vpn2;
        VPN3 = vpn3;
        VPN4 = vpn4;
        Datacenter = datacenter;
    }
}
