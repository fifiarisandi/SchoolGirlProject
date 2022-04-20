using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour
{
    public Text detailText;             //For holding the details of the components

    public void Start()
    {
        gameObject.SetActive(false);            //Default view to be false so it cannot be seen
    }

    //To display the tool tip
    public void ShowToolTip()
    {
        gameObject.SetActive(true);
    }

    //To hide the tool tip
    public void HideToolTip()
    {
        gameObject.SetActive(false);
    }

    //For updating the tool tip and lets us know we are collecting the detailed information
    public void UpdateToolTip(string _detailText)
    {
        detailText.text = _detailText;
    }

    //For showing the tool tip on mouse hover
    public void SetPosition(Vector2 _pos)
    {
        transform.localPosition = _pos;
    }
}
