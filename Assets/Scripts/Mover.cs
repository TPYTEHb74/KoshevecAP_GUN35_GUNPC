using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _start;
    [SerializeField] private Vector3 _end;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _delay = 1f;

    private Rigidbody _rb;
    private bool _movingToEnd = true;
    private float _waitTime;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.isKinematic = true;
        transform.position = _start;

        StartCoroutine(MoveObject());
    }

    private System.Collections.IEnumerator MoveObject()
    {
        while (true)
        {
            Vector3 target = _movingToEnd ? _end : _start;

            if (Vector3.Distance(transform.position, target) > 0.01f)
            {
                Vector3 newPos = Vector3.MoveTowards(transform.position, target, _speed * Time.fixedDeltaTime);
                _rb.MovePosition(newPos);
                yield return new WaitForFixedUpdate();
            }
            else
            {
                _waitTime += Time.fixedDeltaTime;
                if (_waitTime >= _delay)
                {
                    _movingToEnd = !_movingToEnd;
                    _waitTime = 0f;
                }
                yield return new WaitForFixedUpdate();
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(_start, 0.2f);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(_end, 0.2f);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(_start, _end);

        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.red;
        UnityEditor.Handles.Label(_start + Vector3.up * 0.3f, "Start", style);

        style.normal.textColor = Color.red;
        UnityEditor.Handles.Label(_end + Vector3.up * 0.3f, "End", style);
    }
}
