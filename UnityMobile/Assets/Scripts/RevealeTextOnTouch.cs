using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RevealeTextOnTouch : MonoBehaviour
{
    [SerializeField] GameObject playButton;
    [SerializeField] TMP_Text TitleToReavel;
    [SerializeField] TMP_Text TitleToUpdate;
    [SerializeField] TMP_Text ChangingMassage;
    [SerializeField] TMP_Text FirstChangingMassage;
    [SerializeField] TMP_Text SecondChangingMassage;
    [SerializeField] int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                
                if(counter<=TitleToReavel.text.Length)
                {
                    TitleToUpdate.text += TitleToReavel.text[counter];
                    counter++;
                }

                if (counter == 3)
                {
                    ChangingMassage.color = Color.yellow;
                    ChangingMassage.text = FirstChangingMassage.text;
                }

                if (counter == TitleToReavel.text.Length )
                {
                    ChangingMassage.color = Color.green;
                    ChangingMassage.text = SecondChangingMassage.text;
                    playButton.SetActive(playButton);
                }

            }
        }

    }
}
