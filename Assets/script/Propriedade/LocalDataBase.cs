using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalDataBase : MonoBehaviour
{
    public static List<Pais> listPais = new List<Pais>();

    private void Start()
    {
        Awake();
    }

    public void Awake()
    {
        listPais.Add(new Pais(0, null, 0, 0, 0, null, 0, null, null, null, null, null));
        listPais.Add(new Pais(1, "192.168.0.1", 60, 2, 0, "Conexão no Brasil", 30, "1 VPN.................R$ 10", "2 VPN.................R$ 30", "3 VPN.................R$ 90", "4 VPN.................R$ 160", "Datacenter........R$ 250"));
    }
}
