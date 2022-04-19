using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonCtrl : MonoBehaviour
{
    public float RestAngle = 9f;
    public float Angle;
    private float mAngle;
    public float MinAngle = 0f;     //tbi
    public float MaxAngle = 90f;    //tbi
    public float TNT = 500f;
    public float MinTNT = 100f;     //tbi
    public float MaxTNT = 2000f;    //tbi
    public float MinWind = -20f;    //tbi
    public float MaxWind = 20f;     //tbi
    public OrbFactory orbFactory;
    public GameObject gun;
    public Transform muzzle;    //transform of the canon's muzzle

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
        if (Angle != mAngle)
        {
            mAngle = Angle;
            orbFactory.LaunchAngle = mAngle;
            UpdateCanonOnScreen();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            orbFactory.TNT = TNT;
            orbFactory.Fire();
        }
    }

    // Update canon angle on screen
    void UpdateCanonOnScreen()
    {
        gun.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, (RestAngle - mAngle) * Mathf.Sign(transform.localScale.x)));
    }

}
