using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kill : MonoBehaviour
{
    public GameObject[] human;
    public aiMove aiMove_script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        human = GameObject.FindGameObjectsWithTag("human");
        if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < 5; i++)
            { 
                human[i].GetComponent<Image>().color = Color.red;
                human[i].transform.position = aiMove_script.movePoints[0].transform.position;
                human[i].GetComponent<aiMove>().enabled = false;
            }
        }
        
    }
}
