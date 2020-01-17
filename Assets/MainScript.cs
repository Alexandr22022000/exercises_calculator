using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//C - KeyCode.Joystick1Button0
//A - KeyCode.Joystick1Button1
//B - KeyCode.Joystick1Button2


public class MainScript : MonoBehaviour
{
    public GameObject tablo;
    int counter = 0;
    bool gamepadClick = false;
    float timer = -1;

    // Start is called before the first frame update
    void Start()
    {
        tablo.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && !gamepadClick) OnAdd();
        gamepadClick = Input.anyKey;

        if (timer != -1)
        {
            timer += Time.deltaTime;
            if (timer >= 0.3) timer = -1;
        }
    }

    public void OnAdd ()
    {
        if (timer != -1) return;
        timer = 0;

        counter++;
        tablo.GetComponent<Text>().text = counter.ToString();
    }

    public void OnReset ()
    {
        counter = 0;
        tablo.GetComponent<Text>().text = counter.ToString();
    }
}
