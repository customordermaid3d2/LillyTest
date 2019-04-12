using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityInjector.Attributes;

namespace COM3D2.LillyTest.Plugin
{
    [PluginFilter("COM3D2x64"), PluginName("COM3D2.LillyTest.Plugin"), PluginVersion("1.0.0.2")]
    public class LillyTest : UnityInjector.PluginBase
    {
        public static string pluginName = "LillyTest";

        // 게임에서 플러그인 처음 불러올시 작동
        public void Awake()
        {
            Console.WriteLine(pluginName + "Awake");
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Console.WriteLine(pluginName + "OnSceneLoaded : " + scene.name + " : " + mode);
        }

        public void OnLevelWasLoaded(int level)
        {
            Console.WriteLine(pluginName + "OnLevelWasLoaded : " + level);            
        }

        public void Update()
        {
            // Called every tick
        }
    }
}
