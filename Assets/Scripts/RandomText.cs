using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    public static float score;
    public Slider slider;
    public  GameObject[] text;
    private int textIndex;
    public static bool aa;
    public static bool bb;
    public static bool cc;
    public GameObject wrongText;
    public GameObject sadFace;

    private void Start()
    {
        slider.GetComponent<Slider>().maxValue = 500;
        score = 0;
    }

    void Update()
    {
        if (Drag.isWrong == true && bb==false)
        {
            StartCoroutine(WrongText());
            bb = true;
        }


        if (Drag.isOkay == true && aa==false)
        {
            textIndex = Random.Range(0, text.Length);
            StartCoroutine(TextRandom());
            aa = true;

        }
        slider.value = score;

        if (Drag.isSad == true && cc == false)
        {
            StartCoroutine(SadImage());
            cc = true;
        }

    }


    IEnumerator TextRandom()
    {

        text[textIndex].SetActive(true);

        yield return new WaitForSeconds(1);

        text[textIndex].SetActive(false);

    }


    IEnumerator WrongText()
    {

        wrongText.SetActive(true);

        yield return new WaitForSeconds(1);

        wrongText.SetActive(false);

    }


    IEnumerator SadImage()
    {

        sadFace.SetActive(true);

        yield return new WaitForSeconds(1);

        sadFace.SetActive(false);

    }
}
