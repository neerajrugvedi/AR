using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class ARController : MonoBehaviour
{

    private List<TrackedPlane> m_NewTrackedPlanes = new List<TrackedPlane>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check ARCore session status

        if(Session.Status != SessionStatus.Tracking){

            return;
        }

        Session.GetTrackables<TrackedPlane>(m_NewTrackedPlanes, TrackableQueryFilter.New);


    }
}
