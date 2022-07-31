using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syncButtonController : MonoBehaviour
{
    // goal - controls the buttons that sync and desync the characters 

    public GameObject player1;
    public GameObject player2;

    // BUG - need to come up with a way for clicking AWAY to deselect buttons and revert scripts back to true 

    public void BlackCharacterPress()
    {
        Debug.Log("black works");
        player2.GetComponent<PlayerMovement>().enabled = false;
        player2.GetComponent<CharacterController2D>().enabled = false;
    }

    public void syncPress()
    {
        Debug.Log("works");
        player1.GetComponent<PlayerMovement>().enabled = true;
        player1.GetComponent<CharacterController2D>().enabled = true;

        player2.GetComponent<PlayerMovement>().enabled = true;
        player2.GetComponent<CharacterController2D>().enabled = true;
    }

    public void WhiteCharacterPress()
    {
        Debug.Log("works");
        player1.GetComponent<PlayerMovement>().enabled = false;
        player1.GetComponent<CharacterController2D>().enabled = false;
    }
}
