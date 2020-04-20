using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeldHUD : MonoBehaviour
{

    public HUDElement ShownHUD;

    public Sprite BucketFullSprite;
    public Sprite BucketEmptySprite;
    public Sprite BottleWaterSprite;
    public Sprite WoodSprite;
    public Sprite ToySprite;

    private Image thisRend;

    CanvasGroup cnv;

    void Start()
    {
        thisRend = GameObject.Find("HUDIcon").GetComponent<Image>();
        cnv = GetComponent<CanvasGroup>();
    }

    void Update()
    {
        switch (ShownHUD)
        {
            case HUDElement.BucketFull:
                thisRend.color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
                cnv.alpha = 1;
                thisRend.sprite = BucketFullSprite;
                break;
            case HUDElement.BucketEmpty:
                thisRend.color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
                cnv.alpha = 1;
                thisRend.sprite = BucketEmptySprite;
                break;
            case HUDElement.BottleWater:
                thisRend.color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
                cnv.alpha = 1;
                thisRend.sprite = BottleWaterSprite;
                break;
            case HUDElement.Wood:
                thisRend.color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
                cnv.alpha = 1;
                thisRend.sprite = WoodSprite;
                break;
            case HUDElement.Toy:
                thisRend.color = new Color(255.0f, 255.0f, 255.0f, 255.0f);
                cnv.alpha = 1;
                thisRend.sprite = ToySprite;
                break;
            case HUDElement.Empty:
                thisRend.color = new Color(255.0f, 255.0f, 255.0f, 0.0f);
                cnv.alpha = 0;
                break;
            default:
                break;
        }
    }

    public enum HUDElement
    {
        BucketFull,
        BucketEmpty,
        BottleWater,
        Wood,
        Toy,
        Empty
    }
}
