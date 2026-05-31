using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * bulletSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground"|| other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
