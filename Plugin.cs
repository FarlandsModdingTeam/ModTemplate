using BepInEx;
using CommandTerminal;
using Farlands.Inventory;
using Farlands.PlantSystem;
using FarlandsCoreMod;
using FarlandsCoreMod.Extensors;
using System.Diagnostics;
using System.Linq;
using FarlandsCoreMod.Utiles.Sprites;
using UnityEngine;
namespace TemplateMod
{
    [BepInPlugin("magin.template", "YOUR MOD", "0.0.0")]
    public class TemplateMod : AbstractMod
    {
        
        public override Sprite LoadSprite(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
