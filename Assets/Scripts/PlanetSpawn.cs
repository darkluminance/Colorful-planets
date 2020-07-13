using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class PlanetSpawn : MonoBehaviour
{
    public Text gametimeText, scoreText, highscoretext ;

    public GameObject[] planets;

    public float timer;
    private int index;
    public float fixedtime;

    public float Gametime = 0;
    public float score = 0;
    private float hightime, highdist;

    public GameObject highscoresound, rankup;
    
    // Start is called before the first frame update
    void Start()
    {
        fixedtime = timer;
        index = Random.Range(0, planets.Length);
        Instantiate(planets[index], transform.position + new Vector3(30,0,0), Quaternion.identity);
        gametimeText.text = ("" + Gametime + " s"); scoreText.text = "" ;
        hightime = PlayerPrefs.GetFloat("hightime", hightime);
        highdist = PlayerPrefs.GetFloat("highdist", highdist);
        highscoretext.text = "" + (int) hightime + " s" + (int) highdist + " km";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        Gametime += Time.deltaTime;

        score += (((int)(Gametime / 15) * 0.1f) + 0.2f);

        if (timer <= 0.1f)
        {
            timer = fixedtime;
            index = Random.Range(0, planets.Length) ;
            Instantiate(planets[index], transform.position + new Vector3(30,0,0), Quaternion.identity);
        }

        
        gametimeText.text = ("" +(int)Gametime + " s");
        scoreText.text = "" + (int)score + " km";

        if (Gametime > hightime)
        {
            hightime = Gametime;
            PlayerPrefs.SetFloat("hightime",hightime);
        }

        if (score > highdist)
        {
            highscoresound.SetActive(true); rankup.SetActive(true);
            highdist = score;
            PlayerPrefs.SetFloat("highdist", highdist);
        }
        
        
        highscoretext.text = "" + (int) hightime + " s     " + (int) highdist + " km";
    }
}
