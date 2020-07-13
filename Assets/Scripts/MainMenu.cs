using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ins, gamebut, insbutt, gamelogo;

    private bool zoom = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zoom && GameObject.FindWithTag("MainCamera").GetComponent<Camera>().orthographicSize > 0)
        {
            GameObject.FindWithTag("MainCamera").GetComponent<Camera>().orthographicSize -= .1f;
        }
    }

    public void StartGame()
    {
        GetComponent<AudioSource>().Play();
        gamebut.SetActive(false);
        insbutt.SetActive(false);
        gamelogo.SetActive(false);
        StartCoroutine("anim");
    }

    public void Instructions()
    {
        GetComponent<AudioSource>().Play();
        ins.SetActive(true);
    }

    public IEnumerator anim()
    {
        yield return new WaitForSeconds(2);
        zoom = true;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    public void back()
    {
        GetComponent<AudioSource>().Play();
        ins.SetActive(false);
    }

    public void quit()
    {
        GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
