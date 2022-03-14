using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WordOfTanks
{
    class Services
    {
        public static Random rand = new Random();
    }
    public class Tank
    {
        private String _titles;
        private int _ammunition_level;
        private int _armor_level;
        private int _level_maneuverability;
        public Tank(string titles)
        {
            this._titles = titles;
            this._ammunition_level = Services.rand.Next(100);
            this._armor_level = Services.rand.Next(100);
            this._level_maneuverability = Services.rand.Next(100);
        }

        public String Titles 
        {
            set { this._titles = value; } 
            get { return this._titles; } 
        }
        public int AmmunitionLevel 
        {
            set { this._ammunition_level = value; }
            get { return this._ammunition_level; } 
        }
        public int ArmorLevel 
        {
            set { this._armor_level = value; }
            get { return this._armor_level; } 
        }
        public int LevelManeuverability
        {
            set { this._level_maneuverability = value; }
            get { return this._level_maneuverability; }
        }
        
        public override string ToString() { return String.Format($"Tank(Titles: {_titles}, Ammunition level: {_ammunition_level}%, Armor level: {_armor_level}%," +
            $" Maneuverability: {_level_maneuverability}%)"); }

        public static string operator ^ (Tank t1, Tank t2)
        {
            int superiority_score = 0;

            if (t1.AmmunitionLevel > t2.AmmunitionLevel)
                superiority_score++;
            if (t1.ArmorLevel > t2.ArmorLevel)
                superiority_score++;
            if (t1.LevelManeuverability > t2.LevelManeuverability)
                superiority_score++;
            
            if (superiority_score >= 2)
                return $"Tank defeated: {t1.ToString()}.";
            else
                return $"Tank defeated: {t2.ToString()}.";
        }

        public Tank this[int i] { get { return this[i]; } }
    }
} 