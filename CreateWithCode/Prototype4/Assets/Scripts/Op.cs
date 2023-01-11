using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Op : MonoBehaviour
{
    public float speed;
    private Rigidbody opponentRb;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        opponentRb = GetComponent<Rigidbody>();
        enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        opponentRb.AddForce((enemy.transform.position - transform.position).normalized * speed);
    }
}
