using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        if (_rigidbody != null)
        {
            _rigidbody.isKinematic = true;
        }
        else
        {
            Debug.LogWarning("Rotator requires a Rigidbody component to work properly.");
        }

        StartCoroutine(RotateObject());
    }

    private System.Collections.IEnumerator RotateObject()
    {
        while (true)
        {
            if (_rigidbody != null)
            {
                Quaternion deltaRotation = Quaternion.Euler(_rotate * Time.deltaTime);
                _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
            }
            yield return null; 
        }
    }
}