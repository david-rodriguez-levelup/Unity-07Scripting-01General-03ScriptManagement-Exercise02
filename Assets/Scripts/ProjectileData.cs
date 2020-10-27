using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/Projectile")]
public class ProjectileData : ScriptableObject
{

    [SerializeField]
    private Rigidbody _rigidbody;

    public Rigidbody Rigidbody {
        get { return _rigidbody; }
        set { _rigidbody = value; }
    }

    [SerializeField]
    private float _force = 20;

    public float Force 
    {
        get { return _force; }
        set { _force = value; }
    }

}

