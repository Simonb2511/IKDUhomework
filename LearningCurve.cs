using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    private int CurrentLevel= 1;

    private int addedLevel = 1;
    public string Name;


    // Start is called before the first frame update
    void Start()
    {
        ShowCharacterInfo();
        AddLv();

        
    }

    void ShowCharacterInfo()
    {
        Debug.Log("What is the name of character?");
        Debug.Log(Name);
        Debug.LogFormat("The character {0} has current level = {1}", Name, CurrentLevel);


         
    }

    void AddLv() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentLevel = CurrentLevel + addedLevel;
            Debug.Log(CurrentLevel);
        }
    }
      

// Update is called once per frame
void Update()
    {
        AddLv();

    }



  
    
    
    
}
