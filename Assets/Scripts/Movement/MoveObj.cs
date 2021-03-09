using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    private Vector3 _targetPos;
    private bool _isMove = false;
    private const float DELTA_DISTANCE = 20F;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            CheckTargetToMove();

        Movement();
    }


    private void Movement()
    {
        if (_isMove)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(_targetPos.x, transform.position.y, _targetPos.z), DELTA_DISTANCE * Time.deltaTime);
        else if (transform.position == _targetPos)
            _isMove = false;
    }


    private void CheckTargetToMove()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000))
        {
            _targetPos = hit.point;
            _isMove = true;
        }
    }
}
