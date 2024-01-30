using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 _input;
    [SerializeField] private Vector2 moveSpeed;
    [SerializeField] private float boundsleft = -5;
    [SerializeField] private float boundsright= 5;
    [SerializeField] private float boundup = -2f;
    [SerializeField] private float bounddown= -15f;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        _rb.velocity = _input * moveSpeed;

        Vector2 position = (Vector2)transform.position;

        position.x = Mathf.Clamp(position.x, boundsleft, boundsright);
        position.y = Mathf.Clamp(position.y, bounddown, boundup);

        transform.position = position;
    }
}
