using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }
    //Camera Follows Player
    void Update()
    {
        transform.position = Player.transform.position+new Vector3(2, 0, -17);
    }
}
