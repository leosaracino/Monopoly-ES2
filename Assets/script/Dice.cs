using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [SerializeField]
    private Transform respawnPos = null;

    [SerializeField]
    private float rotationRandomness = 10000;

    [SerializeField]
    private float upForce = 1000;

    [SerializeField]
    private Transform[] sides = null;

    public Action onStop;

    private Rigidbody rb;

    private bool isStopped = false;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (respawnPos)
            Gizmos.DrawWireSphere(respawnPos.position, respawnPos.lossyScale.magnitude);
        foreach (Transform side in sides)
            Gizmos.DrawWireSphere(side.position, side.lossyScale.magnitude);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(rb.velocity, Vector3.zero) == 0 && !isStopped)
        {
            isStopped = true;
            onStop?.Invoke();
        }
    }

    public int GetDiceValue()
    {
        for (int i = 0; i < sides.Length; i++)
        {
            Collider[] colliders = Physics.OverlapSphere(sides[i].position, sides[i].lossyScale.magnitude);
            foreach (Collider col in colliders)
            {
                if (col.CompareTag("Ground"))
                {
                    return i + 1;
                }
            }
        }
        return 0;
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        float dirx = UnityEngine.Random.Range(0, rotationRandomness);
        float diry = UnityEngine.Random.Range(0, rotationRandomness);
        float dirz = UnityEngine.Random.Range(0, rotationRandomness);
        transform.position = respawnPos.position;
        transform.rotation = Quaternion.identity;
        float x = UnityEngine.Random.Range(1, upForce);
        rb.AddForce(transform.up * x);
        rb.AddTorque(dirx, diry, dirz);
        isStopped = false;
    }
}
