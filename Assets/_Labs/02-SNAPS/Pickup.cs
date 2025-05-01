using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static int totalCollected = 0; // Shared among all items

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            totalCollected++;
            Debug.Log("Collected! Total: " + totalCollected);

            Destroy(gameObject); // Remove the collected item
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
