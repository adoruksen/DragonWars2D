using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonWars2D.Movements
{
    public class Jump : MonoBehaviour
    {
        float jumpForce = 300f;

        public void JumpAction(Rigidbody2D _rigidBody)
        {
            _rigidBody.velocity = Vector2.zero;
            _rigidBody.AddForce(Vector2.up * jumpForce);
        }
        void Start()
        {

        }

        void Update()
        {

        }
    }
}

