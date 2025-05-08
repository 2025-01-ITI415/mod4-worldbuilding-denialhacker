using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int itemCount = 0;
    public int itemsToWin;
    public GameObject winText;
    public Text countText;
    private AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            audioSource.Play();
            itemCount++;
            Destroy(other.gameObject, audioSource.clip.length);
            UpdateUI();

            if (itemCount >= itemsToWin)
            {
                winText.SetActive(true);
            }
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemsToWin = GameObject.FindGameObjectsWithTag("Pickup").Length;
        UpdateUI();
        winText.SetActive(false);
    }

    void UpdateUI()
    {
        countText.text = "Collected: " + itemCount + "/" + itemsToWin;
    }
    
}
