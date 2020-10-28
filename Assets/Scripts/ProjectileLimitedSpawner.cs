using UnityEngine;

public class ProjectileLimitedSpawner : ProjectileBaseSpawner
{
    // TODO: Implement object pooling!!!

    [SerializeField]
    private int maxProjectiles = 5;

    private int _numProjectiles = 0;

    public override Rigidbody GetProjectile() {
        if (_numProjectiles < maxProjectiles)
        {
            _numProjectiles++;
            return Instantiate(ProjectileData.Rigidbody, transform.position, Quaternion.identity);
        }
        else 
        {
            return null;
        }
    }

    public override float GetForce() {
        return ProjectileData.Force;
    }

}
