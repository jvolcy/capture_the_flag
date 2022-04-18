using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonCtrl : MonoBehaviour
{
    public float RestAngle = 9f;
    public float Angle;
    private float mAngle;

    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCanonOnScreen();
    }

    // Update is called once per frame
    void Update()
    {
        if (Angle != mAngle)
        {
            mAngle = Angle;
            UpdateCanonOnScreen();
        }
    }

    // Update canon angle on screen
    void UpdateCanonOnScreen()
    {
        gun.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, (RestAngle - mAngle) * Mathf.Sign(transform.localScale.x)));
    }

}
