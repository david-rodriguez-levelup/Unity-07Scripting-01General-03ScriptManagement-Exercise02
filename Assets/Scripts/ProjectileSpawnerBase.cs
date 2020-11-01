using UnityEngine;

public class ProjectileSpawnerBase : MonoBehaviour
{

    #region Variables

    [SerializeField]
    private ProjectileData _projectileData;

    /// <summary>
    /// Projectile data asset.
    /// </summary>
    protected ProjectileData ProjectileData 
    {
        get { return _projectileData; }
        set { _projectileData = value; }
    }

    #endregion


    #region Public methods

    /// <summary>
    /// Instantiates the projectile defined by ProjectileData.
    /// </summary>
    /// <return>An instance of a projectile or null if a projectile cannot be instantiated.</return>
    public virtual Rigidbody SpawnProjectile(Vector3 position) 
    {
        return Instantiate(ProjectileData.Rigidbody, position, Quaternion.identity);
    }

    /// <summary>
    /// Returns the force of the projectiles whern fired.
    /// </summary>
    /// <return>the force of the projectiles whern fired.</return>
    public virtual float GetForce() 
    {
        return ProjectileData.Force;
    }

    #endregion

}
