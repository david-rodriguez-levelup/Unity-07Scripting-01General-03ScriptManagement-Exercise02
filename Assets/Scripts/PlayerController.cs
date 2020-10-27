using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private MoveBehaviour _myMoveBehaviour;
    private FireBehaviour _myFireBehaviour;

    private void Awake() {
        _myMoveBehaviour = GetComponent<MoveBehaviour>();
        _myFireBehaviour = GetComponent<FireBehaviour>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        _myMoveBehaviour.Move(horizontal, vertical);

        if (Input.GetButtonDown("Fire1"))
        {
            var mouseInput = Input.mousePosition;
            mouseInput.z = 10;
            var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
            mousePosition.z = 0;
            _myFireBehaviour.Fire(mousePosition);
         }
    }

}
