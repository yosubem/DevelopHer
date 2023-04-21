using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class LoadingScreen : MonoBehaviour{
	public float loadTime;      //Specifies the toatl time to load all assets (in seconds)
	public Slider progressBar;  //Display the current loading progress (as a value between 0 and 1)


	private void Start() {
		MockLoading();
		var obj =  ResourcesLoading("Prefab/TestPrefab");
	}

	/*public async UniTask LoadingTestSO(string path) {
		TestSO tSO = (TestSO)AssetDatabase.LoadAssetAtPath(path, typeof(TestSO));
	}*/

	public async UniTask MockLoading() {
		Debug.Log("Before");
		await UniTask.Delay(5000);
		Debug.Log("After");
	}

	public async UniTask<GameObject> ResourcesLoading(string path) {
		var asset = await Resources.LoadAsync<GameObject>(path);
		Debug.Log((GameObject)asset);
		Debug.Log("Loaded Prefab");
		return (GameObject)asset;

	}
}
