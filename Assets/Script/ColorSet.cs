using BlockPuzzleGameToolkit.Scripts.Localization;
using UnityEngine;
using UnityEngine.UI;

public class ColorSet : MonoBehaviour
{
    public Color bgColor;
    public Color forGroundColor;

    public Image bgImage;
    public Image icon_Image;
    public Image fill_Image;
    public LocalizedTextMeshProUGUI text_TMP;
    public Outline outline;
    public Image buttonImage;
    public LocalizedTextMeshProUGUI buttonText_TMP;


    [ContextMenu("Set Color")]
    public void SetColor()
    {
        bgImage.color = bgColor;
        icon_Image.color = forGroundColor;
        if (fill_Image != null)
            fill_Image.color = forGroundColor;
        text_TMP.color = forGroundColor;
        outline.effectColor = forGroundColor;
        outline.effectDistance = new Vector2(10, -1);
        if (buttonImage != null)
        {
            buttonImage.color = forGroundColor;
        }
        if (buttonText_TMP != null)
            buttonText_TMP.color = bgColor;
    }
}
