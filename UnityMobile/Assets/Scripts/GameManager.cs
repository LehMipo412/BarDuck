using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject targetToDestroy;

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {

                if (targetToDestroy != null)
                    Destroy(targetToDestroy);

            }
        }
        
    }
}
