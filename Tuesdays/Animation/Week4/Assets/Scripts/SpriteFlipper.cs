using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    private SpriteRenderer playerSR;

    // Start is called before the first frame update
    void Start()
    {
        playerSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerSR.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerSR.flipX = true;

        }
    }
}
