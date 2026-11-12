using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PrzyciskAlphaTest : MonoBehaviour
{
    public Image theButton;


    void Start()
    {
        theButton.alphaHitTestMinimumThreshold = 0.5f;
    }
}
