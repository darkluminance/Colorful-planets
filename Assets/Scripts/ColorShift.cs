using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorShift : MonoBehaviour
{
    public Renderer rend;
    public Material red, blue, green, yellow;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rend.material = red;
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rend.material = blue;
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rend.material = green;
        }else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rend.material = yellow;
        }
    }
}
