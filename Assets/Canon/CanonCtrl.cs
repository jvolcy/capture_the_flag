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
    //public OrbFactory orbFactory;
    public GameObject gun;
    public Transform muzzle;    //transform of the canon's muzzle

    public CanonBall OrbPrefab;
    public Sprite[] OrbSprites;

    // Start is called before the first frame update
    void Start()
    {
        mAngle = Angle;
        //orbFactory.LaunchAngle = mAngle;
        //orbFactory.muzzle = muzzle;
        UpdateCanonOnScreen();
    }

    // Update is called once per frame
    void Update()
    {
        if (Angle != mAngle)
        {
            mAngle = Angle;
            //orbFactory.LaunchAngle = mAngle;
            UpdateCanonOnScreen();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //orbFactory.TNT = TNT;
            Fire();
        }
    }

    // Update canon angle on screen
    void UpdateCanonOnScreen()
    {
        gun.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, (RestAngle - mAngle) * Mathf.Sign(transform.localScale.x)));
    }


    public void Fire()
    {
        CanonBall orb;
        //Transform orbTransform = new Transform();

        //orbTransform.position = new Vector3(0f, 6f, 0f);

        orb = Instantiate(OrbPrefab, null);
        orb.transform.position = muzzle.position;
        //orb.transform.rotation = Quaternion.Euler(0f, 0f, LaunchAngle);
        orb.Angle = mAngle;
        orb.Force = TNT;

        SpriteRenderer spriteRenderer = orb.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = OrbSprites[Random.Range(0, OrbSprites.Length)];

    }
}
