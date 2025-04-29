using UnityEngine;

public class Carcontroller : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 myPosition;

    private GameManager gameManager;

    void Start()
    {
        myPosition = transform.position;
        gameManager = FindObjectOfType<GameManager>(); // Find GameManager in scene
    }

    void Update()
    {
        myPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position = myPosition;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            gameManager.GameOver();
            // OPTIONAL: Disable player control after crash
            this.enabled = false;
        }
    }
}
