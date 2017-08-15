using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace namager
{
    public class GameManager {

        private static GameManager instance;
        private GameManager() {
        }

        public static GameManager GetInstancse()
        {
            if(instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }

        /// <summary>
        /// 设置大厅IP
        /// </summary>
        public void SetHallIp(JSONObject data)
        {

        }
        /// <summary>
        /// 设置版本信息
        /// </summary>
        /// <param name="data"></param>
        public void SetVersionInfo(JSONObject data)
        {

        }


    }
}
