using UnityEngine;

/// <summary>
/// Stores projectile related data.
/// </summary>
[CreateAssetMenu(fileName = "ProjectileData", menuName = "Data/ProjectileData")]
public class ProjectileData : ScriptableObject
{

    #region Variables

    /// <summary>
    /// GameObject with a <see cref="Rigidbody"/> component to be fired.
    /// </summary>
    public Rigidbody Rigidbody 
    {
        get { return _rigidbody; }
        set { _rigidbody = value; }
    }

    /// <summary>
    /// Force to apply on the projectile when fired.
    /// </summary>
    public float Force 
    {
        get { return _force; }
        set { _force = value; }
    }    

    [SerializeField]
    [Tooltip("GameObject with a Rigidbody component.")]
    private Rigidbody _rigidbody;

    [SerializeField]
    [Tooltip("Force to apply on the projectile when fired.")]
    private float _force = 20;

    #endregion

}

