using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
    public Action hitAction;
    [SerializeField] private Camera mainCamera;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

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
