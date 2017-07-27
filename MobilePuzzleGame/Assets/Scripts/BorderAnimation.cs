using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BorderAnimation : MonoBehaviour
{
    [SerializeField]
    float startDelay;
    [SerializeField]
    float endDelay;

    bool isRunning = false;

    void Update()
    {
        /*if (isRunning == false && Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(Fill());
        }*/
    }

    IEnumerator Fill()
    {
        isRunning = true;

        GetComponent<Image>().fillAmount = 0;
        yield return new WaitForSeconds(startDelay);

        while (GetComponent<Image>().fillAmount < 1)
        {
            GetComponent<Image>().fillAmount += 0.05f;
            yield return new WaitForSeconds(0.01f);
        }

        yield return new WaitForSeconds(2 + endDelay);

        isRunning = false;
    }
}
