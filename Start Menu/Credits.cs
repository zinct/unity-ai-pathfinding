using UnityEngine;

public class Credits : MonoBehaviour {
    
    [Header("References")]
    [SerializeField] private Animator targetFade = null; 
    [SerializeField] private GameObject creditText = null; 

    public void Credit() {
        targetFade.SetBool("trigger", true);
        creditText.SetActive(true);
    }

}