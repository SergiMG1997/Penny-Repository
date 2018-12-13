using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmovement : MonoBehaviour {

    public float velocity;

    // Use this for initialization
    void Start()
    {
        Debug.Log("inici del moviment de l'ocell");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime, 0.0f, 0.0f);
    }
}
