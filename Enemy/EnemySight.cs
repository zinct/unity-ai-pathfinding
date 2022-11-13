using System;
using UnityEngine;

public class EnemySight : MonoBehaviour {

    [Header("References")]
    [SerializeField] private Transform targetObject = null;

    [Header("Settings")]
    [SerializeField] private float radius = 0f;
    [SerializeField] private float angle = 0f;
    [SerializeField] private LayerMask targetMask = 0;

    public event Action<Transform> onSpotted;

    private void Update() {
        
        // Deteksi semua objek yang didalam radius, lalu masukan ke array
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius, targetMask);

        // Ambil semua isi dari array colliders
        foreach(Collider collider in colliders) {
            
            // Cek apakah objek berada di radius, seleksi menggunakan nama objek
            if(IsTargetInRadius(collider))

                // Cek Apabila target objek sudah memasuki jangkauan angle
                if(IsTargetInAngle())
                    
                    // Cek Apabila Ada suatu objek yang menghalanginya
                    if(!IsTargetBlocked())
                        onSpotted?.Invoke(targetObject);
            else
                return;
        }

        
    }

    private bool IsTargetBlocked() {

        Ray ray = new Ray(transform.position, targetObject.position - transform.position);
        RaycastHit hit;

        // Cek jika ada objek lain menghalanginya
        if(Physics.Raycast(ray, out hit, radius)) {
            
            if(hit.collider.gameObject != targetObject.gameObject)
                return true;

        }

        return false;

    }

    private bool IsTargetInAngle() {
        
        // Ambil Target Angle
        float targetAngle = Vector3.Angle(transform.forward, targetObject.position - transform.position);
        
        // Cek apabila target angle berada di angle yang sudah ditentukan
        if(targetAngle < angle)
            return true;
        return false;

    }

    private bool IsTargetInRadius(Collider collider) {
        if(collider.gameObject == targetObject.gameObject)
            return true;
        return false;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
        Vector3 dir1 = Quaternion.AngleAxis(angle, Vector3.up) * transform.forward * radius;
        Vector3 dir2 = Quaternion.AngleAxis(-angle, Vector3.up) * transform.forward * radius;
        Gizmos.DrawRay(transform.position, dir1);
        Gizmos.DrawRay(transform.position, dir2);
    }


}