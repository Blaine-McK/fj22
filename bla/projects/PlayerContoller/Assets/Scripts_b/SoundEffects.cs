using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{

    public AudioClip jumpSound;
    public AudioClip bopSound;
    public AudioClip deathSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioClip getJumpSound()
    {
        return jumpSound;
    }

    public AudioClip getBopSound()
    {
        return bopSound;
    }

    public AudioClip getDeathSound()
    {
        return deathSound;
    }
}
