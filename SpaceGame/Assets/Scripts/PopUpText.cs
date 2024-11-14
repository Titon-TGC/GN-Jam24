using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpText : MonoBehaviour
{
    public Rigidbody2D player;
    public Rigidbody2D popUpText;
    public float Distance;
    private Animator mAnimator;

    public Text text;

    private void Update()
    {
        Distance = Vector2.Distance(player.transform.position, popUpText.transform.position);

        if(Distance <= 2)
        {
            text.enabled = true;
        }

        if(Distance > 2)
        {
            text.enabled = false;
        }
    }
}