using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/Projectile")]
public class ProjectileData : ScriptableObject
{

    #region Variables

    /// <summary>
    /// GameObject with a rigid body component.
    /// </summary>
    public Rigidbody Rigidbody 
    {
        get { return _rigidbody; }
        set { _rigidbody = value; }
    }

    /// <summary>
    /// Impulse of the projectile when fired.
    /// </summary>
    public float Force 
    {
        get { return _force; }
        set { _force = value; }
    }    

    [SerializeField]
    [Tooltip("GameObject with a rigid body component.")]
    private Rigidbody _rigidbody;

    [SerializeField]
    [Tooltip("Impulse of the projectile when fired.")]
    private float _force = 20;

    #endregion

}

