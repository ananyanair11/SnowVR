using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TeleportationUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* GameObject player = GameObject.Find("XR Rig");
         if (player.transform.position.x < 0)
         {
             ChangePosition();
         } */
    }

   public void onPress()
    {
        ChangePosition();
    }
    void ChangePosition()
    {
        GameObject player = GameObject.Find("XR Rig");
        player.transform.position = new Vector3(7.63f, 1.8f, 174.7f);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
