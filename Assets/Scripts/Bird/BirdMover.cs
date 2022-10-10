using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _maxRotationZ;
    [SerializeField] private float _minRotationZ;
    [SerializeField] private float _tapForce;

    private Vector3 _startPosition;
    private Rigidbody2D _rigidbody;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;
    private bool _canFly;
    private int _number = 200;
    private Rect _bounds;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
        _bounds = new Rect(0, 0, Screen.width, Screen.height - _number);

        ResetBird();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _canFly && _bounds.Contains(Input.mousePosition))
        {
            _rigidbody.velocity = new Vector2(_speed, 0);
            transform.rotation = _maxRotation;
            _rigidbody.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
    }

    public void ResetBird()
    {
        transform.position = _startPosition;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        _rigidbody.velocity = Vector2.zero;
    }

    public void SetTheBoolToFly(bool canFly)
    {
        _canFly = canFly;
    }
}
