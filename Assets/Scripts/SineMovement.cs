using UnityEngine;

public class SineMovement : MonoBehaviour
{
    [Header("Axis")]
    public bool Xaxis = false;
    public bool Yaxis = false;
    public bool Zaxis = false;

    [Header("Values")]
    public int Amplitude = 1;
    public int Frequency = 1;
    public float TimePassed = 0;

    [Header("Position")]
    public int Xposition = 0;
    public int Yposition = 0;
    public int Zposition = 0;
    void Start()
    {
        
    }
    void Update()
    {
        TimePassed += Time.deltaTime;

        if (Xaxis)
        {
            transform.position = new Vector3(Amplitude * Mathf.Sin(Frequency * TimePassed), Yposition, Zposition);
        }
        else if (Yaxis)
        {
            transform.position = new Vector3(Xposition, Amplitude * Mathf.Sin(Frequency * TimePassed), Zposition);
        }
        else if (Zaxis)
        {
            transform.position = new Vector3(Xposition, Yposition, Amplitude * Mathf.Sin(Frequency * TimePassed));
        }
        else
        {
            Yaxis = true;
        }
    }
}
