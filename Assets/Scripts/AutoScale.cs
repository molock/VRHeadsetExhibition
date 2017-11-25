using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScale : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 1.5f;
    public float scaleRate = 0.5f;
    static float t = 0.0f;

    private bool is_growing = true;

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.Lerp(minScale, maxScale, t);

        transform.localScale = new Vector3(scale, scale, scale);

        if (is_growing) {
            t += scaleRate * Time.deltaTime;
        } else {
            t -= scaleRate * Time.deltaTime;
        }
 
        if (t >= 1) {
            is_growing = false;
        } else if (t <= 0) {
            is_growing = true;
        }

    }
}