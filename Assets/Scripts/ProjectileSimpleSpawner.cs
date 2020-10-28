using UnityEngine;

public class ProjectileSimpleSpawner : ProjectileBaseSpawner
{

    public override Rigidbody GetProjectile() {
        return Instantiate(ProjectileData.Rigidbody, transform.position, Quaternion.identity);
    }

    public override float GetForce() {
        return ProjectileData.Force;
    }

}
