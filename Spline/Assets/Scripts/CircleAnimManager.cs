using UnityEngine;
using UnityEngine.Splines;

public class CircleAnimManager : MonoBehaviour
{
    public SplineAnimate splineAnimate;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            splineAnimate.Play();
        }
    }
}
