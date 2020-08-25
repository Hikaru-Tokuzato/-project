using System;
using UnityEngine;

namespace Scripts
{
    public class NonActionGrid : MonoBehaviour, IGrid
    {
        public int GetAction()
        {
            return 1;
        }
    }
}
