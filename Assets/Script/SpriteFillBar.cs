using UnityEngine;
using System.Collections;

public class SpriteFillBar : MonoBehaviour
{
    public Transform fullFillImage;
    public Transform fillImage;

    public FillStyle Mode = FillStyle.Vertical;

    void Start()
    {
        var newScale = this.fillImage.localScale;
        if (Mode == FillStyle.Vertical)
        {
            newScale.y = 0;
            this.fillImage.localScale = newScale;
        }else
        {
            newScale.x = 0;
            this.fillImage.localScale = newScale;
        }
        
        

    }

    /// <summary>
    /// This uses the transform as a fill rather than trying to tie some UI nonsense to it. This will likely need to be flipped to X for a vertical bar.
    /// </summary>
    /// <param name="fillAmount"></param>
    public void SetFillBar(float fillAmount)
    {
        fillAmount = Mathf.Clamp01(fillAmount);
        var newScale = this.fillImage.localScale;
        if (Mode == FillStyle.Vertical)
        {
            newScale.y = this.fullFillImage.localScale.y * fillAmount;
            this.fillImage.localScale = newScale;
        } else
        {
            newScale.x = this.fullFillImage.localScale.x * fillAmount;
            this.fillImage.localScale = newScale;
        }
        
        

        
    }

    public enum FillStyle
    {
        Horizontal,
        Vertical
    }
}
