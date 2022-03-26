using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("AFROGAMES");
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(10.0f, 0.0f, 0.0f)
        }
    }
}
