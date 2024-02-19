using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Text timeText;
    [SerializeField] float duration, currentTime;

    void Start()
    {
        //panel.SetActive(false);
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }

    IEnumerator TimeIEn()
    {
        while(currentTime >= 0)
        {
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        // OpenPanel();
        SceneManager.LoadScene("GameOverScene");
    }

    void OpenPanel()
    {
        timeText.text = "";
        //panel.SetActive(true);
    }
}
