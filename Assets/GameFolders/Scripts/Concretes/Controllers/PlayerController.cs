using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonWars2D.Movements;
using DragonWars2D.Combats;

namespace DragonWars2D.Controllers 
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidBody;
        bool _isLeftMouseClicked;
        Jump _jump;
        InputController _inputController;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;
        
        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _inputController = new InputController();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (_inputController.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;
            }
            if (_inputController.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();
            }
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidBody);
                _audioSource.Play();
                _isLeftMouseClicked = false;
            }
        }
        
    }
}

