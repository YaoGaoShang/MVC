﻿using System.IO;

namespace UGUIFrameWorkEditor
{
    public class MeKeyTitle : UnityEditor.AssetModificationProcessor
    {
        /// <summary>
        /// 在资源创建时调用
        /// </summary>
        /// <param name="path">自动传入资源路径</param>
        public static void OnWillCreateAsset(string path)
        {
            path = path.Replace(".meta", "");
            if (!path.EndsWith(".cs")) return;
            string allText = "// ========================================================\r\n"
                             + "// 功能描述：\r\n"
                             + "// 作者：MeKey \r\n"
                             + "// 创建时间：#CreateTime#\r\n"
                             + "// 版 本：1.0\r\n"
                             +"//其他： \r\n"
                             + "// ========================================================\r\n";
            allText += File.ReadAllText(path);
            allText = allText.Replace("#CreateTime#", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            File.WriteAllText(path, allText);
        }
    }
}
