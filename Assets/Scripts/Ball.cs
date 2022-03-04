using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().scoreUp();
        Destroy(gameObject);
    }
}
