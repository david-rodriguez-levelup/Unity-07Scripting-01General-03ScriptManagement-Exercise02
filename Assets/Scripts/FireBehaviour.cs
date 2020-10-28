using UnityEngine;

public class FireBehaviour : MonoBehaviour
{

    [SerializeField]
    private ProjectileBaseSpawner _projectileSpawner; // Decouples projectile instantiation (and reuse) from firing!
    
    public void Fire(Vector3 target) {
        // QUESTION: What is the best way to implement a pool for the projectiles?
        // - Inside FireBehaviour with something like "new ProjectilePool()"?
        // - Could the ProjectileData object (ScriptableObject) include its own pool? (sounds a bit strange to me!).
        // - External class (or interface) injected via inspector or finded at runtime? <--- THIS?
        var projectile = _projectileSpawner.GetProjectile();
        if (projectile != null) {
            var projectileDelta = target - transform.position;
            projectile.AddForce(projectileDelta.normalized * _projectileSpawner.GetForce());
        }
    }

}
