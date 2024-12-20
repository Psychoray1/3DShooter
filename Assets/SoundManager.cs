using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Weapon;
public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance {get; set; }

    public AudioSource ShootingChannel;
    
    public AudioClip PistolM1911Shot;
    public AudioClip M16Shot;

   
    public AudioSource reloadingSoundM16;
    public AudioSource reloadingSoundM1911;

    public AudioSource emptyMagazineSoundM1911;
    

    private void Awake()
    {
        if(Instance!=null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayShootingSound(WeaponModel weapon)
    {
        switch(weapon)
        {
            case WeaponModel.PistolM1911:
                ShootingChannel.PlayOneShot(PistolM1911Shot);
                break;
            case WeaponModel.M16:
                ShootingChannel.PlayOneShot(M16Shot);
                break;
        }
    }

     public void PlayReloadSound(WeaponModel weapon)
    {
        switch(weapon)
        {
            case WeaponModel.PistolM1911:
                reloadingSoundM1911.Play();
                break;
            case WeaponModel.M16:
                reloadingSoundM16.Play();
                break;
        }
    }



}