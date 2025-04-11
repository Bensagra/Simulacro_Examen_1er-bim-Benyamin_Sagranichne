using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gustoHelado;
    public int gramosDeHelado;
    float precioHelado = 1.25f;
    float total;

    void Start()
    {
        if (gramosDeHelado < 250 || gramosDeHelado > 3000)
        {
            Debug.Log("Error");
            return;
        }
        if (gustoHelado == "CHO" || gustoHelado == "DDL")
        {
            total = gramosDeHelado * precioHelado;
        }
        else if (gustoHelado == "FRU")
        {
            total = gramosDeHelado * precioHelado * .9f;
        }
        else
        {
            Debug.Log("Error");
            return;
        }
        Debug.Log(total);
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
