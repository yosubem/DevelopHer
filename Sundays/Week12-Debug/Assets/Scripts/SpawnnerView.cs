
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class SpawnnerController : BaseView
{
    [SerializeField] private GameObject _toSpawn;
    protected override void onClickInternal()
    {
        GameObject newSpawnny = Instantiate(_toSpawn);
        newSpawnny.GetComponent<Image>().color = Color.blue;
        var rigidbody = newSpawnny.GetComponent<Rigidbody2D>();
        rigidbody.bodyType = RigidbodyType2D.Dynamic;

    }
}
