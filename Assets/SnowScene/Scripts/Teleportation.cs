using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
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
            player.transform.position = new Vector3(-76f, 68.7f, 162.3f);
    }
}
