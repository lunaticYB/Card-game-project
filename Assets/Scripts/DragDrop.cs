using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartDrag()
    {
        isDragging = true;
        
    }

    public void EndDrag()
    {
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log("drag check");
        }
    }

    
}
