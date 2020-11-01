using UnityEngine;

public class ProjectileSpawnerLimited : ProjectileSpawnerBase
{

    #region Variables

    [SerializeField]
    [Tooltip("Max number of projectile instances for this spawner.")]
    private int maxProjectiles = 5;

    // Number of projectiles instantiated.
    private int _numProjectiles = 0;

    #endregion


    #region Public methods

    public override Rigidbody SpawnProjectile(Vector3 position) 
    {
        if (_numProjectiles < maxProjectiles)
        {
            _numProjectiles++;
            return Instantiate(base.ProjectileData.Rigidbody, position, Quaternion.identity);
        }
        else 
        {
            return null;
        }
    }

    public override float GetForce()
    {
        return base.ProjectileData.Force;
    }

    #endregion

}
