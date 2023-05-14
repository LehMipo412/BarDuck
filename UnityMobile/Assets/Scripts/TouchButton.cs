using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TouchButton : MonoBehaviour 
{

   
    // Start is called before the first frame update

    private void OnMouseDown()
    {

        SceneManager.LoadScene(4);
        Destroy(gameObject);
    }
   
}
