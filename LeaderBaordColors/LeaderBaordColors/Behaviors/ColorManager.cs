using System;
using UnityEngine;

namespace LeaderBaordColors.Behaviors
{
    public class ColorManager : MonoBehaviour
    {
        public Material newmat1;

        public void Start()
        {
            newmat1 = new Material(Shader.Find("GorillaTag/UberShader"));
            GetComponent<MeshRenderer>().material = newmat1;
            ApplyColorFromConfig();
        }

        private void ApplyColorFromConfig()
        {
            string configValue = ConfigManager.Color.Value;

            if (configValue.Equals("playercolor", StringComparison.OrdinalIgnoreCase))
            {
                newmat1.color = GorillaTagger.Instance.offlineVRRig.playerColor;
            }
            else if (ColorUtility.TryParseHtmlString(configValue, out Color parsedColor))
            {
                newmat1.color = parsedColor;
            }
            else
            {
                Debug.LogError($"[LeaderboardColors] Invalid color value in config: {configValue}");
                newmat1.color = Color.white;
            }
        }

        private void Update()
        {
            if (ConfigManager.Color.Value.Equals("playercolor", StringComparison.OrdinalIgnoreCase))
            {
                newmat1.color = GorillaTagger.Instance.offlineVRRig.playerColor;
            }
        }
    }
}