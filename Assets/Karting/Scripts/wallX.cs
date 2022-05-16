using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallX : MonoBehaviour
{
    public int min;
    public int max;

    public bool swap = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (swap == true){
            transform.Translate(new Vector3(1, 0, 0) * 0.06f);
        }
        else{
            transform.Translate(new Vector3(1, 0, 0) * -0.06f);
        }

        if (transform.position.x < min){
            swap = true;
        }
        if (transform.position.x > max){
            swap = false;
        }
    }
}
