using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TrigTimeline : MonoBehaviour
{
    public bool trig = false;
    PlayableDirector playableDirector;

    // Start is called before the first frame update
    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        
    }
    private void Update()
    {
        if (trig)
        {
            trig = false;
            TriggerTimeline();
        }
    }

    public void TriggerTimeline()
    {
        playableDirector.Play();
    }
}
