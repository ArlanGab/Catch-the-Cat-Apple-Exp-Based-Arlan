using UnityEngine;
using System.Collections;

public class BasketM : MonoBehaviour
{

    [SerializeField]
    private Vector3 velocity = new Vector3(1, 0, 0);

    private Transform cachedTransform;

    void Start()
    {
        // cache for faster access
        this.cachedTransform = this.transform;
    }

    void Update()
    {
        // check right movement
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 displacement = velocity * Time.deltaTime;
            cachedTransform.Translate(displacement);
        }

        // check left movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Vector3 displacement = -velocity * Time.deltaTime;
            cachedTransform.Translate(displacement);
        }
    }

}
