using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ClickPoints : MonoBehaviour
{
    public Text text1; public Text text2;
    public static int clicked;
    public static int percentage; public static string percentage2text;
    int var1;
    int points;
    string click2point;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        print("32 seconds remain.");
        yield return new WaitForSeconds(33); // wait 33 seconds
        Application.LoadLevel("EndGame");
        PercentageFix();
    }
    public void ClickPoint()
    {
        clicked = clicked + 1;
        print("Clicked =" + clicked);
    }
    void Update() {
        points = clicked * 100;
        click2point = points.ToString();
        text1.text = click2point;
        text2.text = percentage2text;
    }
    public void PercentageFix() {
        percentage = (clicked*100) / 119;
        print(percentage);
        if (percentage > 100) {
            var1 = (percentage - 100)*2;
            percentage = percentage - var1;
        }
        percentage2text = percentage.ToString();
        print(percentage2text);
    }
}