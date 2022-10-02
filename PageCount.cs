using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageCount : MonoBehaviour
{
    public static int PageNumber = 1;

    public void IncreasePageCount()
    {
        if (PageNumber != 8)
        {
            PageNumber += 1;
        }
    }

    public void DecreasePageCount()
    {
        if (PageNumber != 1)
        {
            PageNumber -= 1;
        }
    }

    public int GetPageNumber()
    {
        return PageNumber;
    }
}
