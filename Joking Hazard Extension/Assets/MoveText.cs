using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;
    public BoxCollider2D boxCollider;
    Vector3 temp;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
            //boxCollider.enabled = true;
            if (isBeingHeld == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                //mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3((mousePos.x - startPosX), (mousePos.y - startPosY), 90);
            }
    }

    private void OnMouseDown()
    {
        
            if (Input.GetMouseButtonDown(0))
            {
              
                    Vector3 mousePos;
                    mousePos = Input.mousePosition;
                    //mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                    startPosX = mousePos.x - this.transform.localPosition.x;
                    startPosY = mousePos.y - this.transform.localPosition.y;

                    isBeingHeld = true;
              
            }
        
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

}
