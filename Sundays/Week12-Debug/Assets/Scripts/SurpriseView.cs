
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class Surprise : BaseView
{
    private int initSupriseValue;
    void Awake()
    {
        initSupriseValue = Random.Range(1, 1000);
    }

    protected override void onClickInternal()
    {
       initSupriseValue /= Random.Range(0, 19);

       if (initSupriseValue == 0)
       {
           gameObject.GetComponent<TextMeshProUGUI>().text = "congratz!!";
       }
    }

}
