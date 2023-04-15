using DefaultNamespace;
using TMPro;
using UnityEngine;

public class SurpriseView : BaseView
{
	private int initSupriseValue;
	private TextMeshProUGUI _text;
	void Awake()
	{
		initSupriseValue = Random.Range(1, 1000);
		_text = gameObject.GetComponentInChildren<TextMeshProUGUI>();
	}

	protected override void onClickInternal()
	{
		_text.text = $"surprise in: {initSupriseValue}";
		initSupriseValue /= Random.Range(1, 19);
		if (initSupriseValue == 0)
		{
		  _text.text = "congratz!!";
		}
	}

}
