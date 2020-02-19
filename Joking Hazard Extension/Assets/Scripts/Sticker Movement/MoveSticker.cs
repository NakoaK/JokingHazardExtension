    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSticker : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;
    public bool canScale = false;
    public bool canRotate = false;
    public static bool canFuckWith = true;
    public  bool doubleClick = false;
    public GameObject stickers;
    public BoxCollider2D stickerCollider;
    Vector3 temp;
    public BoxCollider2D TrashCollider;


    void Start()
    {
        //boxCollider = GetComponent<BoxCollider2D>();
        //TrashCollider = GetComponent<BoxCollider2D>();
        
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
            if (canScale == true)
            {
                temp = transform.localScale;

                temp.x += Input.GetAxis("Mouse X");
                //temp.y += Input.GetAxis("Mouse Y");
                if (temp.x > 0)
                {
                    temp.y = temp.x;
                }
                else
                {
                    temp.y = temp.x * -1;
                }
                transform.localScale = temp;
            }
            if (canRotate == true)
            {

                transform.Rotate(0, 0, Input.GetAxis("Mouse X") * 8);
            }
            if(doubleClick == true)
            {
                Destroy(gameObject);
                doubleClick = false;
            }
        }
        else
        {
            stickerCollider.enabled = false;
        }

    }

    public void FixedUpdate()
    {
        checkToDestroy();
    }

    private void OnMouseDown()
    {
        if (canFuckWith)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.GetKey(KeyCode.LeftAlt))
                {
                    canScale = true;
                    canRotate = false;
                    isBeingHeld = false;
                }
                else if (Input.GetKey(KeyCode.LeftShift))
                {
                    canRotate = true;
                    canScale = false;
                    isBeingHeld = false;
                }
                else
                {
                    Vector3 mousePos;
                    mousePos = Input.mousePosition;
                    mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                    startPosX = mousePos.x - this.transform.localPosition.x;
                    startPosY = mousePos.y - this.transform.localPosition.y;

                    isBeingHeld = true;
                    canScale = false;
                    canRotate = false;
                }
            }
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
        canScale = false;
        canRotate = false;
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


    private void checkToDestroy()
    {
        //if (boxCollider.IsTouching(TrashCollider))
        //{
        //    Destroy(gameObject);
        //    print("destroyed");
        //}
        //else
        //{
        //    print("did not touch trash");
        //}

        //print(boxCollider.IsTouching(TrashCollider));
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
