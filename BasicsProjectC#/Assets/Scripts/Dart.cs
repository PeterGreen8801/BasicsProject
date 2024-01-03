using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Debug.Log("Hit");
            Destroy(collision.gameObject);

        }
    }
}
