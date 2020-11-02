using UnityEngine;

/// <summary>
/// Base class for projectile spawners.
/// </summary>
public class ProjectileSpawnerBase : MonoBehaviour
{

    #region Variables

    [SerializeField]
    [Tooltip("Projectile data asset.")]
    private ProjectileData _projectileData;

    /// <summary>
    /// Projectile data asset. Can be used by subclasses for specific purposes.
    /// </summary>
    protected ProjectileData ProjectileData 
    {
        get { return _projectileData; }
        set { _projectileData = value; }
    }

    #endregion


    #region Public methods

    /// <summary>
    /// Instantiates the projectile defined by <see cref="ProjectileData"></cref> in the specified position.
    /// Subclasses can override this method for specific purposes.
    /// </summary>
    /// <return>An instance of a projectile in the specified position or <c>null</c> if a new projectile cannot be instantiated.</return>
    /// <see cref="FireBehaviour"/>
    public virtual Rigidbody SpawnProjectile(Vector3 position) 
    {
        return Instantiate(ProjectileData.Rigidbody, position, Quaternion.identity);
    }

    /// <summary>
    /// Returns the force to apply on the projectiles when fired.
    /// Subclasses can override this method for specific purposes.
    /// </summary>
    /// <return>Force of the projectiles when fired.</return>
    /// <see cref="FireBehaviour"/>
    public virtual float GetForce() 
    {
        return ProjectileData.Force;
    }

    #endregion

}
