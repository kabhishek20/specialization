using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject[] car;
    int carno;
    public float maxpos=2.1f;
    public float delayTimer=1f;
    float timer;
    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        timer=delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        i=i+1;
        carno=Random.Range(0,8);
        timer -=Time.deltaTime;
        if(timer<=0)
        {
            Vector3 carPos= new Vector3(Random.Range(-2.1f,2.1f),transform.position.y,transform.position.z);
            Instantiate(car[carno],carPos,transform.rotation);
            if(i<=10000)
            timer=Random.Range(0.5f,2f);
            else if(i>=10000 && i<=20000)
            timer=Random.Range(0.5f,1f);
            else
            timer=Random.Range(0.5f,0.7f);
        }
    }
}
