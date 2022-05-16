using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class PowerUp : MonoBehaviour
{
    GameObject player;
    float timer = 0;
    bool fin = false;

    string dir = "right";

    public float left;
    public float right;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("KartClassic_Player");
        int notFaded = LayerMask.NameToLayer("Kart");
        player.layer = notFaded;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer > 0){
            int faded = LayerMask.NameToLayer("KartFaded");
            player.layer = faded;
        }
        else if (fin){
            int notFaded = LayerMask.NameToLayer("Kart");
            player.layer = notFaded;
            Destroy(this.gameObject);
        }
        if (dir == "right"){
            transform.Translate(new Vector3(0, 0, 1) * -0.04f);
        }
        if (dir == "left"){
            transform.Translate(new Vector3(0, 0, 1) * 0.04f);
        }
        if (transform.position.z < right){
            dir = "left";
        }
        if (transform.position.z > left){
            dir = "right";
        }
    }

    void OnCollisionEnter(Collision other){
        var rb = other.gameObject.GetComponent<Rigidbody>();

        var kart = rb.GetComponent<ArcadeKart>();
        if (other.gameObject.GetComponent<Collider>().tag == "Player"){
            timer = 10.0f;
            transform.Translate(-Vector3.down * 200000);
            fin = true;
        }

    }
}
