using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState{
        off,
        on,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;

    public ScoreManager scoreManager;

    private SwitchState state;
    private Renderer renderer;
    public AudioManager audioManager;
    public VFXManager vfxManager;
    // Start is called before the first frame update
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        
        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Toggle();
            
            // sfx aktif
            audioManager.PlaySFXSwitch(other.transform.position);

            // vfx aktif
            vfxManager.PlayVFX(other.transform.position, Color.green);
        }        
    }

    private void Set(bool active)
    {
        if(active == true)
        {
            state = SwitchState.on;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        if(state == SwitchState.on)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }

        scoreManager.AddScore(score);
        
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for(int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);

        }

        state = SwitchState.off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
