using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 3;
    public Renderer rend;
    private int randomNumber;
    private GameObject redObj;
    private GameObject blueObj;
    void Start()
    {
        randomNumber = Random.Range(150, 251);
        blueObj = GameObject.FindGameObjectWithTag("Blue");
        redObj = GameObject.FindGameObjectWithTag("Red");
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (redObj && i == 100)
        {
            redObj.SetActive(false);
        }
        
        if (blueObj && i == randomNumber)
        {
            blueObj.GetComponent<Renderer>().enabled = false;
        }
    }
}
