using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    private Vector3 target = new Vector3(-3, 1,0);
    private float duration = 1.5f;
    public Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!tweener.TweenExists(transform))
        {
            if (transform.position.x < 0)
            {
                target = new Vector3(3, 1, 0);
            }
                
            else if (transform.position.x > 0)
            {
                target = new Vector3(-3, 1, 0);
            }

            tweener.AddTween(transform, transform.position, target, duration/SpeedManager.SpeedModifier);
           
            

        }
    }
}
