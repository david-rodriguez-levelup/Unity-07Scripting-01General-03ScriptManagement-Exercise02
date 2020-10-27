using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    
    [SerializeField]
    private ProjectileData _projectileData;
    
    public void Fire(Vector3 target) {
        print(_projectileData);
        var projectile = Instantiate(_projectileData.Rigidbody, transform.position, Quaternion.identity);
        var projectileDelta = target - transform.position;
        projectile.AddForce(projectileDelta.normalized * _projectileData.Force);
    }

}
