using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estudo : MonoBehaviour
{   
    public float velocidade = 5.0f;
    public float rotacao = 2.0f;
    public GameObject prefabMeteoro;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("AFROGAMES");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, velocidade * Time.deltaTime , 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -velocidade * Time.deltaTime , 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-velocidade * Time.deltaTime , 0.0f, 0.0f);
            transform.Rotate(0.0f, 0.0f, 2.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);
            transform.Rotate(0.0f, 0.0f, -2.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate( prefabMeteoro, new Vector3 (4.0f,4.0f,0.0f), Quaternion.identity);
        }
    }
}
