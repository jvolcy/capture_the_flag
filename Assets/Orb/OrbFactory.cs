using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbFactory : MonoBehaviour
{
    public Orb OrbPrefab;
    public Sprite[] OrbSprites;
    public float LaunchAngle = 0f;
    public Transform muzzle;
    public float TNT = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Time.frameCount % 100 == 0)
        {
            Orb orb;
            //Transform orbTransform = new Transform();

            //orbTransform.position = new Vector3(0f, 6f, 0f);

            orb = Instantiate(OrbPrefab, null);
            orb.transform.position = muzzle.position;
            //orb.transform.rotation = Quaternion.Euler(0f, 0f, LaunchAngle);
            orb.Angle = LaunchAngle;
            orb.Force = TNT;

            SpriteRenderer spriteRenderer = orb.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = OrbSprites[Random.Range(0, OrbSprites.Length)];
        }
        */
    }


    // Update is called once per frame
    public void Fire()
    {
        Orb orb;
        //Transform orbTransform = new Transform();

        //orbTransform.position = new Vector3(0f, 6f, 0f);

        orb = Instantiate(OrbPrefab, null);
        orb.transform.position = muzzle.position;
        //orb.transform.rotation = Quaternion.Euler(0f, 0f, LaunchAngle);
        orb.Angle = LaunchAngle;
        orb.Force = TNT;

        SpriteRenderer spriteRenderer = orb.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = OrbSprites[Random.Range(0, OrbSprites.Length)];

    }
}
