using UnityEngine;

public class PlayerAudio : MonoBehaviour {
    
    [Header("References")]
    [SerializeField] private Rigidbody rb = null;
    [SerializeField] private AudioSource audios = null;

    private bool isWalking = false;

    private void Update() {
        if(Mathf.Abs(rb.velocity.magnitude) > 0)
            if(!isWalking) {
                isWalking = true;
                audios.Play();
            }

        if(Mathf.Abs(rb.velocity.magnitude) == 0)
            if(isWalking) {
                isWalking = false;
                audios.Stop();

            }
    }
}