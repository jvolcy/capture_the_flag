using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonCtrl : MonoBehaviour
{
    public float RestAngle = 9f;
    public float Angle = 0f;
    private float prevAngle = 0f;
    public float MinAngle = 0f;     //tbi
    public float MaxAngle = 90f;    //tbi
    public float TNT = 500f;
    public float MinTNT = 100f;     //tbi
    public float MaxTNT = 2000f;    //tbi
    public float MinWind = -20f;    //tbi
    public float MaxWind = 20f;     //tbi
    public GameObject gun;
    public Transform muzzle;    //transform of the canon's muzzle

    public CanonBall CanonBallPrefab;
    public Sprite[] OrbSprites;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCanonOnScreen();
    }

    // Update is called once per frame
    void Update()
    {

        UpdateCanonOnScreen();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    // Update canon angle on screen
    void UpdateCanonOnScreen()
    {
        if (Angle != prevAngle)
        {
            
            gun.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, (RestAngle - Angle) * Mathf.Sign(transform.localScale.x)));
            prevAngle = Angle;
        }
    }


    public void Fire()
    {
        CanonBall canonBall;
        //Transform orbTransform = new Transform();

        //orbTransform.position = new Vector3(0f, 6f, 0f);

        canonBall = Instantiate(CanonBallPrefab, null);
        canonBall.StartX = muzzle.position.x;
        canonBall.StartY = muzzle.position.y;
        canonBall.Angle = Angle;
        canonBall.Force = TNT;

        canonBall.CanonBallSprite = OrbSprites[Random.Range(0, OrbSprites.Length)];

        /*
        SpriteRenderer spriteRenderer = canonBall.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = OrbSprites[Random.Range(0, OrbSprites.Length)];
        */

    }
}
