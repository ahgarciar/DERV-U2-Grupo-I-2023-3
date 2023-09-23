using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P0_MovUsuario : MonoBehaviour
{
    [SerializeField] float velocidad; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -1 * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -1 * velocidad * Time.deltaTime);
        }
    }
}
