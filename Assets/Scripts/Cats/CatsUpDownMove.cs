using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsUpDownMove : MonoBehaviour
{
    private Vector2 catsPosition;
    [SerializeField] float speed = 1f;
    [SerializeField] float downY = 3f;
    private int direction = -1;
    private Vector2 catsStartPosition;

    Vector2 UpPoint;
    Vector2 DownPoint;

    [SerializeField] bool isStartDirectionUp; 


    private void Start()
    {
        catsStartPosition = transform.position;
    }

    void Update()
    {
        catsPosition = transform.position;
        transform.Translate(transform.up * Time.deltaTime * speed * direction);

        if (!isStartDirectionUp)
        {
            UpPoint = catsStartPosition;
            DownPoint = new Vector2(catsStartPosition.x, catsStartPosition.y - downY);

            if (catsPosition.y > UpPoint.y)
            {
                direction = -1;
            }
            if (catsPosition.y < DownPoint.y)
            {
                direction = 1;
            }
        }

        if(isStartDirectionUp)
        {
            DownPoint = catsStartPosition;
            UpPoint = new Vector2(catsStartPosition.x, catsStartPosition.y + downY);

            if (catsPosition.y > UpPoint.y)
            {
                direction = -1;
            }
            if (catsPosition.y < DownPoint.y)
            {
                direction = 1;
            }
        }
    }
}
