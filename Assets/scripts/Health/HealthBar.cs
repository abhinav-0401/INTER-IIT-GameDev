using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    Image health_Bar;
    float current_health_value, max_health_value;

    void Start()
    {
        health_Bar = GetComponent<Image>();
        max_health_value = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.parent.parent.name == "TestPlayer 1")
        {
            current_health_value = Character_Health.instance.character_health_1;
        }
        else
        {
            current_health_value = Character_Health.instance.character_health_2;
        }
        health_Bar.fillAmount = current_health_value/max_health_value;
    }
}
