using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LimitMovement : MonoBehaviour
{
    // Limits
    public float minXPos;
    public float maxXPos;

    public float minYPos;
    public float maxYPos;


    private float padding;

    // Start is called before the first frame update
    public virtual void Start()
    {
        padding =  GetComponentInParent<SceneProperties>().padding;

        // Setting X and Y limits
        minXPos = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        maxXPos = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;

        minYPos = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        maxYPos = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }
}
