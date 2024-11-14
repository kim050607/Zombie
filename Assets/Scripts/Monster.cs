using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float damage = 100;

    public void Attack()
    {
        Debug.Log("공격!");
        //공격 처리...
    }
}

public class Orc : Monster
{
    public override void Attack() 
    {
        base.Attack();
        Debug.Log("우리는 노예가 되지 않는다!");
    }
      public void WarCry()
      {
        Debug.Log("전투함성!");

        //모든 Monster 오브젝트를 찾아 공격력을 10 증가시킴
        Monster[] monsters = FindObjectsOfType<Monster>();
        for (int i = 0; i < monsters.Length; i++)
        {
            monsters[i].damage += 10;
        }
      }
  }
   
    public class Dragon : Monster
    {
       public void Fly()
       {
        Debug.Log("날기!");
        //공중을 나는 처리...
       }
    }
