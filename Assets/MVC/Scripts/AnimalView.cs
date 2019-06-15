// ========================================================
// 功能描述：用于输出信息   ----------------》view层
// 作者：MeKey 
// 创建时间：2019-06-15 10:38:20
// 版 本：1.0
//其他： 
// ========================================================
using UnityEngine;

public class AnimalView 
{
    public void PrintInfo(string type, string name)
    {
        Debug.Log("Type:\t"+type );
        Debug.Log("Name:\t"+ name);
    }
}
