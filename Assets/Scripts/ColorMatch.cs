using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class ColorMatch : MonoBehaviour
{
    public GameObject[] planets;
    public GameObject gameoverscreen, loading, expl;
    private AudioSource explosion;

    private bool khelashesh = false;
    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (khelashesh)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                StartCoroutine(Restart());
            else if (Input.GetKeyDown(KeyCode.Q))
                Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Barrier"))
        {
            if (GetComponent<Renderer>().material.name == "Red (Instance)" && other.gameObject.name != "RED3D(Clone)")
            {
                Explode();
                Invoke("GameOver",3);
            }else if (GetComponent<Renderer>().material.name == "Blue (Instance)" && other.gameObject.name != "BLUE3D(Clone)")
            {
                Explode();
                Invoke("GameOver",3);
            }else if (GetComponent<Renderer>().material.name == "Green (Instance)" && other.gameObject.name != "GREEN3D(Clone)")
            {
                Explode();
                Invoke("GameOver",3);
            }else if (GetComponent<Renderer>().material.name == "Yellow (Instance)" && other.gameObject.name != "YELLOW3D(Clone)")
            {
                Explode();
                Invoke("GameOver",3);
            }
        }
        
    }

    public void Explode()
    {
        GameObject.FindWithTag("Player").SetActive(false);
        expl.SetActive(true);
        explosion.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    public void GameOver()
    {
        gameoverscreen.SetActive(true);
        GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(0,0,0);
        khelashesh = true;
    }

    public IEnumerator Restart()
    {
        loading.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);   
    }
}
