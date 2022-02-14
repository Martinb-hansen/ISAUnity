using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject sphere;
    bool m_CollsionDetect;

    public AudioSource Lyd;
    bool m_HasAudioPlayed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sphere)
            m_CollsionDetect = true;
            
        else
            m_CollsionDetect = false; //Tror ikke den behøves
    }

    // Update is called once per frame
    void Update()
    {
        if (!m_HasAudioPlayed)
        {

            if (m_CollsionDetect)
            {
                Lyd.Play();
                m_HasAudioPlayed = true;
            }
            
           
        }
      
        

    }
}
