using UnityEngine;
using System.Collections;

public class EndingTrigger : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);

        //gameOver = true;
        Application.LoadLevel("sceGameOverTest");
       
        print("collision hit");
    }

    //bool gameOver = false;
    
    //public Texture gameOverTex;
    //void OnGUI()
    //{
    //   if (!gameOverTex)
    //   {
    //        Debug.LogError("Assign a Texture in the inspector");
    //        return;
    //   }
    //   if (gameOver == true)
    //   {
    //       GUI.DrawTexture(new Rect(0, 0, 800, 400), gameOverTex, ScaleMode.ScaleToFit, true, 0.0f);
    //   }
        
    //}

    
    
}
