using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttemptsScore : MonoBehaviour
{
    public int timesdied;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        timesdied = 0;
        score.text = timesdied.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = timesdied.ToString();
    }
    public void AddScore()
    {
        timesdied = timesdied + 1;
        score.text = timesdied.ToString();
    }
}
