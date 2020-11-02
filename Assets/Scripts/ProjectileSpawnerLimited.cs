using UnityEngine;

/// <summary>
/// A projectile spawner with only <see cref="_maxProjectiles"/> projectiles.
/// </summary>
public class ProjectileSpawnerLimited : ProjectileSpawnerBase
{

    #region Variables

    [SerializeField]
    [Tooltip("Max number of projectile instances for this spawner.")]
    private int _maxProjectiles = 5;

    // Number of projectiles spawned.
    private int _spawnedProjectiles = 0;

    #endregion


    #region Public methods

    /// <summary>    
    /// If the number of projectiles spawned is less than <see cref="_maxProjectiles"/> then instantiates 
    /// the projectile defined by <see cref="ProjectileData"/> in the specified position. Otherwhise returns <c>null</c>.
    /// </summary>
    /// <return>An instance of a projectile or <c>null</c> if a new projectile cannot be instantiated.</return>
    public override Rigidbody SpawnProjectile(Vector3 position) 
    {
        if (_spawnedProjectiles < _maxProjectiles)
        {
            _spawnedProjectiles++;
            return Instantiate(base.ProjectileData.Rigidbody, position, Quaternion.identity);
        }
        else 
        {
            return null;
        }
    }

    #endregion

}
