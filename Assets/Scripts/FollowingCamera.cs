using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    float cameraOffset = 12.0f;
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float charPosX = player.transform.position.x;
        float charPosZ = player.transform.position.z;


        transform.position = new Vector3(charPosX, cameraOffset, charPosZ);
    }
}
//