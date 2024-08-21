using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbar : MonoBehaviour
{
    public float maxtime;
    private float timer = 0;
    public GameObject bars;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxtime){
            GameObject newbars = Instantiate(bars);
            newbars.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
            Destroy(newbars,15);
            timer = 0;
        }
        timer+=Time.deltaTime;
    }
}
