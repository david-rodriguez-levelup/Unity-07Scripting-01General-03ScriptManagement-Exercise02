using UnityEngine;

[CreateAssetMenu(fileName = "SpeedData", menuName = "Data/Speed")]
public class SpeedData : ScriptableObject
{

    [SerializeField]
    private float _speed = 5f;

    public float Speed 
    {
        get { return _speed; }
        set { _speed = value; }
    }

}
