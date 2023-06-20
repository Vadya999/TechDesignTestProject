using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
    public Action hitAction;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) 
            {
                if (hit.collider.gameObject == gameObject)
                {
                    hitAction?.Invoke();
                }
            }
        }
    }
}
