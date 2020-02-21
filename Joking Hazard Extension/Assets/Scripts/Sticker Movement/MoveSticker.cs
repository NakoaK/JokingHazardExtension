    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSticker : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;
    public static bool canFuckWith = true;
    public GameObject stickers;
    public BoxCollider2D stickerCollider;
    Vector3 temp;
    private SpriteRenderer spriteOrder;


    void Start()
    {
        spriteOrder = GetComponent<SpriteRenderer>();
    }
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

                    spriteOrder.sortingOrder = 1;
                    isBeingHeld = true;   
            }
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
        spriteOrder.sortingOrder = 0
            ;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Trash")
            print("touching");

    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (!isBeingHeld)
            Destroy(gameObject);
    }
}
