using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : LimitMovement
{
    [SerializeField]
    [Range(0, 20)]
    public float speed = 2f;

    Vector2 dir;

    public override void Start()
    {
        base.Start();
        dir = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        DirectionMovement();
        Movement();
    }

    void DirectionMovement()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);

            dir = pos - transform.position;

            Rotation();
        }

        dir = LimitEffects.BouncingEffect(this.transform, dir, maxXPos, maxYPos);
    }

    void Movement()
    {
        transform.position += new Vector3(dir.x, dir.y, 0).normalized * Time.deltaTime * speed;
    }

    void Rotation()
    {
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager._instance.MenuScene();
    }
}
