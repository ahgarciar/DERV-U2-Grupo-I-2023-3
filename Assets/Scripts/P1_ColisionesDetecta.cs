using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_ColisionesDetecta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        string nombre = collision.gameObject.name;
        Debug.Log("Entra en colision con: " + nombre);
    }

    private void OnCollisionStay(Collision collision)
    {
        string nombre = collision.gameObject.name;
        Debug.Log("En colision con: " + nombre);
    }

    private void OnCollisionExit(Collision collision)
    {
        string nombre = collision.gameObject.name;
        Debug.Log("Sale de colision con: " + nombre);
    }

}
