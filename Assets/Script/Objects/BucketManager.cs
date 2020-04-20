using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

/// <summary>
/// This class is for managing that sweet, sweet chili
/// </summary>
public class BucketManager : MonoBehaviour
{

    public GameObject BucketAtPipe;
    public GameObject BucketAtClient;
    public SpriteRenderer PipeRend;
    public SpriteRenderer ClientRend;

    public BucketTrigger pipeTrigger;
    public BucketTrigger clientTrigger;


    public bool BucketAtPipeFull = false;

    [BoxGroup("Visibility Flags")]
    public bool AtPipe;

    [BoxGroup("Visibility Flags")]
    public bool AtClient;

    [BoxGroup("Visiblity Flags")]
    public bool InPlayerPosession;

    Color HiddenAlpha;
    Color VisibleAlpha;

    
    void Start()
    {
        HiddenAlpha = new Color(255.0f, 255.0f, 255.0f, 0.0f);
        VisibleAlpha = new Color(255.0f, 255.0f, 255.0f, 255.0f);
        AtPipe = false; //The bucket should be beside the client first so the player learns to get the bucket to feed it.
        AtClient = true;  //The bucket is at the Client.
        InPlayerPosession = false; //The bucket is not being held by the player.
    }

    
    void Update()
    {
        if (AtPipe)
        {
            AtClient = false;
            PipeRend.color = VisibleAlpha;
            ClientRend.color = HiddenAlpha; //Just to be safe.
        }

        if (AtClient)
        {
            AtPipe = false;
            PipeRend.color = HiddenAlpha;
            ClientRend.color = VisibleAlpha;
        }

        if (InPlayerPosession)
        {
            AtClient = false;
            AtPipe = false;
            PipeRend.color = HiddenAlpha;
            ClientRend.color = HiddenAlpha;
        }
    }
}
