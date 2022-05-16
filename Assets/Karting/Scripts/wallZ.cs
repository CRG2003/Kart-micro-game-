using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallZ : MonoBehaviour
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
            transform.Translate(new Vector3(0, 0, 1) * 0.06f);
        }
        else{
            transform.Translate(new Vector3(0, 0, 1) * -0.06f);
        }

        if (transform.position.z < min){
            swap = true;
        }
        if (transform.position.z > max){
            swap = false;
        }
    }
}
