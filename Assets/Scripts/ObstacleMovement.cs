using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class ObstacleMovement : LimitMovement
{
    // Movement
    [SerializeField]
    [Range(1, 20)]
    private float speed = 1f;

    private Vector3 dir;

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        // Initialize Random Movement
        dir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        dir = LimitEffects.BouncingEffect(this.transform, dir, maxXPos,maxYPos);
        Movement(dir, this.transform);
    }

    void Movement(Vector3 direction, Transform t)
    {
        // Movement in game
        Vector3 delta = direction.normalized * Time.deltaTime * speed;

        // Limits in Movement
        float newXPos = Mathf.Clamp(t.position.x + delta.x, minXPos, maxXPos);
        float newYPos = Mathf.Clamp(t.position.y + delta.y, minYPos, maxYPos);

        Vector2 movement = new Vector2(newXPos, newYPos);

        t.position = movement;
    }
}
