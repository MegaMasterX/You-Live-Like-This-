using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


public class Loudspeaker : MonoBehaviour
{
    public int LoudspeakerRandomEmitTimer = 0;
    AudioSource sAudio;

    //========Configured Voice Lines=======
    [BoxGroup("General VO Lines")]
    public AudioClip General1;
    [BoxGroup("General VO Lines")]
    public AudioClip General2;
    [BoxGroup("General VO Lines")]
    public AudioClip General3;
    [BoxGroup("General VO Lines")]
    public AudioClip General4;
    [BoxGroup("General VO Lines")]
    public AudioClip General5;
    [BoxGroup("General VO Lines")]
    public AudioClip General6;

    [BoxGroup("Chili VO Lines")]
    public AudioClip Chili1;
    [BoxGroup("Chili VO Lines")]
    public AudioClip Chili2;
    [BoxGroup("Chili VO Lines")]
    public AudioClip Chili3;
    [BoxGroup("Chili VO Lines")]
    public AudioClip Chili4;
    [BoxGroup("Chili VO Lines")]
    public AudioClip Chili5;
    [BoxGroup("Chili VO Lines")]
    public AudioClip Chili6;

    [BoxGroup("Water VO Lines")]
    public AudioClip Water1;

    [BoxGroup("Toys VO Lines")]
    public AudioClip Toys1;
    [BoxGroup("Toys VO Lines")]
    public AudioClip Toys2;
    [BoxGroup("Toys VO Lines")]
    public AudioClip Toys3;

    [BoxGroup("Wood VO Lines")]
    public AudioClip Wood1;
    [BoxGroup("Wood VO Lines")]
    public AudioClip Wood2;
    [BoxGroup("Wood VO Lines")]
    public AudioClip Wood3;
    [BoxGroup("Wood VO Lines")]
    public AudioClip Wood4;

    [BoxGroup("Computer VO Lines")]
    public AudioClip Comp1;
    [BoxGroup("Computer VO Lines")]
    public AudioClip Comp2;
    [BoxGroup("Computer VO Lines")]
    public AudioClip Comp3;
    [BoxGroup("Computer VO Lines")]
    public AudioClip Comp4;

    [BoxGroup("Client VO Lines")]
    public AudioClip Client1;

    void Start()
    {
        LoudspeakerRandomEmitTimer = Random.Range(25, 100); //This sets the cooldown for a random General voice line.
        sAudio = GetComponent<AudioSource>();
        StartCoroutine(SpeakerEmitSeconds());
    }

    IEnumerator SpeakerEmitSeconds()
    {
        yield return new WaitForSeconds(1.0f);
        if (LoudspeakerRandomEmitTimer != 0)
            LoudspeakerRandomEmitTimer--;
        else
        {
            PlayRandomGeneralVO();
            LoudspeakerRandomEmitTimer = Random.Range(120, 200);
        }
        StartCoroutine(SpeakerEmitSeconds());
    }

    public void PlayRandomComputerVO()
    {
        int PlayIndex = Random.Range(1, 9);
        switch (PlayIndex)
        {
            case 1:
                PlayClip(Comp1);
                break;
            case 2:
                PlayClip(Comp2);
                break;
            case 3:
                StartCoroutine(PlayAudioChain(3, Comp3, Comp4));
                break;
            case 4:
                StartCoroutine(PlayAudioChain(3, Comp3, Comp4));
                break;
            default:
                break;
        }
    }

    public void PlayRandomChiliVO()
    {
        int PlayIndex = Random.Range(1, 22); //6-8 should be no voice lines to ensure they aren't getting any sort of repetitiveness.
        switch (PlayIndex)
        {
            case 1:
                PlayClip(Chili1);
                break;
            case 2:
                PlayClip(Chili2);
                break;
            case 3:
                PlayClip(Chili3);
                break;
            case 4:
                PlayClip(Chili4);
                break;
            case 5:
                PlayClip(Chili5);
                break;
            

            default:
                break;
        }
    }

    public void PlayRandomToyVO()
    {
        int PlayIndex = Random.Range(1, 20);
        switch (PlayIndex)
        {
            case 1:
                PlayClip(Toys1);
                break;
            case 3:
                PlayClip(Toys2);
                break;
            case 5:
                PlayClip(Toys3);
                break;
            default:
                break;
        }
    }

    public void PlayRandomWaterVO()
    {
        int PlayIndex = Random.Range(1, 10);
        switch (PlayIndex)
        {
            case 2:
                PlayClip(Water1);
                break;
            default:
                break;
        }
    }

    public void PlayRandomWoodVO()
    {
        int PlayIndex = Random.Range(1, 20);
        switch (PlayIndex)
        {
            case 1:
                PlayClip(Wood1);
                break;
            case 14:
                StartCoroutine(PlayAudioChain(4, Wood2, Wood3));
                break;
            case 7:
                PlayClip(Wood4);
                break;
            case 4:
                //StartCoroutine(PlayAudioChain(4, Wood2, Wood3));
                break;
            default:
                break;
        }
    }

    void PlayRandomGeneralVO()
    {
        int LineIndex = Random.Range(1, 8);
        switch (LineIndex)
        {
            case 1:
                PlayClip(General1);
                break;
            case 2:
                PlayClip(General2);
                break;
            case 3:
                PlayClip(General3);
                break;
            case 4:
                PlayClip(General4);
                break;
            case 5:
                PlayClip(General5);
                break;
            case 6:
                PlayClip(General6);
                break;
            default:
                break;
        }
    }

    void PlayClip(AudioClip clip)
    {
        sAudio.clip = clip;
        sAudio.Play();
    }

    IEnumerator PlayAudioChain(int Delay, AudioClip FirstClip, AudioClip SecondClip)
    {
        PlayClip(FirstClip);
        yield return new WaitForSeconds(1.0f * Delay);
        PlayClip(SecondClip);
        //PSUEDO: Play the Followup Clip, newClip.
    }

}
