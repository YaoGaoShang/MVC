// ========================================================
// 功能描述：
// 作者：MeKey 
// 创建时间：2019-06-15 10:44:56
// 版 本：1.0
//其他： 
// ========================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMgr : MonoBehaviour
{
    Animal animal;
    AnimalView animalView;
    AnimalController animalController;
    void Start()
    {
        animal = InitAnimal();
        animalView = new AnimalView();
        animalController = new AnimalController(animal, animalView);
        animalController.PrintInfo();
        //更新名字
        animalController.Setname("鸡");
        animalController.PrintInfo();


        //更新名字和种类
        animalController.Settype("海洋生物");
        animalController.Setname("鲨鱼");
        animalController.PrintInfo();
    }


    Animal InitAnimal()
    {
        Animal ani = new Animal();
        ani.Settype("家禽");
        ani.Setname("猪");
        return ani;
    }
}
