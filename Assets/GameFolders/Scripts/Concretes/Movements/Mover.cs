using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Enums;

namespace DragonWars2D.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        float moveSpeed = 5f;
        Rigidbody2D _rigidBody;
        [SerializeField] DirectionEnum direction;
       
        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }
        private void OnEnable()
        {
            
            _rigidBody.velocity = SelectedDirection() * moveSpeed;
        }

        Vector2 SelectedDirection()
        {
            Vector2 selectedDirection;

            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }
            return selectedDirection;
        }
    }
}

