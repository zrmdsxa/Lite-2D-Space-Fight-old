using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FireGun : MonoBehaviour
{


    public Transform bullet;

	public float bulletSpeed = 3.0f;
    public float rateOfFire = 10;
    float cooldown = 0.0f;

	public bool isPlayer = false;
	Rigidbody m_rb;



    // Use this for initialization
    void Start()
    {
		m_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (cooldown < 1 / rateOfFire)
            {
                cooldown += Time.deltaTime;
            }

        if (isPlayer)
        {
            

            if (Input.GetAxis("FireGun") != 0)
            {
                if (cooldown >= 1 / rateOfFire)
                {
					cooldown = 0.0f;
                    Transform b = Instantiate(bullet, transform.position, transform.rotation) as Transform;
					b.gameObject.GetComponent<AllyBulletScript>().setVelocity(m_rb.velocity * bulletSpeed);
                }
            }
        }
    }
}
