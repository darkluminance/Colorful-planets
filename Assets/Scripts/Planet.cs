using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Planet : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;

    public PlanetSpawn PS;
    // Start is called before the first frame update
    void Start()
    {
        PS = GameObject.FindWithTag("Player").GetComponent<PlanetSpawn>();
        if (gameObject.CompareTag("Groho"))
        {
            moveSpeed =  ((int)(PS.Gametime / 15) * 0.1f) + 0.2f;
            PS.fixedtime = 0.4f / moveSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Groho"))
        {
            moveSpeed =  ((int)(PS.Gametime / 15) * 0.025f) + 0.2f;
            PS.fixedtime = 0.4f / moveSpeed;
        }

        transform.Translate(-moveSpeed,0,0);
        transform.Rotate(0,rotateSpeed * Time.deltaTime,0, Space.Self);

        if (transform.position.x <= -20)
        {
            Destroy(gameObject);
        }
    }
}
