using UnityEngine;

public class cameralimit : MonoBehaviour
{
    public Transform target; 
    public float minY;       

    void LateUpdate()
    {
        Vector3 pos = transform.position;

        pos.x = target.position.x;

        if (target.position.y > minY)
        {
            pos.y = target.position.y;
        }
        else
        {
            pos.y = minY;
        }

        transform.position = pos;
    }
}
