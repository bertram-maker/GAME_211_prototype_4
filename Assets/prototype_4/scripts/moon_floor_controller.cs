using UnityEngine;
using UnityEngine.Rendering.Universal;


public class moon_floor_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light2D light;
    public Collider2D col;
    public SpriteRenderer SR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DayNight_controller.isDay)
        {
            light.intensity = 0;
            SR.color = Color.gray1;
            col.isTrigger = true;
        }
        else
        {
            light.intensity = 20;
            SR.color = Color.white;
            col.isTrigger = false;
        }
    }
}
