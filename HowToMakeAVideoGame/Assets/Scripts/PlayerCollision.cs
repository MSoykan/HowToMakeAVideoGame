using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("We hit something" + collision.collider.name);
        if (collision.collider.tag == "Obstacle") {

            movement.enabled = false; // Deactivate the script.
            GameManager.instance.EndGame();
        }
    }
}
