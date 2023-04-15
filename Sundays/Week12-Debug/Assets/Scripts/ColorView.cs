using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ColorView : BaseView
{
	[SerializeField] private Image _image;
	// Start is called before the first frame update
   

	protected override void onClickInternal()
	{
		Debug.Log("clicked!");
		float r = Random.Range(0f, 1f);
		float g = Random.Range(0f, 1f);
		float b = Random.Range(0f, 1f);
		_image.color = new Color(r, g, b);
	}


	// Update is called once per frame
	void Update()
	{
		
		System.Random random = new System.Random();
		int randomNumber = random.Next();
		if (randomNumber % 1000 == 0) // checking if it divides by 10000 or not 
		{
			/*try
			{
				throw new Exception();
			}
			catch (Exception e)
			{
				Debug.LogError($"error: {e} {randomNumber}\n");
			}*/
		}
	   
	}
}
