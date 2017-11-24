using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {

	public GameObject videoScreen;

	private VideoPlayer videoPlayer;


	// Use this for initialization
	void Start () {
		videoPlayer = videoScreen.GetComponent<VideoPlayer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play() {
		videoPlayer.Play();

    }

    public void Pause() {
		videoPlayer.Pause();
    }
    public void Stop() {
		videoPlayer.Stop();
    }

}
