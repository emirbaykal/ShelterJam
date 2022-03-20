using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aiMove : MonoBehaviour
{
    private GameObject[] human;
    public GameObject[] movePoints;
    public bool isMove;
    private Vector3 nextPos;
    private float nextActionTime,period;
    public float speed;
    private int randomArrayNumber, nextArrayNumber;
    private int counterSix = 1,counterOne = 1;
    private int location;


    // Start is called before the first frame update
    void Start()
    {
        randomArrayNumber = Random.Range(1,6);
        nextPos = movePoints[randomArrayNumber].transform.position;
        transform.position = nextPos;
        period = Random.Range(1f,3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            human = GameObject.FindGameObjectsWithTag("human");
            for (int i = 0; i < 5; i++)
            { 
                human[i].GetComponent<Image>().color = Color.red;
                human[i].transform.position = movePoints[0].transform.position;
                human[i].GetComponent<aiMove>().enabled = false;
            }
        }
        if (Vector3.Distance(nextPos, transform.position) != 0)
        {
            if (isMove == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, nextPos, speed* Time.deltaTime);
            }
            else
            {
                isMove = false;
            }
        }

        if (Time.time > nextActionTime ) 
        {
            nextActionTime += period;
            
            if (randomArrayNumber == 1)
            {
                counterOne++;
                nextArrayNumber = Random.Range(1,3);
                nextPos = movePoints[nextArrayNumber].transform.position;
                if (counterOne == 2)
                {
                    counterOne = 0;
                    nextPos = movePoints[2].transform.position;
                    isMove = true;
                    //Debug.Log(2);
                }

            }
            else if (randomArrayNumber == 5)
            {
                counterSix++;
                nextArrayNumber = Random.Range(4,6);
                nextPos = movePoints[nextArrayNumber].transform.position;
                if (counterSix == 2)
                {
                    counterSix = 0;
                    nextPos = movePoints[4].transform.position;
                    isMove = true;
                    //Debug.Log(4);
                }
            }
            
            else
            {
                nextArrayNumber = Random.Range(randomArrayNumber-1,randomArrayNumber+2);
                nextPos = movePoints[nextArrayNumber].transform.position;
                isMove =true;
                randomArrayNumber = nextArrayNumber;
                //Debug.Log(nextArrayNumber);
            }
            randomArrayNumber = nextArrayNumber;
        }
    }
}
