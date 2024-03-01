using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudioSource;

    public void PlayVFX(Vector3 spawnPosition, Color color)
    {
        GameObject vfxInstance = GameObject.Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);
        var particleSystems = vfxInstance.GetComponentsInChildren<ParticleSystem>();
        foreach (var ps in particleSystems)
        {
            var mainModule = ps.main;
            mainModule.startColor = color;
        }
    }
}
