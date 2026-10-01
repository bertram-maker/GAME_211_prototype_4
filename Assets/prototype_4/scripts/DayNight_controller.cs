using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DayNight_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public new Light2D light;
    public new Light2D sun;
    public SpriteRenderer SR;
    public float timer;
    public bool reverse;
    public static bool isDay;
    void Start()
    {
        light.intensity = 1;
        sun.intensity = 3; 
    }

    // Update is called once per frame
    void Update()
    {
        //light.intensity = Mathf.Lerp(light.intensity, 50, Time.deltaTime);
        if (!reverse)
        {
            light.intensity += Time.deltaTime;
            if  (light.intensity >= 20)
            {
                reverse = true;
            }
        }
        else if (reverse)
        {
            light.intensity -= Time.deltaTime;
            if (light.intensity < 1)
            {
                reverse = false;
            }
        }

        if (light.intensity > 10)
        {
            SR.color = Color.yellow;
            sun.color = Color.yellow;
            sun.intensity = 40;
            isDay = true;
        }
        else if (light.intensity < 10)
        {
            SR.color = Color.white;
            sun.color = Color.white;
            sun.intensity = 3;
            isDay = false;
        }
        //light.intensity = timer;
    }
}
