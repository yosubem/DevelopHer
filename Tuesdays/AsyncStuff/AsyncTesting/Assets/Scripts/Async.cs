using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Async : MonoBehaviour {

	List<Task> tasks = new List<Task>();
	// Start is called before the first frame update
	async void Start() {
		//Debug.Log("Hello");
		//SumStuff(3, 14);
		//await MultiStuff(3, 14);
		//Debug.Log("There");

		await FinalStuff();



		/*Task t = Task.WhenAll(tasks);
		if(t.IsCompleted) {
			Debug.Log("I'm all done!");
		}*/




	}

	// Update is called once per frame
	void Update() {

	}


	public async void SumStuff(int a, int b) {
		await Task.Delay(1000);
		Debug.Log("Sum: " + (a + b));
	}

	public async Task MultiStuff(int a, int b) {
		await Task.Delay(1000);
		Debug.Log("Multi: " + (a * b));
		await MoreStuff(a * b);
	}

	public async Task MoreStuff(int num) {
		await Task.Delay(1000);
		Debug.Log("The answer for everything is: " + num);
		SumStuff(num, num);
	}


	private async Task FinalStuff() {
		var aTask = MultiStuff(3, 14);
		var bTask = MoreStuff(42);
		tasks.Add(aTask);
		tasks.Add(bTask);

		await Task.WhenAll(tasks);
		Debug.Log("I'm all done!");
	}
}
