using UnityEngine;

public class SineSumMovement : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;

    [Header("Axis")]
    public bool Xaxis = false;
    public bool Yaxis = false;
    public bool Zaxis = false;

    [Header("Cube 1 Values")]
    public float Cube1X;
    public float Cube1Y;
    public float Cube1Z;

    [Header("Cube 2 Values")]
    public float Cube2X;
    public float Cube2Y;
    public float Cube2Z;

    [Header("Cube Position")]
    public float Xposition = 0;
    public float Yposition = 0;
    public float Zposition = 0;

    private void Start()
    {
        Cube1X = Cube1.transform.position.x;
        Cube1Y = Cube1.transform.position.y;
        Cube1Z = Cube1.transform.position.z;

        Cube2X = Cube2.transform.position.x;
        Cube2Y = Cube2.transform.position.y;
        Cube2Z = Cube2.transform.position.z;
    }

    void Update()
    {
        if(Xaxis)
        {
            Xposition = Cube1X + Cube2X;
        }
        else if (Yaxis)
        {
            Yposition = Cube1Y + Cube2Y;
        }
        else if (Zaxis)
        {
            Zposition = Cube1Z + Cube2Z;
        }
        else
        {
            Yaxis = true;
        }
    }
}
