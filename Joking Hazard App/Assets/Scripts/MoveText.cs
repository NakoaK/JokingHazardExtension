using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveText : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;
    public bool canMove;
    public BoxCollider2D boxCollider;
    Vector3 tempPosition;
    Vector3 tempScale;
    public GameObject playerText;
    private string resetText = "";

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        Vector3 tempPosition = new Vector3(transform.position.x, transform.position.y, 400);
    }

    void Update()
    {
            if (isBeingHeld == true)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                this.gameObject.transform.localPosition = new Vector3((mousePos.x - startPosX), (mousePos.y - startPosY), 400);
            }           
    }

    private void OnMouseDown()
    {
        if(canMove)
        {   
            if (Input.GetMouseButtonDown(0))
            {

                Vector3 mousePos;
                mousePos = Input.mousePosition;

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

    public void disableText()
    {
        canMove = false;
    }

    public void enableText()
    {
        canMove = true;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (!isBeingHeld)
        {
            
            SFX.Playsound("trash");
            playerText.gameObject.SetActive(false);
            transform.position = tempPosition;



        }
    }

    public void resetPosition()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 100);
        boxCollider.enabled = true;

    }

    public void resetScale()
    {
        transform.localScale = new Vector3(50, 50, 1); ;
    }

}
