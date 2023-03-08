using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{
    public AudioSource source;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float treshold = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;

        if (loudness < treshold)
            loudness = 0;

        if (loudness > treshold)
        {
            GetComponent<Animator>().Play("TalkAnimationEagle");
            GetComponent<Animator>().Play("TalkAnimationBear");
            GetComponent<Animator>().Play("TalkAnimationWolf");
        } else
        {
            GetComponent<Animator>().Play("New State");
        }
        
    }
}