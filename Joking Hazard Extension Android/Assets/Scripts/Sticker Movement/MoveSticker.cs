﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSticker : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;
    public static bool canFuckWith = true;
    public BoxCollider2D stickerCollider;

    void Update()
    {
        if (canFuckWith)
        {
            stickerCollider.enabled = true;
            if (isBeingHeld == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                
                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 95);
            }
        }
        else
        {
            
            stickerCollider.enabled = false;
        }

    }

    private void OnMouseDown()
    {
        if (canFuckWith)
        {
            if (Input.GetMouseButtonDown(0))
            {
                    Vector3 mousePos;
                    mousePos = Input.mousePosition;
                    mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                    startPosX = mousePos.x - this.transform.localPosition.x;
                    startPosY = mousePos.y - this.transform.localPosition.y;

                    isBeingHeld = true;   
            }
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

    public void NoFuck()
    {
        canFuckWith = false;
        print("No Fuck " + canFuckWith);

    }

    public void YesFuck()
    {
        canFuckWith = true;
        print("Yes Fuck " + canFuckWith);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (!isBeingHeld)
        {
            SFX.Playsound("trash");
            Destroy(gameObject);
        }
    }
}
