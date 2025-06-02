using System;
using Input;
using UnityEngine;

namespace Player
{
    public class PlayerMovement:MonoBehaviour
    {
        private InputManager _inputManager;

        private void Start()
        {
            _inputManager.PlayerMode();
        }

        private void Update()
        {
            Debug.Log(_inputManager.PlayerInput.Movement.Get());
        }

        private void OnEnable()
        {
            _inputManager = InputManager.Instance;
            _inputManager.PlayerInput.Attack.OnDown += Attack;
        }

        private void OnDisable()
        {
            _inputManager.PlayerInput.Attack.OnDown -= Attack;
        }

        private void Attack()
        {
            Debug.Log("ATTACK");
        }
    }
}