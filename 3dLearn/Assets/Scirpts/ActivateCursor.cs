using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCursor : MonoBehaviour
{
    public Vector2 hotspotActive;  
    public Texture2D textureCursorActive;
    public Vector2 hotspotNormal;
    public Texture2D textureCursorNormal;


    private void OnMouseEnter()
    {
        Cursor.SetCursor(textureCursorActive, hotspotActive, CursorMode.ForceSoftware);
    }
    private void OnMouseExit()
    {
        Cursor.SetCursor(textureCursorNormal, hotspotNormal, CursorMode.ForceSoftware);
    }
}
