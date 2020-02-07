using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintable : MonoBehaviour
{

    public GameObject brush;
    public float brushSize = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit paint;
            if(Physics.Raycast(ray, out paint))
            {
                var go = Instantiate(brush, paint.point + Vector3.back * 0.1f, Quaternion.Euler(-90,0,0), transform);
                go.transform.localScale = Vector3.one * brushSize;
            }
        }
    }
}
