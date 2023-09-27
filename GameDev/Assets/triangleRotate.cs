using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{

    private void Awake() {
        Debug.Log("Awaken");
    }

    private void OnEnable() {
        Debug.Log("Enabled");
    }

    private void OnDisable() {
        Debug.Log("Disabled");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    
    void Update()
    {
        float speed = 10f;

        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnDestroy() {
        Debug.Log("Destroyed");
    }
}
