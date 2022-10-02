using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNext : MonoBehaviour
{
    public GameObject NextButton;
    private PageCount Page;

    public void OnNextButtonClick()
    {
        Page.IncreasePageCount();
        if (Page.GetPageNumber() == 8) {
            {
                NextButton.SetActive(false);
            }
        }
    }
}
