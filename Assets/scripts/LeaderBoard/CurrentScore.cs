using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI ScoreText;
    void Start()
    {
        ScoreText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + Score_counter.instance.score.ToString();
    }
}
