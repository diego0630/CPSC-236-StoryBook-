using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBack : MonoBehaviour
{
    public GameObject BackButton;
    private PageCount Page;

    public void OnBackButtonClick()
    {
        Page.DecreasePageCount();
        if (Page.GetPageNumber() == 1) {
            {
                BackButton.SetActive(false);
            }
        }
    }
}
