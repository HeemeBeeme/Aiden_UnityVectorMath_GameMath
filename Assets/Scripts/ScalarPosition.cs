using UnityEngine;

public class ScalarPosition : MonoBehaviour
{
    public float step;
    public float scalar = 1;
    public Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            scalar += step;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            scalar -= step;
        }

        transform.position = startPos * scalar;

    }
}
