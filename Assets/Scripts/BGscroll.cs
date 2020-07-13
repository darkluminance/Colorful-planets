using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour
{
    float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scrollSpeed = GameObject.FindWithTag("Groho").GetComponent<Planet>().moveSpeed * 0.25f;
        
        transform.Translate(-scrollSpeed,0,0);

        if(transform.position.x <= -19.5f){
            transform.position = new Vector3 (transform.position.x + 38.4f,transform.position.y,1);
        }
    }
}
