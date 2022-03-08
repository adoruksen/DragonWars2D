using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonWars2D.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.RestartGameFunc();
        }
        public void NoButtonClick()
        {

        }
    }
}

