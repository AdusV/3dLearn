using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Vector2 hotspotCursor;
    public Texture2D textureCursor;

    private void Start()
    {
        Cursor.SetCursor(textureCursor, hotspotCursor, CursorMode.Auto);

    }
}
