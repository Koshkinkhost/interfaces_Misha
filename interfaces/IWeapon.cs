using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IWeapon
    {
        string GetName();
        int GetDamage();
        int GetPrice();
    }
    public class Gun : IWeapon
    {
        public int damage;
        public string name;
        public int price;
        public int GetDamage()
        {
            return damage;
        }
        public int GetPrice()
        {
            return price;
        }
        public string GetName()
        {
            return name;
        }
        public override string ToString()
        {
            return $"Урон: {damage}| Название: {name}| Цена: {price}|";
        }

    }
    public class Knife : IWeapon
    {

        public int damage;
        public string name;
        public int price;
        public string GetName()
        {
            return name;
        }

        public int GetDamage()
        {
            return damage;
        }
        public int GetPrice()
        {
            return price;
        }
        public override string ToString()
        {
            return $"Урон: {damage}| Название: {name}| Цена: {price}|";
        }

    }
    public class Bow : IWeapon
    {
        public int damage;
        public string name;
        public int price;

        public string GetName()
        {
            return name;
        }

        public int GetDamage()
        {
            return damage;
        }
        public int GetPrice()
        {
            return price;
        }
        public override string ToString()
        {
            return $"Урон: {damage}| Название: {name}| Цена: {price}|";
        }
    }
}
