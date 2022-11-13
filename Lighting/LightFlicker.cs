using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {
    
    [Header("References")]
    [SerializeField] private new Light light = null;
    public float increasing = 0f;
    public float decreasing = 0f;
    public float maxTime = 0f;
    public float minTime = 0f;

    private void Update() {
        StartCoroutine(StartFlickering());
    }

    private IEnumerator StartFlickering() {
        // Mengurangi Cahaya
        light.intensity = Mathf.Lerp(light.intensity, 0f, decreasing);
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        light.intensity = Mathf.Lerp(light.intensity, 10f, increasing);
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        StartCoroutine(StartFlickering());
    }

}