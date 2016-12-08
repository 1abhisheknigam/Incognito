using UnityEngine;

/// <summary>
/// Heals the player.
/// </summary>
public class HealthPower : PowerUpItem {

    /// <summary>
    /// Gets the duration.
    /// </summary>
    /// <value>The duration.</value>
    protected override float duration {
        get { return 0; }
    }

    /// <summary>
    /// Gives a temporary buff to the player.
    /// </summary>
    /// <param name="player">The player to give a buff to.</param>
    protected override void GiveBuff(GameObject player) {
        Health health = player.GetComponent<Health>();
        health.health = health.maxHealth;
    }

    /// <summary>
    /// Removes the buff from the player when the power-up runs out.
    /// </summary>
    /// <param name="player">The player to remove the buff from.</param>
    protected override void LoseBuff(GameObject player) {
    }
}