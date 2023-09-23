using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_CreaEnemigo : MonoBehaviour
{

    [SerializeField] GameObject PlantillaEnemigo;

    [SerializeField] List<GameObject> Spawns;

    public int index_new_enemy; //spawn selected to instantiate a new enemy 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            index_new_enemy = Random.Range(0, 10); //[0 - 9]

            GameObject nlocation = Spawns[index_new_enemy];

            GameObject objNuevo = Instantiate(PlantillaEnemigo,
                nlocation.transform.position,
                nlocation.transform.rotation
                );

        }
    }
}
