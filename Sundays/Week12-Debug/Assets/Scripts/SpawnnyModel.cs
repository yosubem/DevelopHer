using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnnyModel : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.AddComponent<Image>();
        gameObject.AddComponent<Rigidbody2D>();
    }

    // Update is called once per frame
  
}
