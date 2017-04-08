using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAudio : MonoBehaviour {

    public AudioSource audio1;
    public GameObject triggerObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (triggerObj.GetComponent<Collider>().enabled)
        {
            if (!audio1.isPlaying) audio1.Play();
        }
        else
        {
            if (audio1.isPlaying) audio1.Stop();
        }
	}
}
