using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuscroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f,0,0);

        if(transform.position.x <= -19.5f){
            transform.position = new Vector3 (transform.position.x + 38.4f,transform.position.y,1);
        }
    }
}
