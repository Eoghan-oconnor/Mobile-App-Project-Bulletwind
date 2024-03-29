﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // need to keep the player within the main camera
    //== fields ==
    public Camera mainCamera;

    private Vector2 screenBounds;

    private float objectWidth, objectHeight;

    
    // Start is called before the first frame update
    void Start()
    {
        // find the screen bounds and convert to unity 
        screenBounds = mainCamera.ScreenToWorldPoint(
                            new Vector3(Screen.width,
                                        Screen.height,
                                        mainCamera.transform.position.z));

        objectWidth = gameObject.GetComponent<SpriteRenderer>().bounds.extents.x;
        objectHeight = gameObject.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;

        viewPos.x = Mathf.Clamp(viewPos.x,
                                screenBounds.x * -1 + objectWidth,
                                screenBounds.x - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y,
                                screenBounds.y * -1 + objectHeight,
                                screenBounds.y - objectHeight);
        transform.position = viewPos;
    }

}
