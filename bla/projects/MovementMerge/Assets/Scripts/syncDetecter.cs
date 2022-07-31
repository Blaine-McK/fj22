using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class syncDetecter : MonoBehaviour
{

    public GameObject player1;
        // note: this.gameObject is actually player2
    public Image syncLight;

    public bool isRed;
    public bool isYellow;
    public bool isGreen;

    void Start()
    {
        // start with red true 
        isRed = true;
        isYellow = false;
        isGreen = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("yellowLight"))
        {
            Debug.Log("yellowLight entered");
            syncLight.GetComponent<Image>().color = Color.yellow;
            isRed = false;
            isYellow = true;
            // no need to mention green
        }

        if (other.CompareTag("greenLight"))
        {
            Debug.Log("greenLight entered");
            syncLight.GetComponent<Image>().color = Color.green;
            isRed = false;
            isYellow = false;            
            isGreen = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("yellowLight"))
        {
            Debug.Log("yellowLight left");
            syncLight.GetComponent<Image>().color = Color.red;
            isRed = true;
            isYellow = false;
            isGreen = false;
        }

        if (other.CompareTag("greenLight"))
        {
            Debug.Log("greenLight left");
            syncLight.GetComponent<Image>().color = Color.yellow;
            isRed = false;
            isYellow = true;
            isGreen = false;
        }
    }
}
