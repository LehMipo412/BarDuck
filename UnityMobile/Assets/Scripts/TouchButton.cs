using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchButton : MonoBehaviour 
{
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
   
}
