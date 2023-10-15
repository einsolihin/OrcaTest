using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float focusMeter = 0;
    [SerializeField] private float calmMeter = 0;

    public Slider focusSlider;
    public Slider calmSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (focusSlider != null)
            focusSlider.value = focusMeter;
        if (calmSlider != null)
            calmSlider.value = calmMeter;
    }

    public void setFocusMeter(float meter)
    {
        focusMeter = meter;
    }

    public void setCalmMeter(float meter)
    {
        calmMeter = meter;
    }

    public float getFocusMeter()
    {
        return focusMeter;
    }

    public float getCalmMeter()
    {
        return calmMeter;
    }
}
