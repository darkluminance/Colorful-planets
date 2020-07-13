using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyTime : MonoBehaviour
{
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("delay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator delay()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
