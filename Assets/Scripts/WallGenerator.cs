using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject wall, wall_corner, ground1, ground2, ground3;
    void Start()
    {
        Instantiate(wall_corner, new Vector2(-30, 30), Quaternion.AngleAxis(90 * 0, Vector3.forward));
        Instantiate(wall_corner, new Vector2(-30, -30), Quaternion.AngleAxis(90 * 1, Vector3.forward));
        Instantiate(wall_corner, new Vector2(30, -30), Quaternion.AngleAxis(90 * 2, Vector3.forward));
        Instantiate(wall_corner, new Vector2(30, 30), Quaternion.AngleAxis(90 * 3, Vector3.forward));
        for (int j = 0; j < 14; j++)
        {
            Instantiate(wall, new Vector2(-26 + 4 * j, 30), Quaternion.AngleAxis(90 * 0, Vector3.forward));
        }
        for (int j = 0; j < 14; j++)
        {
            Instantiate(wall, new Vector2(-30, -26 + 4 * j), Quaternion.AngleAxis(90 * 1, Vector3.forward));
        }
        for (int j = 0; j < 14; j++)
        {
            Instantiate(wall, new Vector2(30, -26 + 4 * j), Quaternion.AngleAxis(90 * 3, Vector3.forward));
        }
        for (int j = 0; j < 14; j++)
        {
            Instantiate(wall, new Vector2(-26 + 4 * j, -30), Quaternion.AngleAxis(90 * 2, Vector3.forward));
        }
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                int r = Random.Range(0, 3);
                if (r == 0)
                {
                    Instantiate(ground1, new Vector2(-26 + 4 * j, -26 + 4 * i), Quaternion.identity);
                }
                if (r == 1)
                {
                    Instantiate(ground2, new Vector2(-26 + 4 * j, -26 + 4 * i), Quaternion.identity);
                }
                if (r == 2)
                {
                    Instantiate(ground3, new Vector2(-26 + 4 * j, -26 + 4 * i), Quaternion.identity);
                }

            }
        }
    }

}
