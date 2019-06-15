// ========================================================
// 功能描述： 控制  model和view层                         ---------------------》Controller层
// 作者：MeKey 
// 创建时间：2019-06-15 10:38:36
// 版 本：1.0
//其他： 
// ========================================================
using UnityEngine;

public class AnimalController
{
    Animal animal;
    AnimalView animalView;

    public AnimalController(Animal animal, AnimalView animalView)
    {
        this.animal = animal;
        this.animalView = animalView;
    }


    public void Settype(string type)
    {
        animal.Settype(type);
    }

    public string Gettype()
    {
        return animal.Gettype();
    }

    public void Setname(string name)
    {
        animal.Setname(name);
    }
    public string Getname()
    {
        return animal.Getnmae();
    }

    public void PrintInfo()
    {
        animalView.PrintInfo(animal.Gettype(), animal.Getnmae());
    }
}
