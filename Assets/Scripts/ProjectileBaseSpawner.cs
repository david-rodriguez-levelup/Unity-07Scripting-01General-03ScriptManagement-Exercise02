using UnityEngine;

public abstract class ProjectileBaseSpawner : MonoBehaviour
{

    [SerializeField]
    private ProjectileData _projectileData;

    protected ProjectileData ProjectileData {
        get { return _projectileData; }
        set { _projectileData = value; }
    }

    public abstract Rigidbody GetProjectile();

    public abstract float GetForce();

}
