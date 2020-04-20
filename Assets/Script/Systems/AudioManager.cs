using UnityEngine;
using System.Collections;
using Sirenix.OdinInspector;
/// <summary>
/// This script is for managing the Audio emitter(s), BGM, and sound effects for the game.
/// </summary>
public class AudioManager : MonoBehaviour
{
    [BoxGroup("Emitters")]
    public AudioSource playerEmitter;

    [BoxGroup("Emitters")]
    public AudioSource BackgroundMusic;

    [BoxGroup("Sound Efects")]
    public AudioClip CurrentClip;

    [BoxGroup("BGM")]
    public AudioClip BGMNormal;
    [BoxGroup("BGM")]
    public AudioClip BGMFaster;

    [BoxGroup("SFX")]
    public AudioClip BucketFullPickup;
    [BoxGroup("SFX")]
    public AudioClip BucketFullDrop;
    [BoxGroup("SFX")]
    public AudioClip BucketEmptyPickup;
    [BoxGroup("SFX")]
    public AudioClip BucketEmptyDrop;

    [BoxGroup("SFX")]
    public AudioClip PCReboot;

    public void PlaySound(AudioClip clip)
    {
        playerEmitter.clip = clip;
        playerEmitter.Play();
    }

    public void PlayBGM(AudioClip music, bool Looping)
    {
        BackgroundMusic.Stop(); //Halt any currently playing BGM
        BackgroundMusic.loop = Looping; //Sets this to whatever is passed in.
        BackgroundMusic.clip = music; //Sets the clip to whatever is passed in.
        BackgroundMusic.Play(); //Play that funky beat!
    }

    public void PlayKeyboardTyping()
    {
        playerEmitter.clip = PCReboot;
        playerEmitter.Play();
    }

    public void PlayFullPickup()
    {
        playerEmitter.clip = BucketFullPickup;
        playerEmitter.Play();

    }
    public void PlayEmptyPickup()
    {
        playerEmitter.clip = BucketEmptyPickup;
        playerEmitter.Play();

    }
    public void PlayFullDrop()
    {
        playerEmitter.clip = BucketFullDrop;
        playerEmitter.Play();
    }
    public void PlayEmptyDrop()
    {
        playerEmitter.clip = BucketEmptyDrop;
        playerEmitter.Play();
    }
}
