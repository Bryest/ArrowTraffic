using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LimitEffects
{
    public static Vector3 BouncingEffect(Transform t, Vector3 direction, float maxXPos, float maxYPos)
    {
        if (Mathf.Abs(t.position.x) >= maxXPos)
        {
            direction.x *= -1;
        }
        if (Mathf.Abs(t.position.y) >= maxYPos)
        {
            direction.y *= -1;
        }

        return direction;
    }
}
