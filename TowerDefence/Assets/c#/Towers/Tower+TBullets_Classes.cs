using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

    namespace Custom_nmspc
{
    public class Tower
    {

        public float HP;
        public float Shield_HP;
        public float Range;
        public float Phys_Range;
        public float Speed;
        public float Damage;
        public float CoolDown;
        public float CurrentCoolDown;
        public Transform I; 

        public Tower()
        {
            HP = 1000;
            Shield_HP = 0;
            Range = 5;
            Phys_Range = 20;
            Speed = 10;
            Damage = 10;
            CoolDown = 1;
            CurrentCoolDown = 0;
            
        }

        public Tower(float HP, float Shield_HP, float Range, float Phys_Range, float Speed, float Damage)
        {
            this.HP = HP;
            this.Shield_HP = Shield_HP;
            this.Range = Range;
            this.Phys_Range = Phys_Range;
            this.Speed = Speed;
            this.Damage = Damage;
        }

        public bool CanShoot()
        {
            if (CurrentCoolDown <= 0)
                return true;
            else return false;
        } 

        public void SearchTarget()
        {
            Transform nearestEnemy = null;
            float nearestEnemyDistance = Mathf.Infinity;

            foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                float currDistance = Vector2.Distance(I.transform.position, enemy.transform.position);

                if ((currDistance < nearestEnemyDistance) && (currDistance <= Range))
                {
                    nearestEnemy = enemy.transform;
                    nearestEnemyDistance = currDistance;
                }
            }

            if (nearestEnemy != null)
            {
                Shoot(nearestEnemy);
            }
        }

        void Shoot(Transform enemy)
        {

        }

        public Tower Destroy_Tower(float Enemy_DMG)
        {
            Tower T = new Tower(HP, Shield_HP, Range, Phys_Range, Speed, Damage);
            if (T.Shield_HP > 0)
            {
                if (T.Shield_HP - Enemy_DMG < 0)
                {
                    Enemy_DMG -= T.Shield_HP;
                    T.Shield_HP = 0;
                    T.HP -= Enemy_DMG;
                }
                else
                {
                    T.Shield_HP -= Enemy_DMG;
                }
            }
            return T;
        }

    }
    
    public class Tower_Bullets 
    { 
        public float DMG;
        public float AOE;
        public float SPD;
        public float Pushing;
        public bool Paralyze;
        public bool Through_Bullet;
        
        public Tower_Bullets(float Damage)
        {
            DMG = Damage;
            AOE = 0;
            SPD = 10;
            Pushing = 0;
            Paralyze = false;
            Through_Bullet = false;
        }

    }
}
