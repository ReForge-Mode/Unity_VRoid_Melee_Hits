using UnityEngine;
using System.Collections;

public class CursorScript : MonoBehaviour
{
    private void OnApplicationFocus(bool hasFocus)
    {
        //Set Cursor to not be visible
        Cursor.visible = false;
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        //Set Cursor to be visible
        Cursor.visible = true;
    }
}