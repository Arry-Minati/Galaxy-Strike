using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

    //COLLIDER TESTING
    // private void Start()
    // {
    //     Debug.Log("start");
    // }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
