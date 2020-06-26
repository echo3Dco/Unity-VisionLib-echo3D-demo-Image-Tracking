/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        this.gameObject.AddComponent<RemoteTransformations>().entry = entry;

        // Qurey additional data to get the name
        string value = "";
        this.gameObject.transform.rotation = Quaternion.Euler(-90,0,0);
        this.gameObject.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
            
        }

        StartCoroutine(getTarget());
    }

    IEnumerator getTarget() {
        echoAR echoObject = GameObject.Find("echoAR").GetComponent<echoAR>();
        string APIKey = echoObject.APIKey;
        ModelHologram holo = (ModelHologram)entry.getHologram();
        ImageTarget img = (ImageTarget)holo.getTarget();
        string url = "https://console.echoar.xyz/query?key=" + APIKey + "&file=" + img.getStorageID();
        var uwr = new UnityWebRequest(url, UnityWebRequest.kHttpVerbGET);
        string path = Path.Combine(Application.dataPath, "StreamingAssets/VisionLib/Examples/PosterTracking/img.png");
        #if UNITY_IOS && !UNITY_EDITOR
            path = Path.Combine(Application.dataPath, "Raw/VisionLib/Examples/PosterTracking/img.png");
        #endif
        uwr.downloadHandler = new DownloadHandlerFile(path);
        yield return uwr.SendWebRequest();
        if (uwr.isNetworkError || uwr.isHttpError) {
            Debug.LogError(uwr.error);
        }
        else {
            Debug.Log("File successfully downloaded and saved to " + path);
            GameObject go = GameObject.Find("VLTrackingStart");
            ScriptTest script = go.GetComponent<ScriptTest>();
            script.track();
        }
            
    }

    // Update is called once per frame
    void Update()
    {

    }
}