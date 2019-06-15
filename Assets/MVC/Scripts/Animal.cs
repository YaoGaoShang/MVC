// ========================================================
// 功能描述：   Animal类：  有动物种类  动物名字------------------->model层
// 作者：MeKey 
// 创建时间：2019-06-15 10:34:02
// 版 本：1.0
//其他： 
// ========================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    /// <summary>
    /// 动物种类
    /// </summary>
    public string type;
    /// <summary>
    /// 名字
    /// </summary>
    public string name;


    public void Settype(string type)
    {
        this.type = type;
    }

    public string Gettype()
    {
        return type;
    }

    public void Setname(string name)
    {
        this.name = name;
    }
    public string Getnmae()
    {
        return name;
    }


}
