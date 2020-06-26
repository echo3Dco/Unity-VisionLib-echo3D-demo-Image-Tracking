using UnityEngine;

public class ScriptTest : VLWorkerReferenceBehaviour
{        
    private void Start()
    {
        InitWorkerReference();
        //workerBehaviour.StartTracking("Examples/PosterTracking/posterTrackerSample.vl");
    }

    public void track() {
        workerBehaviour.StartTracking("Examples/PosterTracking/posterTrackerSample.vl");
    }

    private void OnDestroy()
    {
        workerBehaviour.StopTracking();
    }
    
    
}
