using UnityEngine;
using System.Collections;

public class ShootProjectile : MonoBehaviour
{
    [SerializeField]
    gunType typeOfGun = gunType.MachineGun;
    [SerializeField]
    Rigidbody projectile;
    [SerializeField]
    float fireRate;
    [SerializeField]
    float accuracy;
    [SerializeField]
    float velocity;
    [SerializeField]
    float size = 1;
    [SerializeField]
    float magazineSize;
    [SerializeField]
    float reloadSpeed;

    public float damage;
    public float range;
    public float damageFallOff;
    public bool bulletDropOn;
    public float bulletDrop;
    public bool AoEOn;
    public float AoESize;

    enum gunType { MachineGun = 0, ShotGun = 1, Rifle = 2, LazerGun = 3 }
    float nextFireTime;
    float currentMagazineCount;
    bool isReloading;

    void Start()
    {
        isReloading = false;
        currentMagazineCount = magazineSize;
    }

    void FixedUpdate()
    {
        FireProjectile();
    }

    void FireProjectile()
    {
        if (typeOfGun == gunType.MachineGun)
        {
            if (Input.GetButton("Fire1") && Time.time > nextFireTime && !isReloading)
            {
                if (currentMagazineCount > 0)
                {
                    nextFireTime = Time.time + fireRate;

                    float xRand = Random.Range(0, accuracy);
                    float zRand = Random.Range(0, 359);

                    transform.localEulerAngles = new Vector3(xRand, transform.localEulerAngles.y, transform.localEulerAngles.z);
                    transform.Rotate(transform.parent.forward, zRand, Space.World);

                    Rigidbody bullet = Instantiate(projectile, transform.position, transform.rotation, null) as Rigidbody;
                    bullet.transform.localScale = new Vector3(bullet.transform.localScale.x * size, bullet.transform.localScale.y * size, bullet.transform.localScale.z * size);

                    bullet.GetComponent<ProjectileBehavior>().projectileDamage = damage;
                    bullet.GetComponent<ProjectileBehavior>().projectileRange = range;
                    bullet.GetComponent<ProjectileBehavior>().projectileDamageFallOff = damageFallOff;

                    if (bulletDropOn)
                    {
                        bullet.GetComponent<ProjectileBehavior>().projectileDrop = bulletDrop;
                        bullet.GetComponent<ProjectileBehavior>().projectileDropOn = bulletDropOn;
                    }

                    if (AoEOn)
                    {
                        bullet.GetComponent<ProjectileBehavior>().projectileAoESize = AoESize;
                        bullet.GetComponent<ProjectileBehavior>().projectileAoEOn = AoEOn;
                    }


                    bullet.AddForce(transform.forward * velocity);

                    currentMagazineCount--;
                    if (currentMagazineCount < 0)
                        currentMagazineCount = 0;
                }
                else if (currentMagazineCount <= 0)
                {
                    StartCoroutine(Reload());
                }
            }
        }

        if (Input.GetButtonDown("Reload") && !isReloading && currentMagazineCount < magazineSize)
        {
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        print("reloading");
        isReloading = true;
        yield return new WaitForSeconds(reloadSpeed);
        currentMagazineCount = magazineSize;
        isReloading = false;
        print("done");
    }
}
