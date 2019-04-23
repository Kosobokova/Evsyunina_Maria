using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class FieldElement //ячейка поля
    {
        var State; //состояние (занято/не занято, если занято, то чем)
    }

    class Field
    {
        FieldElement[] fieldForgame;
    }


    abstract class ImmovableObject //(все неподвижные объекты)
    {
        int coordinate1;
        int coordinate2;
    }

    class Obstacle : ImmovableObject //препятствия (есть тип, расположение задается через ячейку)
    {
        var type;
    }

    class Bonus : ImmovableObject //бонусы (есть тип, есть величина бонуса)
    {
        var type; //тип бонуса (яблоко и т.п.)
        int bonusValue; //величина бонуса, который   получает игрок
    }

    abstract class MovableObject //(все неподвижные объекты)
    {
        int coordinate1;
        int coordinate2;

        public bool CheckObstacle() { }; //проверить, есть ли препятсвие на данный момент
    }

    class Player : MovableObject
    {
        int health;// здоровье игрока
        int coordinate1; // текущее место положения игрока
        int coordinate2;

        public int GetBonus() { }; //получить бонус
        public int GetDamage() { }; // получить урон от монстра
        public bool CheckMonster() { }; //проверить, не сталкивается ли игрок с монстром
        public bool CheckBonus() { }; //проверить, не получает ли игрок бонус

        public bool Move(); // двигать игрока (не может двигаться, если пройдена проверка на препятсвие)
    }

    class Monster : MovableObject
    {
        int damage;// урон от монстра
        int coordinate1; // текущее место положения монстра
        int coordinate2;

        public bool Move(); // двигать игрока (не может двигаться, если пройдена проверка на препятсвие)
    }
}
