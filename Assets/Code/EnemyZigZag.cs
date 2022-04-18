using UnityEngine;

public class EnemyZigZag : MonoBehaviour
{
    Rigidbody enemyRb;
    float random;
    float randomSpeed;

    private void Start() 
    {
        enemyRb = GetComponent<Rigidbody>();
        random = Random.Range(3f, 8f);
        randomSpeed = Random.Range(3f, 6f);
    }

    private void FixedUpdate() 
    {
        Movement();
    }

    void Movement()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, random) * randomSpeed, transform.position.y, transform.position.z);
    }
}
