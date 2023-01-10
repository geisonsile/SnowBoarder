using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    [SerializeField] AudioClip boardSlidingSFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            dustParticles.Play();
            //AudioSource.PlayClipAtPoint(boardSlidingSFX, gameObject.transform.position);
            GetComponent<AudioSource>().PlayOneShot(boardSlidingSFX);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
            GetComponent<AudioSource>().Stop();
        }
    }
}
