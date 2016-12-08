using UnityEngine;

/// <summary>
/// An interactable that gives a buff to the player.
/// </summary>
public abstract class PowerUpItem : MonoBehaviour {

    /// <summary> The player who is affected by the power-up. </summary>
    private GameObject player;
    /// <summary> Timer for the power-up running out. </summary>
    private float timer;
    /// <summary> The duration of the power-up </summary>
    protected abstract float duration {
        get;
    }

    /// <summary>
    /// Causes the player to collect the power-up.
    /// </summary>
    /// <param name="other">The collider that hit the power-up.</param>
    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<UserController>() != null) {
            Destroy(GetComponent<Renderer>());
            Destroy(GetComponent<Collider>());
            Destroy(transform.FindChild("Power Up Icon").gameObject);
            player = other.gameObject;
            transform.parent = player.transform;
            timer = duration;
        }
    }

    /// <summary>
    /// Gives the player a buff while the power-up is in effect.
    /// </summary>
    private void Update() {
        if (player != null) {
            GiveBuff(player);
            timer -= Time.deltaTime;
            if (timer < 0) {
                LoseBuff(player);
                Destroy(gameObject);
            }
        }
    }

    /// <summary>
    /// Gives a temporary buff to the player.
    /// </summary>
    /// <param name="player">The player to give a buff to.</param>
    protected abstract void GiveBuff(GameObject player);

    /// <summary>
    /// Removes the buff from the player when the power-up runs out.
    /// </summary>
    /// <param name="player">The player to remove the buff from.</param>
    protected abstract void LoseBuff(GameObject player);
}