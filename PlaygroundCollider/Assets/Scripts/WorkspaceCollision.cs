using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkspaceCollision : MonoBehaviour
{


    public GameObject Cube;
    bool m_CollsionDetect;

    public AudioSource Lyd;
    bool m_HasAudioPlayed;

    // Start is called before the first frame update

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Cube)
        {
            m_CollsionDetect = true;
            
        }

        else
            m_CollsionDetect = false;
    }

    // Update is called once per frame
    void FixedUpdate()
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
