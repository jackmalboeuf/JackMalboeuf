using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour
{
    [SerializeField]
    Transform nextPanel;
    [SerializeField]
    SlideAway slidePanel;

    public void SlideToNextPanel()
    {
        if (nextPanel != null)
        {
            int siblingNumber = nextPanel.parent.childCount;
            nextPanel.SetSiblingIndex(siblingNumber - 2);
            nextPanel.localPosition = new Vector2(0, 0);
        }

        StartCoroutine(slidePanel.Slide());
    }
}
