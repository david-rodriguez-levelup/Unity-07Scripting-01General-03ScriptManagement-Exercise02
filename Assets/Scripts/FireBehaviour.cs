using UnityEngine;

/// <summary>
/// Fire behaviour.
/// Inject a <see cref="ProjectileSpawnerBase"/> in the inspector 
/// and call <see cref="Fire(UnityEngine.Vector3)"/> to pew! pew!!!
/// </summary>
/// <see cref="ProjectileSpawnerBase"/>
/// <see cref="ProjectileData"/>
public class FireBehaviour : MonoBehaviour
{

    #region Variables

    [SerializeField]
    [Tooltip("GameObject containing a ProjectileSpawnerBase component.")]
    private ProjectileSpawnerBase _projectileSpawner;

    #endregion


    #region Public methods

    /// <summary>
    /// Calls its <see cref="ProjectileSpawnerBase"/> for a new projectile instance.
    /// If a projectiles exists, this method adds to the projectile a force of magnitude <see cref="ProjectileSpawnerBase.GetForce"/></see>
    /// in the direction of target.
    /// </summary>
    /// <param name="target">Target of the projectile.</param>
    public void Fire(Vector3 target) 
    {
        // Try to spawn a projectile from the spawner.
        var projectile = _projectileSpawner.SpawnProjectile(transform.position);        

        // If a projectile has been spawned, then fire it!
        if (projectile != null) {
            var projectileDelta = target - transform.position;
            projectile.AddForce(projectileDelta.normalized * _projectileSpawner.GetForce());
        }
    }

    #endregion

}
