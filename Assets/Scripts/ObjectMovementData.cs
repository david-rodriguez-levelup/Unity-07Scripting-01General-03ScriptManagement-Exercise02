using UnityEngine;

/// <summary>
/// Stores moving-objects related data.
/// </summary>
[CreateAssetMenu(fileName = "ObjectMovementData", menuName = "Data/ObjectMovementData")]
public class ObjectMovementData : ScriptableObject
{

    #region Variables

    [SerializeField]
    [Tooltip("Speed in units per second.")]
    private float _speed = 5f;
    
    /// <summary>
    /// Speed in units per second.
    /// </summary>
    public float Speed 
    {
        get { return _speed; }
        set { _speed = value; }
    }

    #endregion

}
