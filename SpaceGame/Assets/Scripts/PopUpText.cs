using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUpText : MonoBehaviour
{
    public Rigidbody2D player;
    public Rigidbody2D popUpText;
    public float Distance;
    public float distanceNeeded = 2;
    public string scene;
    private Animator mAnimator;

    public Text text;
    public Button button;

    private void Update()
    {
        Distance = Vector2.Distance(player.transform.position, popUpText.transform.position);

        if(Distance <= distanceNeeded)
        {
            text.enabled = true;
            button.gameObject.SetActive(true);
        }

        if(Distance > distanceNeeded)
        {
            text.enabled = false;
            button.gameObject.SetActive(false);
        }

        Vector2 direction = player.transform.position - text.transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        float newangle = angle + 90;
        
        text.transform.rotation = Quaternion.Euler(Vector3.forward * newangle);
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene(scene);
    }
}