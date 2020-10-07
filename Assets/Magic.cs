using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public float speed = 40;
    public GameObject fireball;
    public Transform Gem;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(fireball, Gem.position, Gem.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * Gem.forward;
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet, 2);
    }
}
