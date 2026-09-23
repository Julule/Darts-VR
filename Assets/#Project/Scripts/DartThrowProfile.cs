using UnityEngine;

public class DartThrowProfile : MonoBehaviour
{
    public Vector3 centerOfMass;
    public Rigidbody dart;

    void Start()
    {
        dart = GetComponent<Rigidbody>();
        dart.centerOfMass = centerOfMass;
    }

    // Update is called once per frame
    void Update()
    {
        dart = GetComponent<Rigidbody>();
        //trouver la vitesse de la flechette
        Vector3 dartVelocity = dart.linearVelocity;

        // choper le component Grabbable popur utiliser un bool is grabbed
        // Grabbable grabbabledart = GetComponent<Grabbable>();

        if(dartVelocity.x > 0 && dartVelocity.y > 0 && dartVelocity.z > 0){
            Debug.Log($"Vitesse de la " + dart.name + " : " + dartVelocity);
        }

        // Balancer les istes :

        // faire correspondre ancre1velocity.y à ancre2velocity.y ?

    }

    void OnDrawGizmos()
    {

        if (dart == null) dart = GetComponent<Rigidbody>();
        if (dart != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(dart.worldCenterOfMass, 0.5f);
        }
    }

     
}
