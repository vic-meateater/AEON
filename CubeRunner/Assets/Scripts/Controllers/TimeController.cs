using CubeRunner.Interfaces;
using UnityEngine;

namespace CubeRunner.Controllers
{
    public sealed class TimeController : IExecute
    {
        public float GetTime { get; private set; }
        public void Execute()
        {
            GetTime = Time.timeSinceLevelLoad;
        }
    }
}
