using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CockpitController : MonoBehaviour
{
    public Button fireButton;
    public Button fireButtonTwo;
    void Start()
    {
        //Add listner botão
        fireButton.onClick.AddListener(Fire);
        fireButtonTwo.onClick.AddListener(FireTwo);

    }

    // Update is called once per frame
    void Fire()
    {
        GameObject laser = Instantiate(Resources.Load(("Bullet"), typeof(GameObject))) as GameObject;
        laser.transform.position = Camera.main.transform.position;
        laser.transform.rotation = Camera.main.transform.rotation;

        laser.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 500f);
        laser.GetComponent<AudioSource>().Play();
        Destroy(laser, 3f);
    }

    void FireTwo()
    {
        GameObject laserTwo = Instantiate(Resources.Load(("AnotherBullet"), typeof(GameObject))) as GameObject;
        laserTwo.transform.position = Camera.main.transform.position;
        laserTwo.transform.rotation = Camera.main.transform.rotation;

        laserTwo.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 500f);
        laserTwo.GetComponent<AudioSource>().Play();
        Destroy(laserTwo, 3f);
    }
}

