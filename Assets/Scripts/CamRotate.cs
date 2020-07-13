using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{

    int a, b;

    public GameObject excellent, wonderful;
    // Start is called before the first frame update
    void Start()
    {
        a = 1; b = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if((int)GameObject.FindWithTag("Player").GetComponent<PlanetSpawn>().Gametime == 15){
                if (a <=25)transform.Rotate(0,0,7.2f);
                a++;
        }

        if((int)GameObject.FindWithTag("Player").GetComponent<PlanetSpawn>().Gametime == 30){
                if (b <=25)transform.Rotate(0,0,-7.2f);
                b++;
        } 
        
        if((int)GameObject.FindWithTag("Player").GetComponent<PlanetSpawn>().Gametime == 60)
        {
        
            wonderful.SetActive(true);
        }
        
        if((int)GameObject.FindWithTag("Player").GetComponent<PlanetSpawn>().Gametime == 100)
        {
            
            excellent.SetActive(true);
        }
    }
}
