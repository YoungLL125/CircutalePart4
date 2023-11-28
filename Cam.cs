using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject player;
    public int viewLayer;
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, viewLayer);
    }
}
