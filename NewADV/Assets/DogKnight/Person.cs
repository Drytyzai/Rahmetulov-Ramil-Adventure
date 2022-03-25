using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity
{

    public class Person : MonoBehaviour
    {
        private Vector3 direction;

        private string horizontal = "Horizontal";
        private string vertical = "Vertical";
        private string run = "Run";

        private bool isRunning = false;

        [SerializeField] private float speed = 10f;
        [SerializeField] private float jump = 100f;
        [SerializeField] private float runspeed = 20f;

        private void Update()
        {
            direction.x = Input.GetAxis(horizontal);
            direction.z = Input.GetAxis(vertical);

            isRunning = Input.GetButton(run);
        }

        private void FixedUpdate()
        {
            transform.position += direction * (isRunning ? runspeed : speed) * Time.fixedDeltaTime;
        }
    }
}