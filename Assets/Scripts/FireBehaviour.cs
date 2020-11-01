using UnityEngine;

public class FireBehaviour : MonoBehaviour
{

    #region Variables

    [SerializeField]
    [Tooltip("GameObject containing a ProjectileSpawnerBase component.")]
    private ProjectileSpawnerBase _projectileSpawner; // Decouples projectile instantiation from firing!
    
    #endregion


    #region Public methods

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
