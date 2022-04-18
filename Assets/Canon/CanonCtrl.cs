using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonCtrl : MonoBehaviour
{
    public float RestAngle = 9f;
    public float Angle;
    public float TNT = 500f;
    private float mAngle;
    public OrbFactory orbFactory;
    public GameObject gun;
    public Transform muzzle;

    // Start is called before the first frame update
    void Start()
    {
        mAngle = Angle;
        orbFactory.LaunchAngle = mAngle;
        orbFactory.muzzle = muzzle;
        UpdateCanonOnScreen();
    }

    // Update is called once per frame
    void Update()
    {
        orbFactory.TNT = TNT;
        if (Angle != mAngle)
        {
            mAngle = Angle;
            orbFactory.LaunchAngle = mAngle;
            UpdateCanonOnScreen();
        }
    }

    // Update canon angle on screen
    void UpdateCanonOnScreen()
    {
        gun.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, (RestAngle - mAngle) * Mathf.Sign(transform.localScale.x)));
    }

}
